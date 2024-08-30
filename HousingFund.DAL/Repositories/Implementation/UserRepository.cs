using AutoMapper;
using HousingFund.DAL.Context;
using HousingFund.DAL.Entities.Security.User.Models;
using HousingFund.DAL.Mapping;
using HousingFund.DAL.Repositories.Interface;
using HousingFund.DAL.Utilities;
using HousingFund.DAL.ViewModels.Security.Login;
using HousingFund.DAL.ViewModels.Security.User;

namespace HousingFund.DAL.Repositories.Implementation
{
    public class UserRepository : IUserRepository
    {

        #region Constructor
        private readonly HousingFundContext _context;
        private readonly IMapper _mapper;

        public UserRepository()
        {
            _context = new HousingFundContext();
            var mappingConfig = new MappingConfig();
            _mapper = mappingConfig.CreateMapper();
        }
        #endregion

        public bool Login(LoginVM model, out string message)
        {
            bool result = false;

            string resultMessage = "کاربری با مشخصات وارده یافت نشد.";

            if (model != null)
            {

                var user = _context.Users
                                   .Where(u => u.UserName == model.UserName
                                            &&
                                            u.IsAdmin == true
                                            &&
                                            u.IsActive == true)
                                   .FirstOrDefault();
                if (user != null)
                {
                    string userPass = user.Password.ToString();

                    string decryptPass = Encrypting.ConvertToDecrypt(userPass);

                    if (model.Password == decryptPass)
                    {
                        result = true;
                        resultMessage = "";
                    }

                }
            }

            message = resultMessage;
            return result;
        }

        public IQueryable<User> GetUsersQuery()
        {
            return _context.Users
                           .AsQueryable();
        }

        public List<DisplayUsersVM> GetUsers()
        {
            var context = GetUsersQuery();
            var users = context.OrderByDescending(u => u.RegisterDate)
                               .Select(u => new DisplayUsersVM
                               {
                                   userId = u.UserId.ToString(),
                                   UserName = u.UserName,
                                   Address = u.Address,
                                   FirstName = u.FirstName,
                                   LastName = u.LastName,
                                   IsActive = (u.IsActive ? "فعال" : "غیر فعال"),
                                   IsAdmin = (u.IsAdmin ? "فعال" : "غیر فعال"),
                                   NationalCode = u.NationalCode,
                                   PhoneNumber = u.PhoneNumber,
                                   RegisterDate = u.RegisterDate.ToShamsi(),
                               }).ToList();
            return users;
        }

        public List<DisplayUsersVM> Search(string search)
        {
            using (HousingFundContext db = new())
            {
                var context = GetUsersQuery();
                var users = context.Where(u => u.NationalCode.Contains(search) ||
                                               u.FirstName.Contains(search) ||
                                               u.LastName.Contains(search))
                                   .OrderByDescending(u => u.RegisterDate)
                                   .Select(u => new DisplayUsersVM
                                   {
                                       userId = u.UserId.ToString(),
                                       UserName = u.UserName,
                                       Address = u.Address,
                                       FirstName = u.FirstName,
                                       LastName = u.LastName,
                                       IsActive = (u.IsActive ? "فعال" : "غیر فعال"),
                                       IsAdmin = (u.IsAdmin ? "فعال" : "غیر فعال"),
                                       NationalCode = u.NationalCode,
                                       PhoneNumber = u.PhoneNumber,
                                       RegisterDate = u.RegisterDate.ToShamsi(),
                                   }).ToList();
                return users;
            }
        }

        public bool Similarity(string nationalCode, string userName, out string message)
        {
            var context = GetUsersQuery();

            bool checkUserName = context.Where(u => u.UserName == userName && u.NationalCode != nationalCode)
                                        .Any();
            if (checkUserName)
            {
                message = "کاربری با این نام کاربری قبلا ثبت شده است.";
                return checkUserName;
            }

            bool checkNationalCode = context.Where(u => u.NationalCode == nationalCode && u.UserName != userName)
                                            .Any();
            if (checkNationalCode)
            {
                message = "کاربری با این کد ملی قبلا ثبت شده است.";
                return checkNationalCode;

            }

            message = "";
            return false;
        }


        public bool Add(RegisterUserVM model, out string message)
        {
            string checkMessage = "";

            var similarity = Similarity(model.NationalCode, model.UserName, out checkMessage);

            if (similarity)
            {
                message = checkMessage;
                return false;
            }

            User user = _mapper.Map<User>(model);
            user.UserId = Guid.NewGuid();
            user.Password = Encrypting.ConvertToEncrypt(user.Password);

            _context.Users.Add(user);

            message = "";
            return true;
        }

        public bool Edit(EditUserVM model, out string message)
        {
            string checkMessage = "";

            var similarity = Similarity(model.NationalCode, model.UserName, out checkMessage);

            if (similarity)
            {
                message = checkMessage;
                return false;
            }

            User user = _mapper.Map<User>(model);

            if (model.Password != null)
            {
                user.Password = model.Password;
            }

            User db = _context.Users
                              .Find(model.UserId);

            if (db != null)
            {
                db.FirstName = user.FirstName;
                db.LastName = user.LastName;
                db.PhoneNumber = user.PhoneNumber;
                db.UserName = user.UserName;
                db.Address = user.Address;
                db.RegisterDate = user.RegisterDate;
                db.IsActive = user.IsActive;
                db.IsAdmin = user.IsAdmin;
                db.NationalCode = user.NationalCode;
                if (user.Password != null)
                {
                    db.Password = Encrypting.ConvertToEncrypt(user.Password);
                }

                _context.Users.Update(db);

                message = "";
                return true;
            }

            checkMessage = "عملیات ویرایش با شکست مواجه شد.";
            message = checkMessage;
            return false;

        }


        public bool Delete(Guid userId, out string message)
        {
            string  checkMessage = "عملیات حذف با شکست مواجه شد.";

            if (userId != Guid.Empty)
            {
                using (HousingFundContext context = new())
                {
                    var user = context.Users
                                      .Find(userId);

                    if (user != null)
                    {
                        context.Users.Remove(user);
                        context.SaveChanges();
                    }

                    message = "";

                    return true;
                }
            }
            message = checkMessage;
            return false;
        }

        public EditUserVM GetUserById(Guid userId)
        {
            var user = _context.Users.Where(u => u.UserId == userId)
                                     .Select(u => new EditUserVM
                                     {
                                         UserId = u.UserId,
                                         UserName = u.UserName,
                                         PhoneNumber = u.PhoneNumber,
                                         FirstName = u.FirstName,
                                         LastName = u.LastName,
                                         NationalCode = u.NationalCode,
                                         IsActive = u.IsActive,
                                         IsAdmin = u.IsAdmin,
                                         Address = u.Address
                                     })
                              .FirstOrDefault();
            return user;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}

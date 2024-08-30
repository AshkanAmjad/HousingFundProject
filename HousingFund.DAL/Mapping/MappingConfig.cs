using AutoMapper;
using HousingFund.DAL.Entities.Portal.Fund.Models;
using HousingFund.DAL.Entities.Security.User.Models;
using HousingFund.DAL.ViewModels.Portal.Fund;
using HousingFund.DAL.ViewModels.Portal.UserFund;
using HousingFund.DAL.ViewModels.Security.User;

namespace HousingFund.DAL.Mapping
{
    internal class MappingConfig
    {
        public IMapper CreateMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                #region User

                cfg.CreateMap<RegisterUserVM, User>()
                   .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName))
                   .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Password))
                   .ForMember(dest => dest.NationalCode, opt => opt.MapFrom(src => src.NationalCode))
                   .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                   .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                   .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                   .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address))
                   .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                   .ForMember(dest => dest.IsAdmin, opt => opt.MapFrom(src => src.IsAdmin))
                   .ForMember(dest => dest.RegisterDate, opt => opt.MapFrom(src => src.RegisterDate));

                cfg.CreateMap<EditUserVM, User>()
                   .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName))
                   .ForMember(dest => dest.NationalCode, opt => opt.MapFrom(src => src.NationalCode))
                   .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                   .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                   .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                   .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address))
                   .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                   .ForMember(dest => dest.IsAdmin, opt => opt.MapFrom(src => src.IsAdmin))
                   .ForMember(dest => dest.RegisterDate, opt => opt.MapFrom(src => src.UpdateDate));

                #endregion

                #region Fund

                cfg.CreateMap<RegisterFundVM, Fund>()
                   .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                   .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                   .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedDate))
                   .ForMember(dest => dest.Income, opt => opt.MapFrom(src => src.Income));

                cfg.CreateMap<EditFundVM, Fund>()
                   .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                   .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.UpdateDate))
                   .ForMember(dest => dest.Income, opt => opt.MapFrom(src => src.Income));

                #endregion

                #region UserFund

                cfg.CreateMap<RegisterUserFundVM, UserFund>()
                   .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                   .ForMember(dest => dest.FundId, opt => opt.MapFrom(src => src.FundId))
                   .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedDate))
                   .ForMember(dest => dest.IsWinner, opt => opt.MapFrom(src => src.IsWinner));

                #endregion
            });

            return config.CreateMapper();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFund.DAL.Utilities
{
    internal static class Encrypting
    {
        private static string _key = "adef@@kfxcbv@";

        internal static string ConvertToEncrypt(string password)
        {
            password += _key;

            var passwordBytes=Encoding.UTF8.GetBytes(password);
            
            return Convert.ToBase64String(passwordBytes);
        }

        internal static string CovertToDecrypt(string base64EncodeData)
        {
            var base64EncodeBytes = Convert.FromBase64String(base64EncodeData);

            var result = Encoding.UTF8.GetString(base64EncodeBytes);

            result = result.Substring(0,result.Length - _key.Length);

            return result;
        }

    }
}

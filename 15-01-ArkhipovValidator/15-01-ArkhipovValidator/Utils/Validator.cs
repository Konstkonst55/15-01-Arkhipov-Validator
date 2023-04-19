using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_01_ArkhipovValidator.Utils
{
    public static class Validator
    {
        public static bool ValidateMinMaxSymbols(this string text, int min, int max)
        {
            return text.Length >= min && text.Length <= max;
        }

        public static bool ValidateEmail(this string email)
        {
            try
            {
                var addres = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

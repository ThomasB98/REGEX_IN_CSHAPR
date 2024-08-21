using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REGEX
{
    internal class PhoneNumber_Validation
    {
        static bool IsValidPhoneNumber(string phone)
        {
            string pattern = @"^(+91[\-\s]?)([6-8-9])\d{9}$";
            return Regex.IsMatch(phone, pattern);
        }
        public void ValidatePhoneNumber()
        {
            Console.WriteLine("Enter Phone number");
            String phone=Console.ReadLine();

            bool isValid = IsValidPhoneNumber(phone);
            if(!isValid)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REGEX
{
    internal class Email_Validation
    {
        static bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        public void Validate()
        {
            Console.WriteLine("Enter email ");
            string email=Console.ReadLine();
            bool  isValid = IsValidEmail(email);

            if (isValid)
            {
                Console.WriteLine("Email is valid");
            }
            else
            {
                Console.WriteLine("Not an valid Email");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace REGEX
{
    internal class Password_Validation
    {
        static bool IsValidPassword(string password)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$&*\.])[A-Za-z\d@#$&*\.]{6,10}$";
            return Regex.IsMatch(password, pattern);
        }

        public void Validate()
        {
            Console.WriteLine("");
            Console.WriteLine("Enter Password");

            string password=Console.ReadLine();
            bool isValidPassword = IsValidPassword(password);

            if (isValidPassword)
            {
                Console.WriteLine("Valid");

            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}

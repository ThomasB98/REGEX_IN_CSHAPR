using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REGEX
{
    internal class Username_Validation
    {
        static bool IsValidUsername(string username)
        {
            string pattern = @"^[a-zA-Z][a-zA-Z0-9_\.]{8,14}$";
            return Regex.IsMatch(username, pattern);
        }

        public void Validate()
        {
            Console.WriteLine("");
            Console.WriteLine("Enter User Name");
            String username=Console.ReadLine();

            bool valid=IsValidUsername(username);

            if (valid)
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

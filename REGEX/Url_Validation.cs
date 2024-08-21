using System;
using System.Text.RegularExpressions;

namespace REGEX
{
    internal class Url_Validation
    {
        public static void Validate()
        {
            Console.WriteLine("");
            Console.WriteLine("Enter URL:");
            string url = Console.ReadLine();

            // The pattern to match URLs starting with "www" or "WWW" (case-insensitive)
            string pattern = @"^www\.[a-zA-Z0-9\-]+\.[a-z]{2,3}$";

            // Using RegexOptions.IgnoreCase to make the pattern case-insensitive
            bool flag = Regex.IsMatch(url, pattern, RegexOptions.IgnoreCase);

            if (flag)
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

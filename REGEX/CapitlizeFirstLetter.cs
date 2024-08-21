using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REGEX
{
    internal class CapitlizeFirstLetter
    {
        public static void Capitlize()
        {
            Console.WriteLine("");
            Console.WriteLine("Enter String");
            string input = Console.ReadLine();
            string result = Regex.Replace(input, "^[a-z]", m => m.Value.ToUpper());
            Console.WriteLine(result);
        }
    }
}

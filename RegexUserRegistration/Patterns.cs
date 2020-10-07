using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexUserRegistration
{
    class Patterns
    {
        string firstName = "^[A-Z][a-z0-9A-Z]{3,}";
        public void validateFirstName(string fname)
        {
            if (Regex.IsMatch(fname, firstName))
            {
                Console.WriteLine("First Name is valid");
            }
            else
            {
                Console.WriteLine("First Name not valid");
            }
        }
    }
}

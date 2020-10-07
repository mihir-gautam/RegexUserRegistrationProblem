using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexUserRegistration
{
    class Patterns
    {
        string Name = "^[A-Z][a-z0-9A-Z]{3,}";
        public void validateName(string name)
        {
            if (Regex.IsMatch(name, Name))
            {
                Console.WriteLine("Name is valid");
            }
            else
            {
                Console.WriteLine("Name not valid");
            }
        }
    }
}

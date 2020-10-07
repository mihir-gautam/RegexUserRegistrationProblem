using System;

namespace RegexUserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Regex User Registration Problem");
            Patterns pattern = new Patterns();
            Console.WriteLine("Enter the first name");
            string fname = Console.ReadLine();
            pattern.validateFirstName(fname);
        }
    }
}

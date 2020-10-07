using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexUserRegistration
{
    class Patterns
    {
        string Name = "^[A-Z][a-z0-9A-Z]{3,}";
        string EmailId = "^[a-z0-9A-Z]+([._+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2,})?$";
        string mobileNo = "^[0-9]{1,3}[ ][1-9]{1}[0-9]{9}$";
        string Password = "^(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9]{6,}$";


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
        public void validateEmail(string email)
        {
            if (Regex.IsMatch(email, EmailId))
            {
                Console.WriteLine("Email id is valid");
            }
            else
            {
                Console.WriteLine("Email id not valid");
            }
        }
        public void validateMobile(string mobile)
        {
            if (Regex.IsMatch(mobile, mobileNo))
            {
                Console.WriteLine("mobile number is valid");
            }
            else
            {
                Console.WriteLine("mobile number not valid");
            }
        }public void validatePassword(string pw)
        {
            if (Regex.IsMatch(pw, Password))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                Console.WriteLine("Password not valid");
            }
        }
    }
}

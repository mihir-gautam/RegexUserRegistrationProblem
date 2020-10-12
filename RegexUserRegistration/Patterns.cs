using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexUserRegistration
{
    public class Patterns
    {
        string Name = "^[A-Z][a-z0-9A-Z]{3,}";
        string EmailId = "^[a-z0-9A-Z]+([._+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2,})?$";
        string mobileNo = "^[0-9]{1,3}[ ][1-9]{1}[0-9]{9}$";
        string Password = "^((?=.*[A-Z])(?=.*[0-9])(?=^[a-zA-Z0-9]*[!@$#&*_+-]{1}[a-zA-Z0-9]).{8,})";

        public string ValidateName(string name)
        {
            if (Regex.IsMatch(name, Name))
            {
                Console.WriteLine("Name is valid");
                return "Valid";
            }
            else
            {
                Console.WriteLine("Name not valid");
                return "Invalid";
            }
        }
        public string ValidateEmail(string email)
        {
            if (Regex.IsMatch(email, EmailId))
            {
                Console.WriteLine("Email id is valid");
                return "Valid";
            }
            else
            {
                Console.WriteLine("Email id not valid");
                return "Invalid";
            }
        }
        public string ValidateMobile(string mobile)
        {
            if (Regex.IsMatch(mobile, mobileNo))
            {
                Console.WriteLine("mobile number is valid");
                return "Valid";
            }
            else
            {
                Console.WriteLine("mobile number not valid");
                return "Invalid";
            }
        }
        public string ValidatePassword(string pw)
        {
            if (Regex.IsMatch(pw, Password))
            {
                Console.WriteLine("Password is valid");
                return "Valid";
            }
            else
            {
                Console.WriteLine("Password not valid");
                return "Invalid";
            }
        }
    }
}

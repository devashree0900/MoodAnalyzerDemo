using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    public class RegexPattern
    {
        public static string FirstnamePattern = "^[A-Z][a-z]{2,}$";
        public static string LastnamePattern = "^[A-Z][a-z]{2,}$";
        public static string MobilePattern = "^[0-9]{2}\\s[0-9]{10}";
        public static string EmailPattern = "^[a-z0-9]+([-+_.][a-z]+)?[@][a-z]+[.][a-z]{2,3}([.][a-z]{2})?";
        public static string PasswordPattern = "^(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";


        public static bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, PasswordPattern);
        }
        public static bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, EmailPattern);
        }
        public static bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, FirstnamePattern);
        }

        public static bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, LastnamePattern);
        }

        public static bool ValidateMobilePattern(string mobile)
        {
            return Regex.IsMatch(mobile, MobilePattern);
        }
    }
}

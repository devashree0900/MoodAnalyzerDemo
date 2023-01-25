using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexDemo
{
    public class UserFuncWithException
    {

        private static bool ValidationCheck;
        private string FirstName;
        private string Phone;
        private string LastName;
        private string Email;
        private string Password;
        public void TakePasswordWithException()
        {
            
                do
                {
                    try
                    {
                        Console.WriteLine("Enter Password: ");
                        this.Password = Console.ReadLine();
                        ValidationCheck = RegexPattern.ValidatePassword(this.Password);
                        if (!ValidationCheck)
                        {
                            throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_PASSWORD, "YourPassword is invalid");
                        }
                        DisplayOutput("Password");
                    }
                    catch (UserRegistrationCustomException ex)
                     {
                         Console.WriteLine("Custom Exception: " + ex.Message);
                        //throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_PASSWORD, "Your Password is invalid");
                     }

            }
                while (!ValidationCheck);
            
            

        }

        public void TakeEmailWithException()
        {
            
                do
                {
                    try
                    {
                        Console.WriteLine("Enter Email: ");
                        this.Email = Console.ReadLine();
                        ValidationCheck = RegexPattern.ValidateEmail(this.Email);
                        if (!ValidationCheck)
                        {
                            throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_EMAIL, "Your Email is invalid");
                        }
                        DisplayOutput("Email");
                    }
                catch (UserRegistrationCustomException ex)
                {
                    Console.WriteLine("Custom Exception: " + ex.Message);
                    //throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_EMAIL, "Your Email is invalid");
                }

            }
                while (!ValidationCheck);
            
            
        }

        public void TakeLastNameWithException()
        {
            
                do
                {
                    try
                    {
                        Console.WriteLine("Enter Last Name: ");
                        this.LastName = Console.ReadLine();
                        ValidationCheck = RegexPattern.ValidateFirstName(this.LastName);
                        if (!ValidationCheck)
                        {
                            throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_LNAME, "Your LastName is invalid");
                        }
                        DisplayOutput("LastName");
                    }
                catch (UserRegistrationCustomException ex)
                {
                    Console.WriteLine("Custom Exception: " + ex.Message);
                    //throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_LNAME, "Your LastName is invalid");
                }

            }
                while (!ValidationCheck);
            
           
            
        }

        public void TakeFirstNameWithException()
        {
            
                do
                {
                try
                {
                    Console.WriteLine("Enter First Name: ");
                    this.FirstName = Console.ReadLine();
                    ValidationCheck = RegexPattern.ValidateFirstName(this.FirstName);
                    if (!ValidationCheck)
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_FNAME, "Your FirstName is invalid");
                    }
                    DisplayOutput("FirstName");
                }
                catch (UserRegistrationCustomException ex)
                {
                    Console.WriteLine("Custom Exception: " + ex.Message);
                    //throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_LNAME, "Your FirstName is invalid");
                }
            }
                while (!ValidationCheck);
            
            
            
        }

        public void TakePhoneWithException()
        {

            do
            {
                try
                {
                    Console.WriteLine("Enter Phone Number: ");
                    this.Phone = Console.ReadLine();
                    ValidationCheck = RegexPattern.ValidateMobilePattern(this.Phone);
                    if (!ValidationCheck)
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_PHONE, "Your Phone Number is invalid");
                    }
                    DisplayOutput("PhoneNo");
                }
                catch (UserRegistrationCustomException ex)
                {
                    Console.WriteLine("Custom Exception: " + ex.Message);
                    //throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_PHONE, "Your Phone Number is invalid");
                }


            }
            while (!ValidationCheck);
            
            
        }

        public static void DisplayOutput(string output)
        {
            if (ValidationCheck)
            {
                Console.WriteLine("\nThe entered input is valid.\n");
            }
            else
            {
                Console.WriteLine("The entered input is invalid.\nPlease try again");
                DisplayRules(output);
            }
        }

        public static void DisplayRules(string output)
        {
            switch (output)
            {
                case "FirstName":
                    Console.WriteLine("Rule: First Name starts with Capital letter and has atleast 3 letters");
                    break;
                case "LastName":
                    Console.WriteLine("Rule: First Name starts with Capital letter and has atleast 3 letters");
                    break;
                case "PhoneNo":
                    Console.WriteLine("Phone number must be in this format: Country code followed by space then 10 digit number");
                    break;
                case "Email":
                    Console.WriteLine("Email must be in the format: abc.xyz@bl.co.in");
                    break;
                case "Password":
                    Console.WriteLine("Password must contains 8 characters, atleast 1 numeric char, atleast 1 upper case letter and exactly 1 special character");
                    break;
                default:
                    break;
            }
        }
    }
}

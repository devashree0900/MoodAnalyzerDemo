using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexDemo
{
    public class UserRegistrationCustomException : Exception
    {
        public enum ExceptionType
        {
            INVALID_FNAME,
            INVALID_LNAME,
            INVALID_EMAIL,
            INVALID_PASSWORD,
            INVALID_PHONE
        }

        public readonly ExceptionType Type;

        public UserRegistrationCustomException(ExceptionType type, string message) : base(message)
        {
            this.Type = type;
        }
    }
}

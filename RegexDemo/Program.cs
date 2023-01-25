using System;
using System.Reflection.Metadata;

namespace RegexDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to regex");
            User user1 = new User();
            user1.TakeFirstName();
            user1.TakeLastName();
            user1.TakePhone();
            user1.TakeEmail();
            user1.TakePassword();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Text;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to person management");
            List<Person> list = new List<Person>();
            AddingPerson(list);
            //RetrieveTopTwo(list);
            //Display(list);
            //RetrieveTeenager(list);
            //RetrieveAveragAge(list);
            //checkName(list,"Akash");
            removeName(list, "Bala");
            skipName(list);
        }

        public static void AddingPerson(List<Person> list)
        {
            list.Add(new Person() { SSN = 1, Name = "Bala", Address = "Chennai", Age = 16 });
            list.Add(new Person() { SSN = 2, Name = "Prerit", Address = "Chennai", Age = 18 });
            list.Add(new Person() { SSN = 3, Name = "Vamsi priya", Address = "Chennai", Age = 25 });
            list.Add(new Person() { SSN = 7, Name = "Akash", Address = "Chennai", Age = 85 });
            list.Add(new Person() { SSN = 6, Name = "Devashree", Address = "Chennai", Age = 15 });
            list.Add(new Person() { SSN = 8, Name = "Baruni", Address = "Chennai", Age = 75 });
        }

        public static void Display(List<Person> list)
        {
            foreach(Person person in list)
            {
                Console.WriteLine("Name\t" + person.Name);
            }
        }

        //public void UC2(List<Program> list)
        //{
        //    int cnt = 0;
        //    foreach(Person person in list)
        //    {
        //        if (cnt >= 2) break;
        //        if(person.Age < 60)
        //        {
        //            cnt++;
        //            Console.WriteLine("Name\t" + person.Name);

        //        }
                
        //    }
        //}

        public static void RetrieveTopTwo(List<Person> list)
        {
            var result = list.FindAll(x => x.Age < 60).Take(2);
            foreach(Person person in result)
            {
                Console.WriteLine(person.Name);
            }
            
        }

        public static void RetrieveTeenager(List<Person> list)
        {
            var result = list.FindAll(x => x.Age < 18 && x.Age > 13);
            foreach (Person person in result)
            {
                Console.WriteLine(person.Name);
            }

        }

        public static void RetrieveAveragAge(List<Person> list)
        {
            var result = list.Average(x => x.Age);
            Console.WriteLine("Average age is: " + result);
        }

        public static void checkName(List<Person> list, string name)
        {
            //var result = list.Exists(e => e.Name == name);

            //var result = list.Find(x => x.Name == name);
            var result = list.Where(a => a.Name == name);
            
        }

        public static void removeName(List<Person> list, string name)
        {
            var result = list.Find(a => a.Name == name);
            if(result!=null)
            {
                list.Remove(result);
            }

        }

        public static void skipName(List<Person> list)
        {
            var result = list.FindAll(a => a.Age > 60);
            foreach (Person person in result)
            {
                Console.WriteLine(person.Name);
            }

        }
    }
}

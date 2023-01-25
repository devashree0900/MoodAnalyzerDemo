using System;

namespace FileIODemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            FileExist();
            ReadAllLines();
            WriteAllLines();
        }
        public static bool FileExist()
        {
            string path = @"C:\Users\223089248\source\repos\MoodAnalyzerDemo\FileIODEmo\SampleInput.txt";
            if(File.Exists(path))
            {
                Console.WriteLine("File Exists");
                return true;
            }
            Console.WriteLine("File Does not exist");
            return false;
        }

        public static void ReadAllLines()
        {
            string path = @"C:\Users\223089248\source\repos\MoodAnalyzerDemo\FileIODEmo\SampleInput.txt";
            if (File.Exists(path))
            {
               // string result = File.ReadAllText(path);
                string[] result =  File.ReadAllLines(path);
                foreach(string line in result)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
            
        }

        public static void WriteAllLines()
        {
            string path = @"C:\Users\223089248\source\repos\MoodAnalyzerDemo\FileIODEmo\SampleInput.txt";
            if (File.Exists(path))
            {
                
                string data = "Adding new data";
                File.WriteAllText(path, data);
            }
            else
            {
                Console.WriteLine("File does not exist");
            }

        }
    }
}

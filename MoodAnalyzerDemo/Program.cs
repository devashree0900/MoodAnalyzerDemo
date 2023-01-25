using System;



namespace MoodAnalyzerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyser");

            string message = "I am in a Sad mood";
            MoodAnalyser mood1 = new MoodAnalyser(message);
            Console.WriteLine("Given message is: " + message);
            Console.WriteLine("The returned value is: " + mood1.AnalyseMood());

            message = "I am in a Happy Mood";
            MoodAnalyser mood2 = new MoodAnalyser(message);
            Console.WriteLine("Given message is: " + message);
            Console.WriteLine("The returned value is: " + mood2.AnalyseMood());

            try
            {
                message = null;
                MoodAnalyser mood3 = new MoodAnalyser(message);
                Console.WriteLine("Given message is: " + message);
                Console.WriteLine("The returned value is: " + mood3.AnalyseMood());

            }
            catch (Exception ex)
            {
                Console.WriteLine("Custom Exception: " + ex.Message);
            }

            try
            {
                message = "";
                MoodAnalyser mood4 = new MoodAnalyser(message);
                Console.WriteLine("Given message is: " + message);
                Console.WriteLine("The returned value is: " + mood4.AnalyseMood());

            }
            catch (MoodAnalyserCustomException ex)
            {
                Console.WriteLine("Custom Exception: " + ex.Message);
            }

            //Person obj = new Person();

        }
    }

}

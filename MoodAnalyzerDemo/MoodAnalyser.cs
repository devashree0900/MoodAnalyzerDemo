using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerDemo
{
    public class MoodAnalyser
    {
        public string Message;
        public MoodAnalyser()
        { 

        }

        public MoodAnalyser(string message)
        {
            this.Message = message;
        }
        public string AnalyseMood()
        {
            try
            {
                if (this.Message == null)
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be Null");
                    //throw new Exception();
                }
                else if (this.Message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be Empty");
                    //throw new Exception();
                }

                else if (this.Message.ToLower().Contains("sad"))
                   return "SAD";
                else
                   return "HAPPY";
            }
            catch (MoodAnalyserCustomException e)
            {
                if (e.Message == "Mood should not be Null")
                    return "Mood should not be Null";
                if (e.Message == "Mood should not be Empty")
                    return "Mood should not be Empty";
                else
                    return "HAPPY";

            }
            
        }
    }
}

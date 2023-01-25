using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerDemo
{
    public class MoodAnalyserCustomException : Exception
    {
        public enum ExceptionType
        {
            EMPTY_MESSAGE,
            NULL_MESSAGE,
            NO_SUCH_CLASS,
            NO_SUCH_METHOD,
            IMPROPER_MESSAGE,
            NO_SUCH_FIELD
        }

        public readonly ExceptionType Type;

        public MoodAnalyserCustomException(ExceptionType type, string message) : base(message)
        {
            this.Type = type;
        }
        
    }
}

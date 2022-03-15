using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProject
{
    public class MoodAnalyserException : Exception
    {
        public ExceptionType type;
        //Enumeration
        public enum ExceptionType
        {
            NULL_EXCEPTION,
            EMPTY_EXCEPTION
        }
        //Exception Constructor.
        public MoodAnalyserException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}

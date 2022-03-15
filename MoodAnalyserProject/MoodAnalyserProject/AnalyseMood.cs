using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProject
{
    public class AnalyseMood
    {
        //variable
        public string message;
        //parameterized constructor
        public AnalyseMood(string message)
        {
            this.message = message;
        }
        //Method to return the type of Mood
        public string Mood()
        {
            try
            {
                if (message.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else if (message.Equals(string.Empty))
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_EXCEPTION, "Message cann't be Empty");
                }
                else
                {
                    return "sad";
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Default Exception: " + ex.Message);
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_EXCEPTION, "Message cann't be null");

            }
        }
    }
}


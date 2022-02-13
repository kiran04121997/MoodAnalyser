﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProject
{
    public class AnalyzeMood
    {
        //variable
        public string message;
        //parameterized constructor
        public AnalyzeMood(string message)
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
                else
                {
                    return "sad";
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                return "happy";
            }
        }
    }

}


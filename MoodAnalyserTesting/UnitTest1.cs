using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProject;
using System;

namespace MoodAnalyserTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("Happy Mood")]
        public void GivenMessageShouldReturnHappy()
        {
            ///Follow AAA strategy
            ///Arrange , Act and in last Assert
            AnalyseMood mood = new AnalyseMood("I am in Happy Mood");
            string excepted = "happy";
            var actual = mood.Mood();
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        [TestCategory("SAD Mood")]
        public void GivenMessageShouldReturnSad()
        {
            ///Follow AAA strategy
            ///Arrange , Act and in last Assert
            AnalyseMood mood = new AnalyseMood("I am in SAD Mood");
            string excepted = "sad";
            var actual = mood.Mood();
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        [TestCategory("Null Exception")]
        public void GivenNullShouldReturnCustomException()
        {
            ///Follow AAA strategy
            ///Arrange , Act and in last Assert
            string message = null;
            string excepted = "Message cann't be null";
            try
            {
                AnalyseMood mood = new AnalyseMood(message);
                string actual = mood.Mood();
            }
            catch (MoodAnalyserException ex)
            {
                Console.WriteLine("Custom Exception :" + ex);
                Assert.AreEqual(excepted, ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Worst Case Exception :" + ex);
            }
        }
        [TestMethod]
        [TestCategory("Empty Exception")]
        public void GivenEmptyShouldReturnCustomException()
        {
            ///Follow AAA strategy
            ///Arrange , Act and in last Assert
            string message = "";
            string excepted = "Message cann't be Empty";
            try
            {
                AnalyseMood mood = new AnalyseMood(message);
                string actual = mood.Mood();
            }
            catch (MoodAnalyserException ex)
            {
                Console.WriteLine("Custom Exception :" + ex);
                Assert.AreEqual(excepted, ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Worst Case Exception :" + ex);
            }
        }
    }
}


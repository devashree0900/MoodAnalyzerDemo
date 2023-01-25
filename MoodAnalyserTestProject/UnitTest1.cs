using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerDemo;


namespace MoodAnalyserTestProject
{
    [TestClass]
    public class UnitTest1
    {
        //test 1.1
        [TestMethod]
        public void SadMoodShouldReturnSad()
        {
            //Arrange
            string expected = "SAD";
            string message = "I am in Sad Mood";
            MoodAnalyser mood = new MoodAnalyser(message);

            //Act
            string actual = mood.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HappyMoodShouldReturnHappy()
        {
            string expected1 = "HAPPY";
            string message1 = "I am in a Happy Mood";
            MoodAnalyser mood = new MoodAnalyser(message1);

            string actual1 = mood.AnalyseMood();

            Assert.AreEqual(expected1, actual1);
        }

        [TestMethod]
        public void NullMoodShouldReturnHappy()
        {
            string expected2 = "HAPPY" ;
            string message2 = null;
            MoodAnalyser mood = new MoodAnalyser(message2);

            string actual2 = mood.AnalyseMood();

            Assert.AreEqual(expected2, actual2);
        }

        public void EmptyMoodShouldReturnHappy()
        {
            string expected3 = "HAPPY";
            string message3 = "";
            MoodAnalyser mood = new MoodAnalyser(message3);

            string actual3 = mood.AnalyseMood();

            Assert.AreEqual(expected3, actual3);
        }
    }
}
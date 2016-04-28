using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CountVowelsAndConsonants_AreEqual()
        {
            int expectedVowels = 6;
            int expectedConsonants = 3;
            string input = "How are you";
            int vowels;
            int consonants;
            

            CountVowelsAndConsonants(input, out vowels, out consonants);

            Assert.AreEqual(expectedVowels,vowels);

            Assert.AreEqual(expectedConsonants,consonants);

        }

        [TestMethod]
        public void CountVowelsAndConsonants_AreNotEqual()
        {
            int expectedVowels = 6;
            int expectedConsonants = 3;
            string input = "How are you doing";
            int vowels;
            int consonants;


            CountVowelsAndConsonants(input, out vowels, out consonants);

            Assert.AreNotEqual(expectedVowels, vowels);

            Assert.AreNotEqual(expectedConsonants, consonants);

        }

        [TestMethod]
        public void StringReplacement_AreEqual()
        {

            string input = "God dag Niklas";

            string replacementWord = "kväll";

            string expectedSentence = "God kväll Niklas";

            string resultSentence = StringReplacement(input, replacementWord);

            Assert.AreEqual(expectedSentence,resultSentence);

        }

        [TestMethod]
        public void StringReplacement_AreNotEqual()
        {

            string input = "God dag Niklas";

            string replacementWord = "morgon";

            string expectedSentence = "God kväll Niklas";

            string resultSentence = StringReplacement(input, replacementWord);


            Assert.AreNotEqual(expectedSentence, resultSentence);


        }


    }
}

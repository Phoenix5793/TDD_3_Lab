using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_3_Lab;

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


            StringUtils.CountVowelsAndConsonants(input, out vowels, out consonants);

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


            StringUtils.CountVowelsAndConsonants(input, out vowels, out consonants);

            Assert.AreNotEqual(expectedVowels, vowels);

            Assert.AreNotEqual(expectedConsonants, consonants);

        }

        [TestMethod]
        public void StringReplacement_AreEqual()
        {

            string input = "God dag Niklas vad är dagens datum";

            string replacementWord = "kväll";

            string wordToExchange = "dag";

            string expectedSentence = "God kväll Niklas vad är dagens datum";

            string resultSentence = StringUtils.StringReplacement(input, replacementWord, wordToExchange);

            Assert.AreEqual(expectedSentence, resultSentence);

        }

        [TestMethod]
        public void StringReplacement_AreNotEqual()
        {

            string input = "God dag Niklas";

            string replacementWord = "morgon";

            string wordToExchange = "dag";

            string expectedSentence = "God kväll Niklas";

            string resultSentence = StringUtils.StringReplacement(input, replacementWord,wordToExchange);


            Assert.AreNotEqual(expectedSentence, resultSentence);


        }


    }
}

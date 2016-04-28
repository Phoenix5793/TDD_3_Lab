﻿using System;
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
            int vowels = 6;
            int consonants = 3;


            

            Assert.AreEqual(expectedVowels,vowels);

            Assert.AreEqual(expectedConsonants,consonants);

        }

        [TestMethod]
        public void CountVowelsAndConsonants_AreNotEqual()
        {
            int expectedVowels = 6;
            int expectedConsonants = 3;
            string input = "How are you doing";
            int vowels = 8;
            int consonants=6;


           

            Assert.AreNotEqual(expectedVowels, vowels);

            Assert.AreNotEqual(expectedConsonants, consonants);

        }

        [TestMethod]
        public void StringReplacement_AreEqual()
        {

            string input = "God dag Niklas";

            string replacementWord = "kväll";

            string expectedSentence = "God kväll Niklas";

            string resultSentence = "God kväll Niklas";

            Assert.AreEqual(expectedSentence, resultSentence);

        }

        [TestMethod]
        public void StringReplacement_AreNotEqual()
        {

            string input = "God dag Niklas";

            string replacementWord = "morgon";

            string expectedSentence = "God kväll Niklas";

            string resultSentence = "God morgon Niklas";


            Assert.AreNotEqual(expectedSentence, resultSentence);


        }


    }
}

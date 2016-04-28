using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_3_Lab
{
   public static class StringUtils
    {

        public static void CountVowelsAndConsonants(string input, out int vowelCount, out int consonantCount)
        {
            vowelCount = 0;
            consonantCount = 0;
            input = input.ToLower();
            input = input.Replace(" ", String.Empty);

            var vowels = new HashSet<Char> {'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö'};


            for (int i = 0; i < input.Length; i++)
            {
                if (vowels.Contains(input[i]))
                {
                    vowelCount++;
                }
            }
            consonantCount = input.Length - vowelCount;

        }


       public static string StringReplacement(string input, string replacementWord, string wordToExchange)
       {
           string[] wordList = input.Split(' ');

           
           for (int i = 0; i < wordList.Length; i++)
           {
               if (wordList[i] == wordToExchange)
               {
                    wordList[i] = wordList[i].Replace(wordToExchange, replacementWord);
               }
              
           }

           string output = string.Join(" ", wordList);

           return output;
       }




    }
}

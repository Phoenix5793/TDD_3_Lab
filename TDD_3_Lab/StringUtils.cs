using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_3_Lab
{
    class StringUtils
    {

        public static void CountVowelsAndConsonants(string input, out int vowelCount, out int consonantCount)
        {
            vowelCount = 0;
            consonantCount = 0;
            input = input.ToLower();

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




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MakingAnagrams.TDD
{
    class MakingAnagrams
    {
        internal object CheckAnagram(string input1, string input2)
        {
            string string1 = String.Concat(input1.OrderBy(c => c));
            string string2 = String.Concat(input2.OrderBy(c => c));
            
            if (string1 == string2)
            {
                return 0;
            } else
            {
                int[] letterCount = new int[26];
                for (int i = 0; i < letterCount.Length; i++)
                {
                    letterCount[i] = -1;
                }

                Debug.WriteLine("tst");

                var bothString = string1 + string2;
                int deletedCount = 0;

                char[] bothStringArray = bothString.ToArray();

                foreach(char letter in bothStringArray)
                {
                    var matchingLetters = Array.FindAll(bothStringArray, x => x == letter).Length;
                    var hash = (int)letter - 97;
                    if (letterCount[hash] != -1)
                    {
                        letterCount[hash] = matchingLetters;
                        if (matchingLetters % 2 != 0)
                            Debug.WriteLine("tst");
                            deletedCount++;
                    }
                }

                return deletedCount;
                
                //var string1Count = string1.Length;
                //var string2Count = string2.Length;

                //var extraLetters = string1Count - string2Count;
                //return extraLetters;
            }
        }
    }
}

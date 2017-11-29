using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace LightningFastWordFinder
{
    class LightningWordFinder
    {
        public string GetLongestWord(string text)
        {
            string[] textToArray = text.Split(' ');
            string longestWord = "";
            for (int i = 0; i < textToArray.Length; i++)
            {
                if (Regex.IsMatch(textToArray[i], @"^[A-Za-z]+$"))
                {
                    if (longestWord.Length < textToArray[i].Length)
                    {
                        longestWord = textToArray[i];
                    }
                }
            }    
            return longestWord;
        }
    }
}

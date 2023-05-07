using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilterAssignment.Services
{
    public class VowelInMiddleFilter:IFilter
    {
        private readonly char[] vowels = { 'a', 'e','i','o','u' };

        public VowelInMiddleFilter()
        {

        }
        /// <summary>
        /// filters the input to find if the middle of the input contains vowel
        /// </summary>
        /// <param name="word">input text is a word</param>
        /// <returns>word contains vowel or not </returns>
        /// <exception cref="ArgumentNullException">throws exception if input text is null</exception>
        /// <exception cref="ArgumentOutOfRangeException">throws exception if input text is empty or white space</exception>
        public string Filter(string word)
        {
            if (word == null)
            {
                throw new ArgumentNullException("input");
            }
            if (string.IsNullOrWhiteSpace(word))
            {
                throw new ArgumentOutOfRangeException("must be non empty");
            }

            char[] middlechars = GetMiddleOfInputText(word);
           var containsVowels= vowels.Intersect(middlechars)?.ToArray();
            if(containsVowels!=null && containsVowels.Length>0)
            {
                return $"{word} has vowel in the middle";
            }
            else
            {
                return $"{word} does not have vowel in the middle";
            }
         
        }

        private char[]  GetMiddleOfInputText(string word)
        {
            char[] middleChars = new char[2];

            int halfOfString = word.Length / 2;

            if(word.Length%2==0)
            {
                middleChars = word.Substring(halfOfString - 1, 2).ToCharArray();
            }
            else
            {
                middleChars[0] = word.ElementAt(halfOfString);
                
            }
            return middleChars;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilterAssignment.Services
{
    public class WordContainingSpecifiedCharFilter:IFilter
    {
        public WordContainingSpecifiedCharFilter()
        {

        }

        /// <summary>
        /// filters the input to find if the input word contains character t
        /// </summary>
        /// <param name="word">input text is a word</param>
        /// <returns>word contains vowel or not </returns>
        /// <exception cref="ArgumentNullException">throws exception if input text is null</exception>
        /// <exception cref="ArgumentOutOfRangeException">throws exception if input text is empty or white space</exception>
        public string Filter(string word)
        {
            if(word == null)
            {
                throw new ArgumentNullException("input");
            }
            if (string.IsNullOrWhiteSpace(word))
            {
                throw new ArgumentOutOfRangeException();    
            }

            if (word.ToLower().Contains('t'))
            {
                return $"{word} contain char t";
            }
            else
            {
                return $"{word} does not contain char t"; 
            }

        }
    }
}

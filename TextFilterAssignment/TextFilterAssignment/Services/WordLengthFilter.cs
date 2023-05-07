using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilterAssignment.Services
{
    public class WordLengthFilter:IFilter
    {
        public WordLengthFilter()
        {

        }
        /// <summary>
        /// filters the input to find if the word has length 3 
        /// </summary>
        /// <param name="word">input text is a word</param>
        /// <returns>result stating the input word has length 3</returns>
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
                throw new ArgumentOutOfRangeException();
            }

            if (word.Length==3)
            {
                return  $"{word} has length 3"; ;
            }
            else
            {
                return $"{word} does not have length 3";
            }

        }
    }
}

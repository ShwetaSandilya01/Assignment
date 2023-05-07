using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFilterAssignment.Services;

namespace TextFilterAssignment
{
    public class TextFilterProcessor: ITextFilterProcessor
    {
       
        private readonly List<IFilter> _filters;
        public TextFilterProcessor(List<IFilter> filters)
        {
           _filters = filters;
        }
        /// <summary>
        /// This is the word processor which takes input word and applies all the filters implemented by filter interface
        /// </summary>
        /// <param name="word">input word</param>
        public void ProcessText(string word)
        {
            foreach (var item in _filters)
            {
               Console.WriteLine(item.Filter(word));
            }
        }
    }
}

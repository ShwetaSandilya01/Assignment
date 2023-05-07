using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilterAssignment
{
    public interface ITextFilterProcessor
    {
        void ProcessText(string inputText);
    }
}

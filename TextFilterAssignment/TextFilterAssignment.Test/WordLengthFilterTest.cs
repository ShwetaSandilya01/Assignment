using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFilterAssignment.Services;

namespace TextFilterAssignment.Test
{
    public class WordLengthFilterTest
    {

        [Fact]
        public void Filter_throws_null_argument_exception_if_null()
        {
            var classUnderTest = new WordLengthFilter();
            Assert.Throws<ArgumentNullException>(() => classUnderTest.Filter(null));

        }
        [Fact]
        public void Filter_throws_argument_out_of_range_exception_if_empty()
        {
            var classUnderTest = new WordLengthFilter();
            Assert.Throws<ArgumentOutOfRangeException>(() => classUnderTest.Filter(" "));
        }

        [Fact]
        public void Returns_equal_when_input_has_length_three()
        {
            var classUnderTest = new WordLengthFilter();
            Assert.Equal("abc has length 3", classUnderTest.Filter("abc"));  
        }
        [Fact]
        public void Returns_not_equal_when_input_has_length_not_equal_to_three()
        {
            var classUnderTest = new WordLengthFilter();
            Assert.Equal("abcd does not have length 3", classUnderTest.Filter("abcd"));
        }

    }
}

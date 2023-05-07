using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFilterAssignment.Services;

namespace TextFilterAssignment.Test
{
    public class WordContainingSpecifiedCharFilterTest
    {


        [Fact]
        public void Filter_throws_null_argument_exception_if_null()
        {
            var classUnderTest = new WordContainingSpecifiedCharFilter();
            Assert.Throws<ArgumentNullException>(() => classUnderTest.Filter(null));

        }
        [Fact]
        public void Filter_throws_argument_out_of_range_exception_if_empty()
        {
            var classUnderTest = new WordContainingSpecifiedCharFilter();
            Assert.Throws<ArgumentOutOfRangeException>(() => classUnderTest.Filter(" "));
        }

        [Fact]
        public void Returns_equal_if_word_contains_character_t()
        {
            var classUnderTest = new WordContainingSpecifiedCharFilter();
            Assert.Equal("TEST contain char t", classUnderTest.Filter("TEST"));
           
        }

        [Fact]
        public void Returns_not_equal_if_word_does_not_contains_character_t()
        {
            var classUnderTest = new WordContainingSpecifiedCharFilter();
            Assert.Equal("POP does not contain char t", classUnderTest.Filter("POP"));

        }
    }
}

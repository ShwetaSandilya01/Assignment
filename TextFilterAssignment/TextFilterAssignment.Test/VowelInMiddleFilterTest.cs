using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFilterAssignment.Services;

namespace TextFilterAssignment.Test
{
    public class VowelInMiddleFilterTest
    {
        [Fact]
        public void Filter_throws_null_argument_exception_if_null()
        {
            var classUnderTest = new VowelInMiddleFilter();
            Assert.Throws<ArgumentNullException>(() => classUnderTest.Filter(null));
           
        }
        [Fact]
        public void Filter_throws_argument_out_of_range_exception_if_empty()
        {
            var classUnderTest = new VowelInMiddleFilter();
            Assert.Throws<ArgumentOutOfRangeException>(() => classUnderTest.Filter(" "));
        }

        [Fact]
        public void Returns_correct_result_if_word_length_less_than_three()
        {
            var classUnderTest = new VowelInMiddleFilter();
            Assert.Equal("a has vowel in the middle", classUnderTest.Filter("a"));
            Assert.Equal("b does not have vowel in the middle", classUnderTest.Filter("b"));
            Assert.Equal("ab has vowel in the middle", classUnderTest.Filter("ab"));
            Assert.Equal("fd does not have vowel in the middle", classUnderTest.Filter("fd"));
        }

        [Fact]
        public void Returns_equal_if_word_contains_vowel_in_middle_of_inputword_of_odd_number_length()
        {
            var classUnderTest = new VowelInMiddleFilter();

            Assert.Equal("currently has vowel in the middle", classUnderTest.Filter("currently"));
            Assert.Equal("clean has vowel in the middle", classUnderTest.Filter("clean"));
        }

        [Fact]
        public void Returns_no_equal_if_word_contains_no_vowel_in_middle_of_inputword_of_odd_number_length()
        {
            var sut = new VowelInMiddleFilter();

            Assert.Equal("filters does not have vowel in the middle", sut.Filter("filters"));
            Assert.Equal("formal does not have vowel in the middle", sut.Filter("formal"));
        }

        [Fact]
        public void Returns_equal_if_word_does_contain_a_vowel_in_middle_for_even_numbered_input()
        {
            var classUnderTest = new VowelInMiddleFilter();

            Assert.Equal("trying has vowel in the middle", classUnderTest.Filter("trying"));
            Assert.Equal("approaches has vowel in the middle", classUnderTest.Filter("approaches"));
            
        }

        [Fact]
        public void Returns_not_equal_if_word_does_contain_a_vowel_in_middle_for_even_numbered_input()
        {
            var classUnderTest = new VowelInMiddleFilter();

            Assert.Equal("extensions does not have vowel in the middle", classUnderTest.Filter("extensions"));
            Assert.Equal("config does not have vowel in the middle", classUnderTest.Filter("config"));

        }
    }
}

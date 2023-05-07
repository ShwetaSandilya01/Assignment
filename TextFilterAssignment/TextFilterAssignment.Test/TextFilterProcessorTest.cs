using Moq;
using TextFilterAssignment.Services;
namespace TextFilterAssignment.Test
{
    public class TextFilterProcessorTest
    {
        [Fact]
        public void Filter_throws_argument_out_of_range_exception_if_empty()
        {
            var mockFilterList = new List<Mock<IFilter>>();
            var characterFilterMock = new Mock<IFilter>();
            characterFilterMock.Setup(x => x.Filter("aot")).Returns("aot does not contain char t");
            var vowelFilterMock = new Mock<IFilter>();
            vowelFilterMock.Setup(x => x.Filter("aot")).Returns("aot has vowel in the middle");
            var characterLengthFilterMock = new Mock<IFilter>();
            characterLengthFilterMock.Setup(x => x.Filter("aot")).Returns("aot has length 3");

            mockFilterList.Add(characterFilterMock);
            mockFilterList.Add(vowelFilterMock);
            mockFilterList.Add(characterLengthFilterMock);

            string testInput = "aot";
            var textFilterProcessor = new TextFilterProcessor(mockFilterList.Select(x=>x.Object).ToList());
            textFilterProcessor.ProcessText(testInput);

            characterFilterMock.Verify(x => x.Filter(It.IsAny<string>()), Times.Exactly(1));
            vowelFilterMock.Verify(x => x.Filter(It.IsAny<string>()), Times.Exactly(1));
            characterLengthFilterMock.Verify(x => x.Filter(It.IsAny<string>()), Times.Exactly(1));
        }
    }
}

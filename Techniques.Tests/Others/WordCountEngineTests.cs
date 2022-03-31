using Xunit;

namespace MyTechniques.Tests.Others
{
    public class WordCountEngineTests
    {
        [Fact]
        public void GetWordCountEngine_Case1()
        {
            // arrange
            var instance = new WordCountEngine();
            var document = "Practice makes perfect, you'll get perfecT by practice. just practice! just just just!!";

            // act
            var result = instance.GetWordCountEngine(document);

            // assert
            var expected = new string[,] {
                { "just", "4"}, { "practice", "3"}, { "perfect", "2"},
                { "makes", "1"}, { "youll", "1"},{"get", "1"},{"by", "1"}
            };
            Assert.Equal(expected, result);
        }
    }
}
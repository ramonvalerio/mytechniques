using Xunit;

namespace MyTechniques.Tests.Blind75.Medium
{
    public  class PalindromicSubstringsTests
    {
        [Fact]
        public void CountSubstrings_Case1()
        {
            // arrange
            var instance = new PalindromicSubstrings();
            var s = "abc";

            // act
            var result = instance.CountSubstrings(s);

            // assert
            var expected = 3;
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CountSubstrings_Case2()
        {
            // arrange
            var instance = new PalindromicSubstrings();
            var s = "aaa";

            // act
            var result = instance.CountSubstrings(s);

            // assert
            var expected = 6;
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CountSubstrings_Case3()
        {
            // arrange
            var instance = new PalindromicSubstrings();
            var s = "Socorram-me subi no ônibus em Marrocos";

            // act
            var result = instance.CountSubstrings(s);

            // assert
            var expected = 43;
            Assert.Equal(expected, result);
        }
    }
}

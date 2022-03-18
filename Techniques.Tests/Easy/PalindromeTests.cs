using Xunit;

namespace Techniques.Tests.Easy
{
    public class PalindromeTests
    {
        [Fact]
        public void IsPalindromeNumber_Valid()
        {
            // arrange
            var instance = new Palindrome();
            var num = 101;

            // act
            var result = instance.IsPalindromeNumber(num);

            // assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindromeNumber_Valid_SingleNumber()
        {
            // arrange
            var instance = new Palindrome();
            var num = 0;

            // act
            var result = instance.IsPalindromeNumber(num);

            // assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindromeNumber_Valid_ComplexNumber()
        {
            // arrange
            var instance = new Palindrome();
            var num = 9981899;

            // act
            var result = instance.IsPalindromeNumber(num);

            // assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindromeNumber_Invalid_NegativeNumber()
        {
            // arrange
            var instance = new Palindrome();
            var num = -9981899;

            // act
            var result = instance.IsPalindromeNumber(num);

            // assert
            Assert.False(result);
        }

        [Fact]
        public void IsPalindromeNumber_Invalid()
        {
            // arrange
            var instance = new Palindrome();
            var num = 103;

            // act
            var result = instance.IsPalindromeNumber(num);

            // assert
            Assert.False(result);
        }

        [Fact]
        public void IsPalindromeString_Valid()
        {
            // arrange
            var instance = new Palindrome();
            var s = "Socorram-me subi no ônibus em Marrocos";

            // act
            var result = instance.IsPalindromeString(s);

            // assert
            Assert.True(result);
        }
    }
}

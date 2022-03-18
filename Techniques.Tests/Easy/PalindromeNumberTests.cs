using Xunit;

namespace Techniques.Tests.Easy
{
    public class PalindromeNumberTests
    {
        [Fact]
        public void IsPalindrome_Valid()
        {
            // arrange
            var instance = new PalindromeNumber();
            var num = 101;

            // act
            var result = instance.IsPalindrome(num);

            // assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_Valid_SingleNumber()
        {
            // arrange
            var instance = new PalindromeNumber();
            var num = 0;

            // act
            var result = instance.IsPalindrome(num);

            // assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_Valid_ComplexNumber()
        {
            // arrange
            var instance = new PalindromeNumber();
            var num = 9981899;

            // act
            var result = instance.IsPalindrome(num);

            // assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_Invalid_NegativeNumber()
        {
            // arrange
            var instance = new PalindromeNumber();
            var num = -9981899;

            // act
            var result = instance.IsPalindrome(num);

            // assert
            Assert.False(result);
        }

        [Fact]
        public void IsPalindrome_Invalid()
        {
            // arrange
            var instance = new PalindromeNumber();
            var num = 103;

            // act
            var result = instance.IsPalindrome(num);

            // assert
            Assert.False(result);
        }
    }
}

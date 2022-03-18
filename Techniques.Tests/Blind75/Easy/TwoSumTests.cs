using Techniques.Tests.Blind75.Easy;
using Xunit;

namespace MyTechniques.Tests.Blind75.Easy
{
    public class TwoSumTests
    {
        [Fact]
        public void TwoSum()
        {
            // arrange
            var instance = new TwoSum();
            var arr = new[] { 1, 2, 3 };

            // act
            var result = instance.GetIndexesOfTwoSum(arr, 4);

            // assert
            var expected = new[] { 2, 0 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TwoSum_ComplexArray()
        {
            // arrange
            var instance = new TwoSum();
            var arr = new[] { 9, 2, 7, 8, 1, 3, 4 };

            // act
            var result = instance.GetIndexesOfTwoSum(arr, 4);

            // assert
            var expected = new[] { 5, 4 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TwoSum_Zero()
        {
            // arrange
            var instance = new TwoSum();
            var arr = new[] { 9, 2, 7, 8, 1, 3, 4 };

            // act
            var result = instance.GetIndexesOfTwoSum(arr, 0);

            // assert
            var expected = new[] { 0, 1 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TwoSum_EmptyArray()
        {
            // arrange
            var instance = new TwoSum();
            var arr = new int[9999];

            // act
            var result = instance.GetIndexesOfTwoSum(arr, 7);

            // assert
            var expected = new[] { 0, 1 };
            Assert.Equal(expected, result);
        }
    }
}
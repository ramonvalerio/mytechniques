using Xunit;

namespace MyTechniques.Tests.Blind75.Medium
{
    public class MaximumProductSubarrayTests
    {
        [Fact]
        public void GetMaxProduct_Case1()
        {
            // arrange
            var instance = new MaximumProductSubarray();
            var nums = new int[]{ 2, 3, -2, 4 };

            // act
            var result = instance.GetMaxProduct(nums);

            // assert
            var expected = 6;
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetMaxProduct_Case2()
        {
            // arrange
            var instance = new MaximumProductSubarray();
            var nums = new int[] { -2, 0, -1 };

            // act
            var result = instance.GetMaxProduct(nums);

            // assert
            var expected = 0;
            Assert.Equal(expected, result);
        }
    }
}
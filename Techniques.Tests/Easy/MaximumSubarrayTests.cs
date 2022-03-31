using Xunit;

namespace MyTechniques.Tests.Easy
{
    public class MaximumSubarrayTests
    {
        [Fact]
        public void GetMaximumSubarray()
        {
            // arrange
            var instance = new MaximumSubarray();
            var arr = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

            // act
            var result = instance.GetMaxSubArray(arr);

            // assert

        }
    }
}
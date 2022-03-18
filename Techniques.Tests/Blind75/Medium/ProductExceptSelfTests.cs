using Xunit;

namespace MyTechniques.Tests.Blind75.Medium
{
    public class ProductExceptSelfTests
    {
        [Fact]
        public void GetProductExceptSelf()
        {
            // arrange
            var instance = new ProductExceptSelf();
            var arr = new int[] { 4, 5, 1, 8, 2, 10, 6 };

            // act
            var result = instance.GetProductExceptSelf(arr);

            // assert
            var expected = new int[] { 4800, 3840, 19200, 2400, 9600, 1920, 3200 };
            Assert.Equal(expected, result);
        }
    }
}

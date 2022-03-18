using Techniques.Tests.Array;
using Xunit;

namespace Techniques.Tests
{
    public class ShiftArrayTests
    {
        [Fact]
        public void ShiftArrayToRight_ValidPosition()
        {
            // arrange
            var instance = new ShiftArray();
            var num = 9;
            var arr = new int[] { 1, 2, 3, 0 };
            var arr2 = new int[] { 1, 2, 3, 0 };
            var arr3 = new int[] { 1, 2, 3, 0 };
            var arr4 = new int[] { 1, 2, 3, 0 };

            // act
            instance.ShiftToRight(num, 0, arr);
            Assert.Equal(new int[] { num, 1, 2, 3 }, arr);

            instance.ShiftToRight(num, 1, arr2);
            Assert.Equal(new int[] { 1, num, 2, 3}, arr2);

            instance.ShiftToRight(num, 2, arr3);
            Assert.Equal(new int[] { 1, 2, num, 3}, arr3);

            instance.ShiftToRight(num, 3, arr4);
            Assert.Equal(new int[] { 1, 2, 3, num}, arr4);
        }

        [Fact]
        public void ShiftArrayToRight_InvalidPosition()
        {
            // arrange
            var instance = new ShiftArray();
            var num = 9;
            var arr = new int[] { 1, 2, 3, 0 };

            // act
            instance.ShiftToRight(num, -1, arr);
            Assert.Equal(new int[] { 1, 2, 3, 0 }, arr);

            instance.ShiftToRight(num, 10, arr);
            Assert.Equal(new int[] { 1, 2, 3, 0 }, arr);
        }

        [Fact]
        public void ShiftArrayToLeft()
        {
            // arrange
            var instance = new ShiftArray();
            var num = 9;
            var arr = new int[] { 0, 1, 2, 3 };

            // act
            instance.ShiftToLeft(num, 2, arr);

            // assert
            Assert.Equal(new int[] { 1, 2, num, 3 }, arr);
        }

        [Fact]
        public void ShiftArrayToAnyWhere()
        {
            // arrange
            var instance = new ShiftArray();
            var num = 9;
            var arr = new int[] { 1, 2, 3, 0 };

            // act
            instance.Shift(num, 0, arr);
            Assert.Equal(new int[] { num, 1, 2, 3 }, arr);
        }
    }
}
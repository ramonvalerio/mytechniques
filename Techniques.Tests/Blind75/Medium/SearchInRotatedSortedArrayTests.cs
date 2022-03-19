using Xunit;

namespace MyTechniques.Tests.Blind75.Medium
{
    public class SearchInRotatedSortedArrayTests
    {
        [Fact]
        public void Search_Case1()
        {
            // arrange
            var instance = new SearchInRotatedSortedArray();
            var nums = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            var target = 0;

            // act
            var result = instance.Search(nums, target);

            // assert
            var expected = 4;
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Search_Case2()
        {
            // arrange
            var instance = new SearchInRotatedSortedArray();
            var nums = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            var target = 3;

            // act
            var result = instance.Search(nums, target);

            // assert
            var expected = -1;
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Search_Case3()
        {
            // arrange
            var instance = new SearchInRotatedSortedArray();
            var nums = new int[] { 1 };
            var target = 0;

            // act
            var result = instance.Search(nums, target);

            // assert
            var expected = -1;
            Assert.Equal(expected, result);
        }
    }
}
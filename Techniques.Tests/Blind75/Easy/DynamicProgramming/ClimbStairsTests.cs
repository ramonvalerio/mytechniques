using Xunit;

namespace MyTechniques.Tests.Blind75.Easy.DynamicProgramming
{
    public class ClimbStairsTests
    {
        [Fact]
        public void GetCountClimbStairs_Case1()
        {
            // arrange
            var instance = new ClimbStairs();
            var n = 2;

            // act
            var result = instance.GetCountClimbStairs(n);

            // assert
            var expected = 2;
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetCountClimbStairs_Case2()
        {
            // arrange
            var instance = new ClimbStairs();
            var n = 3;

            // act
            var result = instance.GetCountClimbStairs(n);

            // assert
            var expected = 3;
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetCountClimbStairs_Case3()
        {
            // arrange
            var instance = new ClimbStairs();
            var n = 15;

            // act
            var result = instance.GetCountClimbStairs(n);

            // assert
            var expected = 987;
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetCountClimbStairs_Case4()
        {
            // arrange
            var instance = new ClimbStairs();
            var n = 45;

            // act
            var result = instance.GetCountClimbStairsUsingMemoization(n);

            // assert
            var expected = 1836311903;
            Assert.Equal(expected, result);
        }
    }
}
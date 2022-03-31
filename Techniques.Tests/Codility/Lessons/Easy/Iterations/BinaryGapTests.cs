using MyTechniques.Tests.Codility.Easy.Iterations.Lessons;
using Xunit;

namespace MyTechniques.Tests.Codility.Lessons.Easy.Iterations
{
    public class BinaryGapTests
    {
        [Fact]
        public void BruteForceSolution()
        {
            // arrange
            var obj = new BinaryGap();

            // act
            var result = obj.BruteForceSolution(529);

            // assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void StackSolution()
        {
            // arrange
            var obj = new BinaryGap();

            // act
            var result = obj.StackSolution(529);

            // assert
            Assert.Equal(4, result);
        }
    }
}

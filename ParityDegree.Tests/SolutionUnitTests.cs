using ParityDegree;

namespace SolutionTests
{
    public class SolutionUnitTests
    {
        [Theory]
        [InlineData(1, 0)]
        [InlineData(24, 3)]
        [InlineData(1000000000, 9)]
        public void Given_N_When_SolutionIsCalled_Then_ReturnExpectedValue(int n, int expected)
        {
            var solution = new Solution();
            int result = solution.solution(n);
            Assert.Equal(expected, result);
        }
    }
}

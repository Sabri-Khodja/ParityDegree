using ParityDegree;

namespace SolutionTests
{
    public class SolutionUnitTests
    {
        [Fact]
        public void Given_NIs1_When_SolutionIsCalled_Then_Return0()
        {
            var solution = new Solution();
            int N = 1;
            
            int result = solution.solution(N);
            
            Assert.Equal(0, result);
        }
    }
}

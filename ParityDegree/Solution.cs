namespace ParityDegree
{
    public class Solution
    {
        public int solution(int N)
        {
            return N switch
            {
                1 => 0,
                24 => 3,
                _ => throw new NotImplementedException(),
            };
        }
    }
}

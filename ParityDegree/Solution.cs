namespace ParityDegree
{
    public class Solution
    {
        private static readonly List<int> PowersOfTwo = new List<int>()
        {
            1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192, 16384, 32768, 65536, 131072, 262144, 524288, 1048576, 2097152, 4194304, 8388608, 16777216, 33554432, 67108864, 134217728, 268435456, 536870912 
        };

        public int solution(int N)
        {
            if (N < 1 || N > 1000000000)
            {
                throw new ArgumentOutOfRangeException(nameof(N), "N must be between 1 and 1,000,000,000.");
            }

            if(N % 2 == 1) // If N is odd, the parity degree is 0
            {
                return 0;
            }

            var powerIndex = FindHighestPowerOfTwoSmallerThan(N, 0, PowersOfTwo.Count - 1);

            while (powerIndex >= 0)
            {
                if (N % PowersOfTwo[powerIndex] == 0)
                {
                    return powerIndex;
                }
                powerIndex--;
            }

            return -1;
        }

        private int FindHighestPowerOfTwoSmallerThan(int n, int start, int end)
        {
            if (start == end)
            {
                return start; //PowersOfTwo[start]; // Return the found power of two
            }

            if (start + 1 == end)
            {
                if (PowersOfTwo[end] <= n) return end; //PowersOfTwo[end];
                return start; //PowersOfTwo[start];
            }

            var powerOfTwo = PowersOfTwo[(start + end) / 2];
            if (powerOfTwo == n) return n; //powerOfTwo;

            if (powerOfTwo > n)
            {
                return FindHighestPowerOfTwoSmallerThan(n, start, (start + end) / 2 - 1);
            }
            else
            {
                return FindHighestPowerOfTwoSmallerThan(n, (start + end) / 2 + 1, end);
            }
        }


    }
}

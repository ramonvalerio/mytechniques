namespace MyTechniques.Tests.Blind75.Easy.DynamicProgramming
{
    /// <summary>
    /// You are climbing a staircase. It takes n steps to reach the top.
    /// Each time you can either climb 1 or 2 steps.In how many distinct ways can you climb to the top?
    /// </summary>
    public class ClimbStairs
    {
        /// <summary>
        /// Approach: Brute Force
        /// Time complexity : O(2n). Size of recursion tree will be 2n.
        /// Space complexity : O(n)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int GetCountClimbStairs(int n)
        {
            return Climbing(0, n);
        }

        private int Climbing(int i, int n)
        {
            if (i > n)
                return 0;

            if (i == n)
                return 1;

            var result = Climbing(i + 1, n) + Climbing(i + 2, n);
            return result;
        }

        public int GetCountClimbStairsUsingMemoization(int n)
        {
            var memo = new int[n + 1];
            return climbingWithMemoization(0, n, memo);
        }

        private int climbingWithMemoization(int i, int n, int[] memo)
        {

            if (i > n)
                return 0;

            if (i == n)
                return 1;

            if (memo[i] > 0)
                return memo[i];

            memo[i] = climbingWithMemoization(i + 1, n, memo) + climbingWithMemoization(i + 2, n, memo);
            return memo[i];
        }
    }
}
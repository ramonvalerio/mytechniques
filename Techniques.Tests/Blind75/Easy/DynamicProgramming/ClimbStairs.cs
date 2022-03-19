namespace MyTechniques.Tests.Blind75.Easy.DynamicProgramming
{
    public class ClimbStairs
    {
        /// <summary>
        /// You are climbing a staircase. It takes n steps to reach the top.
        //Each time you can either climb 1 or 2 steps.In how many distinct ways can you climb to the top?
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
    }
}
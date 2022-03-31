using System;
using System.Collections.Generic;

namespace MyTechniques.Tests.Codility.Easy.Iterations
{
    public class BinaryGap
    {
        /// <summary>
        /// Approach: Brute-Force
        /// Time: N*N
        /// Space: 1
        /// </summary>
        /// <param name="N"></param>
        /// <returns>Longest Gap</returns>
        public int BruteForceSolution(int N)
        {
            var input = Convert.ToString(N, 2);
            var longestGap = 0;

            for (int i = 0; i < input.Length; i++)
            {
                var count = 0;

                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[j] == '1')
                    {
                        longestGap = Math.Max(longestGap, count);
                        i = j;
                        break;
                    }
                    else
                        count++;
                }
            }

            return longestGap;
        }

        /// <summary>
        /// Approach: Stack
        /// Time: N
        /// Space: N
        /// </summary>
        /// <param name="N"></param>
        /// <returns>Longest Gap</returns>
        public int StackSolution(int N)
        {
            // Problem: Binary Gap
            // Approach: Brute-Force
            var input = Convert.ToString(N, 2);
            var longestGap = 0;

            var stack = new Stack<int>();


            return longestGap;
        }
    }
}

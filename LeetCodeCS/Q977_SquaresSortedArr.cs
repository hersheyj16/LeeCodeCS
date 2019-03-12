using System;
namespace LeetCodeCS
{
    public class Q977_SquaresSortedArr
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("hi");

            Solution s = new Solution();
            int[] input = { -4, -1, 0, 3, 10 };
            int[] ans = s.SortedSquares(input);
            foreach (int i in ans)
            {
                Console.WriteLine(i);
            }
        }

        class Solution
        {
            public int[] SortedSquares(int[] A)
            {
                int[] ans = new int[A.Length];
                int idx = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    ans[idx] = A[i] * A[i];
                    idx++;
                }

                Array.Sort(ans);
                return ans;
            }
        }
    }
}

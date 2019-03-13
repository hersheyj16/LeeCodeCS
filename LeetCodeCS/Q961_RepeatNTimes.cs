using System;
using System.Collections.Generic;

namespace LeetCodeCS
{
    public class Q961_RepeatNTimes
    {
        public Q961_RepeatNTimes()
        {
        }



        public static int RepeatedNTimes(int[] A)
        {
            int N = A.Length / 2;
            Dictionary<int, int> cache = new Dictionary<int, int>();

            for (int i = 0; i < A.Length; i++)
            {

                var currentCount = 1;
                if (cache.ContainsKey(A[i]))
                {
                    currentCount = cache[A[i]];
                    currentCount = currentCount + 1;
                }
                cache[A[i]] = currentCount;

                if (currentCount == N)
                {
                    return A[i];
                }
               
            }
            return -1;
        }
    }


}

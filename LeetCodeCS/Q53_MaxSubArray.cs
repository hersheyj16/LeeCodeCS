using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeCS
{
    public class Q53_MaxSubArray
    {
        public Q53_MaxSubArray()
        {
        }
      

        private static int MaxSubArray(int[] input)
        {
            int MaxSum = input[0];
            int CurSum = input[0];

            for (int i = 1; i < input.Length; i++)
            {
                CurSum += input[i];
                CurSum = Math.Max(CurSum, input[i]);
                MaxSum = Math.Max(CurSum, MaxSum);
            }
            return MaxSum;
        }

        public static int MaxSubArray2(int[] nums)
        {
            int GlobalMax = Int32.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j <= nums.Length; j++)
                {
                    var localSlice = nums.Slice(i, j);
                    int LocalMax = localSlice.Aggregate((a, b) => b + a);
                    if (LocalMax > GlobalMax)
                    {
                        GlobalMax = LocalMax;
                    }
                }
            }
            return GlobalMax;
        }

    }

    public static class Extensions
    {
        /// <summary>
        /// Get the array slice between the two indexes.
        /// ... Inclusive for start index, exclusive for end index.
        /// </summary>
        public static T[] Slice<T>(this T[] source, int start, int end)
        {
            // Handles negative ends.
            if (end < 0)
            {
                end = source.Length + end;
            }
            int len = end - start;

            // Return new array.
            T[] res = new T[len];
            for (int i = 0; i < len; i++)
            {
                res[i] = source[i + start];
            }
            return res;
        }
    }


}

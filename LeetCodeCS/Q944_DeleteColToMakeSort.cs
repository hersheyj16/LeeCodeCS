using System;
namespace LeetCodeCS
{
    public class Q944_DeleteColToMakeSort
    {
    
        public static int MinDeletionSize(string[] A)
        {
            int acc = 0;
            for (int i = 0; i < A[0].Length; i++)
            {
                bool isSorted = validateCol(A, i);
                if (!isSorted)
                {
                    acc++;
                }
            }
            return acc;
        }

        private static bool validateCol(string[] a, int c)
        {
            string prev = a[0].Substring(c, 1);
            for (int i = 1; i < a.Length; i++)
            {
                string cur = a[i].Substring(c, 1);

                int comp = string.Compare(cur, prev, StringComparison.Ordinal);
                if (comp < 0)
                {
                    return false;
                }
                prev = a[i].Substring(c, 1);
            }
            return true;
        }
    }
}

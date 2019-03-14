using System;
namespace LeetCodeCS
{
    public class Q832_FlipAnImage
    {
        public static void Main(string[] args)
        {
            int[] p = { 1, 1, 0 };
            int[][] input = { p };
            var ans = FlipAndInvertImage(input);
       
            Console.WriteLine(ans);
        }

        private static object FlipAndInvertImage(int[][] A)
        {
            int length = A[0].Length;
            int[][] B = new int[A.Length][];
            for (int i = 0; i < A.Length; i++)
            {
                B[i] = flip(A[i]);
                B[i] = invert(B[i]);
            }
            return B;
        }

        private static int[] invert(int[] A)
        {
            int[] B = new int[A.Length];
            int j = A.Length - 1;
            for (int i = 0; i < A.Length; i++) {
                B[j] = A[i];
                j--;
            }
            return B;
        }

        private static int[] flip(int[] A)
        {
            int[] B = new int[A.Length];
            for (int i = 0; i < A.Length; i++) {
                B[i] = A[i] == 1 ? 0 : 1;
            }
            return B;
        }
    }
}

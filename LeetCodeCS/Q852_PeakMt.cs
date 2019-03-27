using System;
namespace LeetCodeCS
{
    public class Q852_PeakMt
    {
        public static int PeakIndexInMountainArray(int[] A)
        {
            if (A.Length < 3) {
                return -1;
            }

            int prev = A[0];
            for (int i = 1; i < A.Length - 1; i++) { 
                if (A[i] > prev && A[i] > A[i + 1]) {
                    return i;
                }
            }
            return -1;

        }

        public static void Main(string[] args)
        {
            //Console.WriteLine("hi");
            //int[] input = { 0,2,1,0};
            //var ans = PeakIndexInMountainArray(input);
            //Console.WriteLine(ans);
        }
    }
}

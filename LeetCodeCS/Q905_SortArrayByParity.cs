using System;
using System.Collections.Generic;

namespace LeetCodeCS
{
    public class Q905_SortArrayByParity
    {
        public Q905_SortArrayByParity()
        {
        }
        //public static void Main(string[] args) {
        //    Console.WriteLine("hello");
        //    int[] input = { 3, 1, 2, 4 };
        //    var ans = SortArrayByParity(input);
        //    foreach (int i in ans) {
        //        Console.WriteLine(i);
        //        }
        //}

        public static int[] SortArrayByParity(int[] A)
        {
            int[] ans = new int[A.Length];
            List<int> even = new List<int>();
            List<int> odd = new List<int>();
            for (int i = 0; i < A.Length; i++) { 
                if (A[i] % 2 == 0)
                {
                    even.Add(A[i]);
                }
                else {
                    odd.Add(A[i]);
                }
            }

            var evenIt = even.GetEnumerator();
            var oddIt = odd.GetEnumerator();

            for (int j = 0; j < ans.Length;) { 
                while (evenIt.MoveNext()) {
                    Console.WriteLine("debug even" + evenIt.Current);
                    ans[j] = evenIt.Current;
                    j++;
                }

                while (oddIt.MoveNext()) {
                    Console.WriteLine("debug odd" + oddIt.Current);
                    ans[j] = oddIt.Current;
                    j++;
                }


            }
            return ans;

        }
    }
}

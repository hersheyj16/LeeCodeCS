using System;
using System.Collections.Generic;
using System.Collections;

namespace LeetCodeCS
{
    public class Q728_SelfDividingNum
    {
        public static void Main(string[] args)
        {


            IList<int> ans = SelfDividingNumbers(1, 22);
            foreach (var item in ans)
            {
                Console.WriteLine(item);

            }
        }


        public static IList<int> SelfDividingNumbers(int left, int right)
        {
            IList<int> nums = new List<int>();

            for (int i = left; i <= right; i++)
            {
                if (selfDivides(i))
                {
                    nums.Add(i);
                }
            }
            return nums;

        }

        private static bool selfDivides(int i)
        {
            List<int> digits = getIntArray(i);
            foreach (int d in digits) { 
                if (d == 0) {
                    return false;
                }
                if (i % d != 0) {
                    return false;
                }
            }
            return true;
        }

        private static List<int> getIntArray(int i)
        {
            List<int> listOfInts = new List<int>();
            while(i > 0) {
                listOfInts.Add(i % 10);
                i = i / 10;
            }

            return listOfInts;
        }
    }
}

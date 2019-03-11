using System;
using System.Collections.Generic;
using LeetCodeCS;

namespace LeetCodeCSQ438
{


    public class Q438_FindAllAnagrams
    {
        public Q438_FindAllAnagrams()
        {
        }
        public static void Main(string[] args)
        {
            var s = new Solution();
            //var ans = s.("abc", "a");
            var setAna = s.FindAnagrams("abc", "a");

            foreach (int s1 in setAna)
            {
                Console.WriteLine(s1);
            }
        }
    }



    public class Solution
    {

        public IList<int> FindAnagrams(string s, string p)
        {
            var ans = new List<int>();
            var left = 0;
            var right = 0;
            var sLen = s.Length;
            var pLen = p.Length;

            int[] hash = new int[256];

            for (int i = 0; i < pLen; i++)
            {
                var charP = p.ToCharArray();
                hash[charP[i]]++;
            }

            var sChar = s.ToCharArray();
            int count = 0;
            while (right < sLen)
            {
                if (hash[sChar[right]] > 0)
                {
                    hash[sChar[right]]--;
                    count++;
                    right++;
                }
                else
                {
                    hash[sChar[left]]++;
                    count--;
                    left++;
                }
                if (count == pLen)
                {
                    ans.Add(left);
                }
            }
            return ans;


        }
    }
}

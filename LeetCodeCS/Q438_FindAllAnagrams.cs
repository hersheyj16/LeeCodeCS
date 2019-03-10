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
            var setAna = s.GenerateAnagrams("abc");

            foreach (string s1 in setAna)
            {
                Console.WriteLine(s1);
            }
        }
    }



    public class Solution
    {

        public IList<int> FindAnagrams(string s, string p)
        {
            Console.WriteLine("hello find anagram");
            ISet<String> possibilities = GenerateAnagrams(p);

            // find their indexes
            var ans = new List<int>();
            for (int i = 0; i <= s.Length - p.Length; i++)
            {
                if (possibilities.Contains(s.Substring(i, p.Length)))
                {
                    ans.Add(i);
                }
            }
            return ans;
        }

        public ISet<string> GenerateAnagrams(string p)
        {
            var emptySet = new HashSet<string>();
            emptySet.Add(p.Substring(0, 1));

            var allAna = helper(p, 1, emptySet);
            return allAna;
        }

        private ISet<string> helper(string a, int idx, ISet<string> allSet)
        {
            if (idx == a.Length)
            {
                return allSet;
            }
            ISet<string> newAllSets = new HashSet<string>();
            string currentLetter = a.Substring(idx, 1);


            foreach (string element in allSet)
            {
                for (int i = 0; i <= element.Length; i++)
                {
                    string newString = element.Insert(i, currentLetter);
                    newAllSets.Add(newString);
                }
            }
            idx = idx + 1;
            return helper(a, idx, newAllSets);

        }

        private string insert(int i, string currentLetter, string element)
        {
            return element.Insert(i, currentLetter);
        }

        //private  helper(string p, int idx, HashSet<string> allAna)
        //{
        //    if (idx == p.Length) {
        //        return;
        //    }
        //    allAna.Add(p);
        //    for (string s : allAna) { 
        //    }
        //}
    }
}

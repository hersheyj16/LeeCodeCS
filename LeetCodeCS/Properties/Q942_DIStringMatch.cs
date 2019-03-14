using System;
using System.Collections.Generic;

namespace LeetCodeCS.Properties
{
    public class Q942_DIStringMatch
    {
        public static void Main(string[] args)
        {
    
            var ans = DiStringMatch("IDID");

            Console.WriteLine(ans);
        }

        public static int[] DiStringMatch(string S)
        {
            int[] ans = new int[S.Length + 1];
            List<int> deque = new List<int>();
            for (int i = 0; i <= S.Length; i++) {
                deque.Add(i);
            }

            int idx = 0;
            for (int j = 0; j < S.Length; j++) {
                String command = S.Substring(j, 1);
                if (command == "I") {
                    ans[idx] = deque.GetRange(0, 1)[0];
                    deque.RemoveAt(0);
                    //deque.TrimExcess();
                }
                else {
                    int last = deque.Count - 1;
                    ans[idx] = deque.GetRange(last, 1)[0];
                    deque.RemoveAt(last);
                }
                idx++;
            }

            while(idx != S.Length + 1)
            {
                ans[idx] = deque.GetRange(0, 1)[0];
                deque.Remove(0);
                idx++;
            }
            return ans;
        }
    }
}

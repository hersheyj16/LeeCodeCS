using System;

namespace LeetCodeCS
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            TreeNode t = new TreeNode(1);
            t.left = new TreeNode(2);
            t.right = new TreeNode(2);

            Solution s = new Solution();
            var ans = s.IsSymmetric(t);
            Console.WriteLine(ans);

        }
    }

    public class Solution
    {
        public bool IsSymmetric(TreeNode root)
        {
            return helper(root, root);
        }

        private bool helper(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null) {
                return true;
            }
            if (root1 == null || root2 == null) {
                return false;
            }

            return root1.val == root2.val &&
            helper(root1.left, root2.right) &&
            helper(root1.right, root2.left);
        }
    }
}

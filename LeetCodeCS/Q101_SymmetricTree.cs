using System;

namespace LeetCodeCS
{

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

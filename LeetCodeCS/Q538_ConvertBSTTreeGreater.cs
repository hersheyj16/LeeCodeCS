using System;
namespace LeetCodeCS
{
    public class Q538_ConvertBSTTreeGreater
    {
        //public static void Main(string[] args)
        //{

        //    Console.WriteLine("hi");

        //    TreeNode r = new TreeNode(5);
        //    r.left = new TreeNode(2);
        //    r.left.right = new TreeNode(4);
        //    r.right = new TreeNode(13);

        //    var ans = ConvertBST(r);
        //    Console.WriteLine(ans.val);

        //}

        public static int sumSoFar = 0;
        public static TreeNode ConvertBST(TreeNode root)
        {
           if (root == null) {
                return root;
            }

            ConvertBST(root.right);
            root.val += sumSoFar;
            sumSoFar = root.val;
            ConvertBST(root.left);

            return root;
        }
    }
}

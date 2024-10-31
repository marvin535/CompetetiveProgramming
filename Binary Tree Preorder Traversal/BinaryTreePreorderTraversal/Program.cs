using System;
using System.Collections.Generic;

namespace BinaryTreePreorderTraversal
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int value)
        {
            val = value;
            left = null;
            right = null;
        }
    }

    internal class Program
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            List<int> result = new List<int>();
            if (root == null) return result;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                TreeNode node = stack.Pop();
                result.Add(node.val);

                if (node.right != null)
                {
                    stack.Push(node.right);
                }
                if (node.left != null)
                {
                    stack.Push(node.left);
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.right = new TreeNode(2);
            root.right.left = new TreeNode(3);

            Program program = new Program();
            IList<int> result = program.PreorderTraversal(root);

            Console.WriteLine("Preorder Traversal: " + string.Join(", ", result));
        }
    }
}

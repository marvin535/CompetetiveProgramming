using System.Windows;

namespace ConsoleApp1
{
    public class Program
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
                result.Add(node.val); // Visit the root

                // Push right first so that left is processed first
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
            Console.WriteLine("Hello, World!");
        }
    }
}

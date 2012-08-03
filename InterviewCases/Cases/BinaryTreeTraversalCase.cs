using System;
using System.Collections.Generic;

namespace InterviewCases.Cases
{
    // Q: Write binary-tree traversal on paper (15 minutes)

    // Requirements
    // * Find all nodes less than a particular value.
    // * The method should take a parameter that specifies the value you are comparing against.

    // Assumptions
    // * You can assume that you are given a root node

    // A node has a left, right, and value
    // Public class Node
    // {
    //      Public Node Left;
    //      Public Node Right;
    //      Public int Value;
    // }

    // There are 4 solutions to the problem … Which are you going to implement?
    // * Depth First
    // * Breadth First
    // * Non recursive vs. recursive

    public class Node
    {
        public Node Left;
        public Node Right;
        public int Value;
    }

    /*
     *               1
     *           2       3
     *         4   5   6   7
     *       8
     *     9   10
     */

    public class BinaryTreeTraversalCase : Case
    {
        public static void DepthFirstRecursiveTraverse(Node root, int maxValue)
        {
            if (root == null) return;

            Process(root, maxValue);
            if (root.Left != null) DepthFirstRecursiveTraverse(root.Left, maxValue);
            if (root.Right != null) DepthFirstRecursiveTraverse(root.Right, maxValue);
        }

        public static void DepthFirstNonRecursiveTraverse(Node root, int maxValue)
        {
            var nodes = new Stack<Node>();
            nodes.Push(root);

            while (nodes.Count > 0)
            {
                var cur = nodes.Pop();
                Process(cur, maxValue);
                if (cur.Left != null) nodes.Push(cur.Left);
                if (cur.Right != null) nodes.Push(cur.Right);
            }
        }

        public static void BreadthFirstNonRecursive(Node root, int maxValue)
        {
            if (root == null) return;
            var queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var cur = queue.Dequeue();
                Process(root, maxValue);
                if (cur.Left != null) queue.Enqueue(cur.Left);
                if (cur.Right != null) queue.Enqueue(cur.Right);
            }
        }

        public static void Process(Node node, int maxValue)
        {
            if (node.Value < maxValue)
            {
                Console.WriteLine(node.Value);
            }
        }

        protected override void Main()
        {

            
        }
    }
}

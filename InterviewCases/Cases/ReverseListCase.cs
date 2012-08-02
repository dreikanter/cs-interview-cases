using System;

namespace InterviewCases.Cases
{
    // Q: Reverse a singly linked list (15 minutes)
    // Requirements
    // Reverse the nodes in a singly linked list.
    // The goal is to see if you can traverse a linked list from front to back.
    // 
    // There are three possible implementations.
    // The first would be cpu hungry.
    // The second would be resource hungry.
    // The third would be neither cpu nor resource hungry. 
    // 
    // Assumptions
    // You can assume that you are given a root node
    // A node has a child and a value
    // 
    // Public class Node
    // {
    //     Public Node Child;
    //     Public int Value;
    // }

    // A:

    public class ReverseListCase : Case
    {
        public class Node
        {
            public Node Child;
            public int Value;
        }

        public static Node GetRandomList(int count)
        {
            if (count < 0) throw new ArgumentOutOfRangeException("count");
            if (count == 0) return null;

            var current = new Node { Child = null, Value = 0 };
            var root = current;

            for (var i = 1; i < count; i++)
            {
                current.Child = new Node { Child = null, Value = i };
                current = current.Child;
            }

            return root;
        }

        public static Node Reverse(Node root)
        {
            if (root == null || root.Child == null) return root;
            
            var cur = root.Child;
            var prev = root;

            // n 1-2 2-3 3-4 4-n
            while (cur != null)
            {
                // 2 -> 1 keep cur.child; old cur.child -> prev; prev = cur; cur = keepd
                // 3 -> 2
                // 4 -> 3
                var next = cur.Child;
                cur.Child = prev;
                prev = cur;
                cur = next;

            }

            return cur;
        }

        private static void PrintNodes(Node root)
        {
            while(root != null)
            {
                Console.Write(String.Format("{0} ", root.Value));
                root = root.Child;
            }

            Console.WriteLine();
        }

        protected override void Main()
        {
            var root = GetRandomList(10);
            PrintNodes(root);

            var reversed = Reverse(root);
            PrintNodes(reversed);
        }
    }
}

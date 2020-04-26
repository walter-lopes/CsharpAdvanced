using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet.Academic.DataStructures.Trees
{
    public class BinaryTree
    {
        public class Node
        {
            public int value;
            public Node left;
            public Node right;
        }

        public class Tree
        {
            public Node insert(Node root, int v)
            {
                if (root == null)
                {
                    root = new Node();
                    root.value = v;
                }
                else if (v < root.value)
                {
                    root.left = insert(root.left, v);
                }
                else
                {
                    root.right = insert(root.right, v);
                }

                return root;
            }

            public void traverse(Node root)
            {
                if (root == null)
                {
                    return;
                }

                traverse(root.left);
                traverse(root.right);
            }

            //Tree: Height of a Binary Tree
            public int FindMaxDepth(Node root)
            {
                if (root is null)
                {
                    return 0;
                } 
                else
                {
                    var ldepth = FindMaxDepth(root.left);
                    var rdepth = FindMaxDepth(root.right);

                    if (ldepth > rdepth)
                    {
                        return ldepth + 1;
                    }
                    else
                    {
                        return rdepth + 1;
                    }
                }          
            }

            //Tree: Level Order Traversal
            public void LevelOrderTraversal(Node root)
            {
                var queue = new Queue<Node>();
                var orderTraversalValues = string.Empty;

                queue.Enqueue(root);

                while(queue.Count > 0)
                {
                    root = queue.Dequeue();

                    if (root.left != null)
                        queue.Enqueue(root.left);

                    if (root.right != null)
                        queue.Enqueue(root.right);

                    orderTraversalValues += root.value.ToString() + " ";
                }

                Console.WriteLine(orderTraversalValues);
            }


            public void PrintPreOrder(Node root)
            {
                if(!(root is null))
                {
                    Console.WriteLine(root.value);
   
                    PrintPreOrder(root.left);

                    PrintPreOrder(root.right);
                }                 
            }

            public void PrintPostOrder(Node root)
            {
                if (!(root is null))
                {
                    PrintPostOrder(root.left);

                    PrintPostOrder(root.right);

                    Console.WriteLine(root.value);
                }
            }

            public void PrintInOrder(Node root)
            {
                if (!(root is null))
                {
                    PrintInOrder(root.left);

                    Console.WriteLine(root.value);

                    PrintInOrder(root.right);
                }
            }
        }
    }
}

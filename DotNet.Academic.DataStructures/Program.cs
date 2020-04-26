using DotNet.Academic.DataStructures.Stack;
using System;
using static DotNet.Academic.DataStructures.Trees.BinaryTree;

namespace DotNet.Academic.DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree bst = new Tree();
            Node root = null;

            var arr = new[] { 5, 8, 1, 7, 9, 10, 3, 2 };

            for (int i = 0; i < arr.Length; i++)
            {
               root = bst.insert(root, arr[i]);
            }



            bst.LevelOrderTraversal(root);
            Console.ReadKey();

            
            //Stack<string> stack = new Stack<string>();

            //stack.Push("1");
            //stack.Push("2");
            //stack.Push("3");

            //stack.Pop();

            //Console.WriteLine(stack.IsEmpty());
            //Console.WriteLine(stack.Size());

            //stack.Pop();
            //stack.Pop();


            //Console.WriteLine(stack.IsEmpty());
            //Console.WriteLine(stack.Size());


            //ProblemWithStack problem = new ProblemWithStack();

            //var binary = problem.DivideBy2(10);

            //Console.WriteLine(binary);


            //Console.ReadLine();
        }
    }
}

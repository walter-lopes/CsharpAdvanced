using DotNet.Academic.DataStructures.Stack;
using System;

namespace DotNet.Academic.DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            stack.Push("1");
            stack.Push("2");
            stack.Push("3");

            stack.Pop();

            Console.WriteLine(stack.IsEmpty());
            Console.WriteLine(stack.Size());

            stack.Pop();
            stack.Pop();


            Console.WriteLine(stack.IsEmpty());
            Console.WriteLine(stack.Size());


            ProblemWithStack problem = new ProblemWithStack();

            var binary = problem.DivideBy2(10);

            Console.WriteLine(binary);


            Console.ReadLine();
        }
    }
}

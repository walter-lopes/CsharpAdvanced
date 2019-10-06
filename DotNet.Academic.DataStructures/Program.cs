using System;

namespace DotNet.Academic.DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack.Stack stack = new Stack.Stack();

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


            Console.ReadLine();
        }
    }
}

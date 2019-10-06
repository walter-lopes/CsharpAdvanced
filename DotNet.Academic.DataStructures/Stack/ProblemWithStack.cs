using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet.Academic.DataStructures.Stack
{
    public class ProblemWithStack
    {

       public string DivideBy2(int number)
       {
            var stack = new Stack<int>();

            int rem;
            string binaryString = string.Empty;

            while(number > 0)
            {
                double result = number % 2;
                rem = (int) Math.Floor(result);
                stack.Push(rem);
                result = number / 2;
                number = (int) Math.Floor(result);
            }

            while (!stack.IsEmpty())
            {
                binaryString += stack.Pop().ToString();
            }

            return binaryString;
       }
    }
}

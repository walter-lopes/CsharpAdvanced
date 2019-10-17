using System;

namespace DotNetAcademic.Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };

            Merge merge = new Merge();

            merge.Sort(arr, 0, arr.Length - 1);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
                Console.ReadKey();
            }
        }
    }
}

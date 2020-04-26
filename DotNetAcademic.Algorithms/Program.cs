using System;
using System.Diagnostics;

namespace DotNetAcademic.Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            int[] arr = new int[] { 3, 2, 1, 5, 4, 3123, 1231, 21312312, 988900, 43455 };

            //int j = 0;
            //for (int i = 100000; i > 0 ; i--)
            //{
            //    arr[j] = i;
            //    j++;
            //}

            Quick quick = new Quick();
            Merge merge = new Merge();
            HeapSort heap = new HeapSort();
            sw.Start();
            heap.sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            sw.Stop();
            Console.WriteLine("Elapsed={0}", sw.Elapsed);
            Console.ReadKey();
        }
    }
}

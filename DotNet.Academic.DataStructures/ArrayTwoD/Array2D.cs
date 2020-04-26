using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet.Academic.DataStructures.ArrayTwoD
{
    public class Array2D
    {
        // Complete the hourglassSum function below.
        static int hourglassSum(int[][] arr)
        {

            int rows = arr.Length;
            int columns = arr[0].Length;

            int maxHourGlass = int.MinValue;

            for (int i = 0; i < rows - 3; i++)
            {
                for (int j = 0; j < columns - 3; j++)
                {

                    int currentValue = arr[i][j] + arr[i][j++] + arr[i][j+2] + arr[i+1][j+1] + arr[i+2][j] + arr[i+2][j++] + arr[i+2][j+2];

                    maxHourGlass = Math.Max(currentValue, maxHourGlass);
                }
            }

            return maxHourGlass;

        }

        static void Call()
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = hourglassSum(arr);

            Console.WriteLine(result);
        }
    }
}

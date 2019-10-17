using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetAcademic.Algorithms
{
    public class Merge
    {
         //MergeSort(arr[], l, r)
         //If r > l
         //1. Find the middle point to divide the array into two halves:  
         //        middle m = (l + r) / 2
         //2. Call mergeSort for first half:   
         //        Call mergeSort(arr, l, m)
         //3. Call mergeSort for second half:
         //        Call mergeSort(arr, m+1, r)
         //4. Merge the two halves sorted in step 2 and 3:             Call merge(arr, l, m, r)

        public void MergeSort(int[] array, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] left  = new int [n1];
            int[] right = new int[n2];

            int i = 0, j = 0;

            for (i = 0; i < n1; ++i)
                left[i] = array[l + i];
            for (j = 0; j < n2; ++j)
                right[j] = array[m + 1 + j];

            i = 0;
            j = 0;

            int k = l;
            while (i < n1 && j < n2)
            {
                if (left[i] <= right[j])
                {
                    array[k] = left[i];
                    i++;
                }
                else
                {
                    array[k] = right[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                array[k] = left[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                array[k] = right[j];
                j++;
                k++;
            }
        }

        public void Sort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                // Find the middle point 
                int m = (l + r) / 2;

                // Sort first and second halves 
                Sort(arr, l, m);
                Sort(arr, m + 1, r);

                // Merge the sorted halves 
                MergeSort(arr, l, m, r);
            }
        }
    }
}

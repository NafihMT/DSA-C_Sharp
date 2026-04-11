using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class MergeSort
    {

        public static void Sort(int[]arr,int lower,int upper)
        {
            if (lower >= upper) return;

            int mid = (lower + upper) / 2;

            Sort(arr, lower, mid);               // Sort lower portion
            Sort(arr, mid + 1, upper);          // Sort upper portion

            Merge(arr, lower, mid, upper);
        }
        private static void Merge(int[]arr,int lower,int mid, int upper)
        {
            int[] res = new int[arr.Length];

            int i = lower;              // Index of left array
            int j = mid + 1;            // Index of right array
            int k = lower;              //index of new array, so start from lower (at the time of merge it will be 0)


            // Copy Data            
            while (i <= mid && j <= upper)         // i and j must be smaller than its right pointer
            {
                if (arr[i] <= arr[j])              // checking both elements from left and right arrays
                {
                    res[k] = arr[i];
                    i++;
                    k++;
                }
                else
                {
                    res[k] = arr[j];
                    j++;
                    k++;
                }
            }

            if (i > mid)                    // if both array are not equal add remaining elements 
            {
                while (j <= upper)
                {
                    res[k] = arr[j];
                    j++;
                    k++;

                }
            }
            else
            {
                while (i <= mid)
                {
                    res[k] = arr[i];
                    i++;
                    k++;
                }
            }

            // Copy all elements of res -> arr

            for (k = lower; k <= upper; k++)
            {
                arr[k] = res[k];
            }

        }
    }
}

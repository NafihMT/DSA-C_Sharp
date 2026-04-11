using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Sorting
{
    internal class QuickSort
    {

        public static void QuickSorting(int[]arr, int low, int high)
        {
            if (low < high)
            {
                int pIndex = Partition(arr, low, high);         // Partition() => return end
                QuickSorting(arr, low, pIndex - 1);             // For Sorting the left portion
                QuickSorting(arr, pIndex + 1, high);            // For Sorting the Right Portion

            }
        }

        public static int Partition(int[]arr,int low, int high)
        {
            int pivot = arr[low];
            int start = low + 1;        // Bcz low is pivot
            int end = high;

            while (start <= end)
            {
                while (start <= end && arr[start] <= pivot)
                {
                    start++;
                }
                while (start <= end && arr[end] > pivot)
                {
                    end--;
                }
                if (start > end)
                {
                    break;
                }

                // swap start and end

                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

            }

            // place pivot at correct position
            // Replace Lowerbound with end

            // swap low and end

            int temp1 = arr[low];
            arr[low] = arr[end];
            arr[end] = temp1;

            return end;
        }



        public void Qui(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(arr, low, high);
                Qui(arr, low, pivotIndex - 1);
                Qui(arr, pivotIndex + 1, high);
            }
        }

        public int Parti(int[] arr, int low, int high)
        {
            int pivot = arr[low];
            int start = low + 1;
            int end = high;

            while (start <= end)
            {
                while(start<=end && arr[start] <= pivot)
                {
                    start++;
                }
                while(start<=end && arr[end] > pivot)
                {
                    end--;
                }
                if (start > end)
                {
                    break;
                }
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
            }
            int tmp = arr[low];
            arr[low] = arr[end];
            arr[end] = tmp;

            return end;
           
        }




    }
}

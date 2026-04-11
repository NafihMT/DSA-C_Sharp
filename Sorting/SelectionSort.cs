using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class SelectionSort
    {
        public static void Selection(int[] arr)
        {
            int n = arr.Length;

            for(int i = 0; i < n - 1; i++)
            {
                int MinIndex = i;
                for(int j = i + 1; j < n; j++)
                {
                    if (arr[MinIndex] > arr[j])
                    {
                        MinIndex = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[MinIndex];
                arr[MinIndex] = temp;

            }
        }

        public void selection(int[] arr)
        {
            int n = arr.Length;
            for(int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for(int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }
        
    }
}

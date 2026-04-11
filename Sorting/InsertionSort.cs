using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class InsertionSort
    {
        public static void Insertion(int[] arr)
        {
            int n = arr.Length;
            for(int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while(j >= 0 && arr[j] > key)     // left element must greater than right(key) element
                {
                    arr[j + 1] = arr[j];         // shift the left element to right 
                                                 // Don't replace left with right immediately
                    j--;
                }
                arr[j + 1] = key;                // Here replace (may be j = -1, if it is smallest value)
            }
        }


        
        public void Insert(int[] arr)
        {
            int n = arr.Length;
            for(int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
    }
}

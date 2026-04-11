using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class BubbleSort
    {
        public static void Bubble(int[] arr)
        {
            int n = arr.Length;

            for(int i = 0; i < n - 1; i++)              // pass
            {
                for(int j = 0; j < n - i - 1; j++)      // end elements are sorting ( large )
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }


        public void bub(int[] arr)
        {
            int n = arr.Length;

            for(int i = 0; i < n - 1; i++)
            {
                for(int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }


   
}

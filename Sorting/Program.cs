namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 4, 5, 6, 36, 4, 1,23, 12 };
            //BubbleSort b1 = new BubbleSort();                 // It is Static method
            //BubbleSort.Bubble(arr);

            //foreach(int i in arr)
            //{
            //    Console.WriteLine(i);
            //}

            //InsertionSort.Insert(arr);
            //foreach(int i in arr)
            //{
            //    Console.WriteLine(i);
            //}

            QuickSort.QuickSorting(arr, 0, arr.Length - 1);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}

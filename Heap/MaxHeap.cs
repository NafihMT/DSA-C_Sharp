using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    internal class MaxHeap
    {

        List<int> heap = new List<int>();
        public void Insert(int val)
        {
            heap.Add(val);
            HeapifyUp(heap.Count - 1);
        }
        public void HeapifyUp(int i)
        {
            while (i < 0)
            {
                int parent
            }
        }

        public void Swap(int i, int j)
        {
            int temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }

        public void ExtractMax(int i)
        {
            int max = heap[0];
            heap[0] = heap[heap.Count - 1];

        }
    }
}

using System;
using System.Collections.Generic;           
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    internal class MinHeap
    {
        private List<int> heap = new List<int>();

        public void Insert(int val)
        {
            heap.Add(val);
            HeapifyUp(heap.Count - 1);             // Heapify from leaf node(last element)
        }
        public void HeapifyUp(int i)
        {
            while (i > 0)
            {
                int parent = (i - 1) / 2;           // To find the Parent Index
                if (heap[parent] <= heap[i])
                    break;

                Swap(parent, i);                    // If parent is Bigger
                i = parent;                         // Move up the parent to check further values
            }
        }

        

        public void Swap(int i, int j)
        {
            int temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }


        public int ExtractMin()                 // Deletion
        {
            if (heap.Count == 0) return -1;

            int min = heap[0];                  
            heap[0] = heap[heap.Count - 1];     // Bring the last element in root { Root removed }

            heap.RemoveAt(heap.Count - 1);

            HeapifyDown(0);                     // Root will be wrong to make the current element correct
            return min;
        }

        public void HeapifyDown(int i)
        {
            int smallest = i;                   // Assume current node is smallest

            int left = 2 * i + 1;
            int right = 2 * i + 2;              // Calculate child indices

            if(left < heap.Count && heap[left] < heap[smallest])
            {
                smallest = left;                // If left child is smaller → update smallest
            }
            if(right < heap.Count && heap[right] < heap[smallest])
            {
                smallest = right;               // Check left or right is smallest
            }

            if (smallest != i)                  // If current node is not smallest → violation exists
            {
                Swap(i, smallest);              // Swap element with smallest child
                HeapifyDown(smallest);
            }


        }
    }
}

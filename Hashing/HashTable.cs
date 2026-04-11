using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{

    public class Entry
    {
        public int Key;
        public string Value;
        public Entry Next;

        public Entry(int key, string value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }
    public class HashTable
    {
        private Entry[] buckets;
        private int Size;

        public HashTable(int size)
        {
            Size = size;
            buckets = new Entry[Size];
        }

        public int GetIndex(int key)
        {
            return Math.Abs(key.GetHashCode()) % Size;
        }

        public void Insert(int key, string value)
        {
            int index = GetIndex(key);

            Entry newEntry = new Entry(key, value);     // Create a new node

            if (buckets[index] == null)                 // No data exists at this index
            {
                buckets[index] = newEntry;              // make newEntry as Head
            }
            else                                        // Collision Happened
            {
                Entry current = buckets[index];         // Head
                while(current != null) 
                {
                    if(current.Key == key)              // Check the key already exists
                    {
                        current.Value = value;          // Update
                        return;
                    }
                    if(current.Next == null)            // If loop reached at last node break to insert at end
                    {
                        break;
                    }
                    current = current.Next;             
                }
                current.Next = newEntry;               // Attach new node at end
            }
        }


        public string Get(int key)
        {
            int index = GetIndex(key);

            Entry current = buckets[index];
            while(current != null)
            {
                if(current.Key == key)
                {
                    return current.Value;
                }
                current = current.Next;
            }
            return null;
        }

        public void Delete(int key)
        {
            int index = GetIndex(key);

            Entry current = buckets[index];
            Entry prev = null;

            while (current != null)
            {
                if (current.Key == key)
                {
                    if(prev == null)
                    {
                        buckets[index] = current.Next;
                    }
                    else
                    {
                        prev.Next = current.Next;
                    }
                    return;
                }
                prev = current;
                current = current.Next;
            }
        }

        public void Display()
        {
            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine($"Bucket{i}: ");
                Entry current = buckets[i];

                while(current != null)
                {
                    Console.WriteLine($"[{current.Key} : {current.Value}] -> ");
                    current = current.Next;
                }
                Console.WriteLine("null");
            }
        }

    }
}

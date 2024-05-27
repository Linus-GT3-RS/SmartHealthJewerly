using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BackendCS
{
    public class Buffer
    {
        private int[] data;

        private int readPointer;
        private int writePointer;
        private int size;

        public int Capacity { get; }
        public int Count { get; private set; }

        public Buffer(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentOutOfRangeException("capacity must be grater than zero");
            }

            Capacity = capacity;
            data = new int[capacity];
            readPointer = 0;
            writePointer = 0;
            size = capacity;
            Count = 0;
        }

        public void Write(int value)
        {
            if (Count == size)
            {
                throw new InvalidOperationException("Buffer is full.");
            }

            data[writePointer] = value;
            writePointer++;
            writePointer = writePointer % size;
            Count++;
        }

        public int Read()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Buffer is empty.");
            }

            int item = data[readPointer];
            data[readPointer] = 0; // clear slot
            readPointer++;
            readPointer = readPointer % size;
            Count--;
            return item;
        }

        
    }
}

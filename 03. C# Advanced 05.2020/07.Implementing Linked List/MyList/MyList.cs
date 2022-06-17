using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace MyList
{
    class MyList<T> : IEnumerable<T>
    {
        private int capacity;
        private T[] data;

        public MyList()
            : this(4)
        {

        }

        public MyList(int capacity)
        {
            this.capacity = capacity;
            this.data = new T[capacity];
        }

        public int Count { get; private set; }

        public T this[int index]
        {
            get
            {
                this.ValidateIndex(index);

                return this.data[index];
            }
            set
            {
                this.ValidateIndex(index);

                this.data[index] = value;
            }
        }

        public void Add(T number)
        {
            this.Resize();

            this.data[this.Count] = number;

            this.Count++;
        }

        public T RemoveAt(int index)
        {
            this.ValidateIndex(index);

            T removedElement = this.data[index];

            for (int i = index; i < this.Count; i++)
            {
                this.data[i] = this.data[i + 1];
            }

            this.Count--;

            return removedElement;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            this.ValidateIndex(firstIndex);
            this.ValidateIndex(secondIndex);

            T temp = this.data[firstIndex];
            this.data[firstIndex] = this.data[secondIndex];
            this.data[secondIndex] = temp;
        }

      public bool Contains(T element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.data[i].Equals(element))
                {
                    return true;
                }
            }

            return false;
        }

        public void Clear()
        {
            this.Count = 0;
            this.data = new T[this.capacity];
        }

        public MyList<T> GetRange(int index, int count)
        {
            this.ValidateIndex(index);
            this.ValidateIndex(index + count);

            var newList = new MyList<T>();

            for (int i = index; i < index + count; i++)
            {
                newList.Add(this.data[i]);
            }

            return newList;
        }

        public int RemoveAll(Func<T, bool> filter)
        {
            var removed = 0;

            for (int i = 0; i < this.Count; i++)
            {
                if (filter(this.data[i]))
                {
                    this.RemoveAt(i);
                    removed++;
                }
            }

            return removed;
        }

        private void ValidateIndex(int index)
        {
            var message = this.Count == 0 
                ? "The list is empty" 
                : $"Valid positions are from {0} to {Math.Max(0, this.Count - 1)}";

            if (index < 0 || index >= this.Count)
            {
                throw new Exception($"The index is out of range. {message}.");
            }
        }


        private void Resize()
        {
            if (this.Count == this.data.Length)
            {
                int newCapacity = this.data.Length * 2;

                var newData = new T[newCapacity];

                for (int i = 0; i < this.data.Length; i++)
                {
                    newData[i] = this.data[i];
                }

                this.data = newData;
            }
        }

        public IEnumerator<T> GetEnumerator()
         => this.data.Take(this.Count).ToList().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
         => this.GetEnumerator();
    }
}

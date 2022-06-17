using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private Stack<T> data = new Stack<T>();

        public int Count 
        {
            get
            {
                return this.data.Count;
            }
        }

        public void Add(T item)
        {
            this.data.Push(item);
        }

        public T Remove()
        {
            return this.data.Pop();
        }

    }
}

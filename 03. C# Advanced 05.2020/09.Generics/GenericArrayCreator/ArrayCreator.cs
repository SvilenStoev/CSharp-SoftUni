using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace GenericArrayCreator
{
    public class ArrayCreator
    {
        public static T[] Create<T>(int length, T item)
        {
            var arr = new T[length];

            item.

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = item;
            }

            return arr;
        }
    }
}

using Alg1.Practica.Utils;
using System;

namespace Alg1.Practica.Practicum5
{
    public class ArrayStack : IStack
    {
        protected string[] values;
        protected int size;

        public ArrayStack(int capacity)
        {
            if (capacity < 1)
            {
                throw new ArgumentOutOfRangeException();
            }

            values = new String[capacity];
            size = 0;
        }

        public void Push(string value)
        {
            if (IsFull())
            {
                throw new InvalidOperationException();
            }

            values[size] = value;
            size++;
        }

        public string Pop()
        {
            if (IsEmpty())
            {
                return null;
            }

            size--;
            String val = values[size];
            values[size] = null;

            return val;
        }

        public string Peek()
        {
            if (IsEmpty())
            {
                return null;
            }

            return values[size - 1];
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public bool IsFull()
        {
            return size == values.Length;
        }
    }
}
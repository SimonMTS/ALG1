using System;
using Alg1.Practica.Utils.Exceptions;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum6
{
    public class NawQueueArray
    {
        public int Front { get; set; }

        public int Rear { get; set; }

        protected Alg1NawArray _array; // interne array
        protected int _count; // aantal gebruikte index in interne array
        protected int _size; // maximale omvang van interne array

        public NawQueueArray(int initialSize)
        {
            // aanmaken intern array
            if ((initialSize > 0) && (initialSize <= 1000))
            {
                _size = initialSize;
            }
            else
            {
                throw new NawQueueArrayInvalidSizeException();
            }

            _array = new Alg1NawArray(_size);

            // verdere initialisatie

            Front = 0;
            Rear = -1;
        }

        public void Enqueue(NAW naw)
        {
            if (_count == _size)
            {
                throw new NawQueueArrayOutOfBoundsException();
            }

            Rear++;

            if (Rear >= _size)
            {
                Rear = 0;
            }

            _array[Rear] = naw;

            _count++;
        }

        public NAW Dequeue()
        {
            if (_count <= 0)
            {
                return null;
            }

            NAW tmp = _array[Front];

            _array[Front] = null;
            Front++;

            if (Front >= _size)
            {
                Front = 0;
            }

            _count--;

            return tmp;
        }

        public int Count()
        {
            return _count;
        }
    }

}

using System;
using Alg1.Practica.Utils.Models;
using System.Collections.Generic;

namespace Alg1.Practica.Practicum6
{
    public class NawQueueDotNet
    {
        private Queue<NAW> _queue = new Queue<NAW>();

        public void Enqueue(NAW naw)
        {
            _queue.Enqueue(naw);
        }

        public NAW Dequeue()
        {
            try
            {
                return _queue.Dequeue();
            } catch
            {
                return null;
            }
        }

        public int Count()
        {
            return _queue.Count;
        }

    }
}

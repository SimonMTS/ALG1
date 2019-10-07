using System;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum6
{
    public class NawQueueLinkedList
    {
        public Link First { get; set; }

        protected Link Last { get; set; }

        protected int _count = 0;

        public void Enqueue(NAW naw)
        {
            if (First == null)
            {
                Link head = new Link()
                {
                    Naw = naw,
                    Next = null
                };

                First = head;
                Last = head;
            }
            else
            {
                Link newEnd = new Link()
                {
                    Naw = naw,
                    Next = null
                };

                Last.Next = newEnd;

                Last = newEnd;
            }

            _count++;
        }

        public NAW Dequeue()
        {
            if (First == null)
            {
                return null;
            }

            NAW tmp = First.Naw;

            First = First.Next;
            _count--;

            return tmp;
        }

        public int Count()
        {
            return _count;
        }
    }

}

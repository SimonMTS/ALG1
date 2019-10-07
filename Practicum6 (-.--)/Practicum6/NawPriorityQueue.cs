using System;
using System.Collections.Generic;
using System.Linq;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum6
{
    public class NawPriorityQueue
    {
        private SortedDictionary<int, NawQueueLinkedList> _priorityQueue = new SortedDictionary<int, NawQueueLinkedList>();
        private int _used = 0;

        public void Enqueue(int priority, NAW naw)
        {
            NawQueueLinkedList list;
            if (!_priorityQueue.ContainsKey(priority))
            {
                list = new NawQueueLinkedList();
                _priorityQueue.Add(priority, list);
            } else
            {
                list = _priorityQueue[priority];
            }

            _used++;
            list.Enqueue(naw);
        }

        public NAW Dequeue()
        {
            if (_used == 0)
            {
                return null;
            }

            _used--;

            var naw = _priorityQueue.First().Value.Dequeue();

            if (_priorityQueue.First().Value.Count() == 0)
            {
                _priorityQueue.Remove(_priorityQueue.First().Key);
            }

            return naw;
        }

        public int Count()
        {
            return _used;
        }

        public void Show()
        {
            Console.WriteLine("-- -- v -- --");

            foreach (var key in _priorityQueue.Keys)
            {
                Link link =_priorityQueue[key].First;

                Console.WriteLine("\t-- -- v -- -- " + key);

                while (link != null)
                {
                    Console.WriteLine("\t\t" + link.Naw);

                    link = link.Next;
                }

                Console.WriteLine("\t-- -- ^ -- --");
            }

            Console.WriteLine("-- -- ^ -- --");
        }
    }
}

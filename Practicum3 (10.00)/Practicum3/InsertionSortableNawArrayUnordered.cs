using System;
using Alg1.Practica.Practicum1;
using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Models;
namespace Alg1.Practica.Practicum3
{
    public class InsertionSortableNawArrayUnordered : NawArrayUnordered, IInsertionSort
    {
        public InsertionSortableNawArrayUnordered(int initialSize) : base(initialSize)
        {
        }

        public void InsertionSort()
        {
            for (int itemsSorted = 1; itemsSorted < _used; itemsSorted++)
            {
                NAW itemToBeSorted = _nawArray[itemsSorted];
                int itemIndex = itemsSorted;

                while (itemIndex > 0 && _nawArray[itemIndex-1].CompareTo(itemToBeSorted) > 0)
                {
                    _nawArray[itemIndex] = _nawArray[itemIndex - 1];
                    itemIndex--;
                }

                if (itemIndex != itemsSorted)
                {
                    _nawArray[itemIndex] = itemToBeSorted;
                }
            }
        }

        public void InsertionSortInverted()
        {
            for (int itemsToBeSorted = _used-2; itemsToBeSorted >= 0; itemsToBeSorted--)
            {
                NAW itemToBeSorted = _nawArray[itemsToBeSorted];
                int itemIndex = itemsToBeSorted;

                while (itemIndex < _used-1 && _nawArray[itemIndex + 1].CompareTo(itemToBeSorted) < 0)
                {
                    _nawArray[itemIndex] = _nawArray[itemIndex + 1];
                    itemIndex++;
                }

                if (itemIndex != itemsToBeSorted)
                {
                    _nawArray[itemIndex] = itemToBeSorted;
                }
            }
        }


    }
}

using System;
using Alg1.Practica.Practicum2;
namespace Alg1.Practica.Practicum3
{
    public class AlternativeBubbleSortableNawArrayUnordered : BubbleSortableNawArrayUnordered
    {
        public AlternativeBubbleSortableNawArrayUnordered(int size) : base(size)
        {
        }

        public void BubbleSortAlternative()
        {
            bool didSwap = true;
            int unsorted = _used;
            while (didSwap)
            {
                didSwap = false;
                for (int i = 0; i < unsorted; i++)
                {
                    if (i + 1 < unsorted && _nawArray[i].CompareTo(_nawArray[i + 1]) > 0)
                    {
                        _nawArray.Swap(i, i + 1);
                        didSwap = true;
                    }
                }
                unsorted--;
            }
        }
    }
}

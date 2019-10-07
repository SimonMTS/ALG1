using Alg1.Practica.Practicum1;
using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum2
{
    public class BubbleSortableNawArrayUnordered : NawArrayUnordered, IBubbleSort
    {
        public BubbleSortableNawArrayUnordered(int initialSize) : base(initialSize)
        {
        }

        public void BubbleSort()
        {
            bool didSwap = true;
            int unsorted = _used;
            while (didSwap)
            {
                didSwap = false;
                for (int i = 0; i < unsorted; i++)
                {
                    if (i+1 < unsorted && _nawArray[i].CompareTo(_nawArray[i+1]) > 0)
                    {
                        _nawArray.Swap(i, i+1);
                        didSwap = true;
                    }
                }
                unsorted--;
            }
        }

        public void BubbleSortInverted()
        {
            bool didSwap = true;
            int sorted = 0;
            while (didSwap)
            {
                didSwap = false;
                for (int i = _used - 1; i >= sorted; i--)
                {
                    if (i - 1 >= 0 && _nawArray[i].CompareTo(_nawArray[i - 1]) < 0)
                    {
                        _nawArray.Swap(i, i - 1);
                        didSwap = true;
                    }
                }
                sorted++;
            }
        }
    }
}

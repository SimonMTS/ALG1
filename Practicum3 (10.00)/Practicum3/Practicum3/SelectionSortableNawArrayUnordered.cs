using Alg1.Practica.Practicum1;
using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum3
{
    public class SelectionSortableNawArrayUnordered : NawArrayUnordered, ISelectionSort
    {
        public SelectionSortableNawArrayUnordered(int initialSize) : base(initialSize)
        {
        }

        public void SelectionSort()
        {
            for (int itemsSorted = 0; itemsSorted < _used-1; itemsSorted++)
            {
                int itemIndex = itemsSorted;
                for (int i = itemsSorted+1; i < _used; i++)
                {
                    if (_nawArray[itemIndex].CompareTo(_nawArray[i]) > 0)
                    {
                        itemIndex = i;
                    }
                }

                if (itemIndex != itemsSorted)
                {
                    _nawArray.Swap(itemIndex, itemsSorted);
                }
            }
        }

        public void SelectionSortInverted()
        {
            for (int itemsToBeSorted = _used-1; itemsToBeSorted > 0; itemsToBeSorted--)
            {
                int itemIndex = itemsToBeSorted;
                for (int i = 0; i < itemsToBeSorted; i++)
                {
                    if (_nawArray[itemIndex].CompareTo(_nawArray[i]) < 0)
                    {
                        itemIndex = i;
                    }
                }

                if (itemIndex != itemsToBeSorted)
                {
                    _nawArray.Swap(itemIndex, itemsToBeSorted);
                }
            }
        }
    }
}

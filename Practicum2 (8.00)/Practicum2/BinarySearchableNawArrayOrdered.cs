using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Exceptions;
using Alg1.Practica.Utils.Models;
using Alg1.Practica.Practicum1;
using System;

namespace Alg1.Practica.Practicum2
{
    public class BinarySearchableNawArrayOrdered : NawArrayOrdered, IBinarySearch
    {
        public BinarySearchableNawArrayOrdered(int initialSize) : base(initialSize)
        {
        }

        public int FindBinary(NAW item)
        {
            double[] searchScope = { 0, this.ItemCount() };

            if (searchScope[1] == 0)
            {
                return -1;
            }

            while (true)
            {
                int guess = (int)Math.Floor((searchScope[0] + searchScope[1]) / 2);
                int compare = item.CompareTo(this.ItemAtIndex(guess));

                if (searchScope[1] - searchScope[0] == 1 && compare != 0)
                {
                    return -1;
                } else
                {
                    if (compare == 0)
                    {
                        return guess;
                    }
                    else if (compare < 0)
                    {
                        searchScope[1] -= Math.Floor((searchScope[1] - searchScope[0]) / 2);
                    }
                    else if (compare > 0)
                    {
                        searchScope[0] += Math.Floor((searchScope[1] - searchScope[0]) / 2);
                    }
                }
            }
        }

        public void AddBinary(NAW item)
        {
            if (_used >= _size)
            {
                throw new NawArrayOrderedOutOfBoundsException();
            }

            if ( _used == 0 )
            {
                AddAtIndex(0, item);
                return;
            } else if (_used == 1)
            {
                int index = (item.CompareTo(this.ItemAtIndex(0)) > 0 ? 1 : 0);
                AddAtIndex(index, item);
                return;
            }

            double[] searchScope = { 0, this.ItemCount() };
            while (true)
            {
                int guess = (int)Math.Floor((searchScope[0] + searchScope[1]) / 2);
                int compare = item.CompareTo(this.ItemAtIndex(guess));

                if (searchScope[1] - searchScope[0] == 1 || compare == 0)
                {
                    int index = (guess+compare < 0 ? 0 : guess+compare);
                        //Console.WriteLine("-- --\n'{0}' + '{1}' = '{2}'", guess, compare, index);
                    AddAtIndex(index, item);
                    return;
                }
                else
                {
                    if (compare < 0)
                    {
                        searchScope[1] -= Math.Floor((searchScope[1] - searchScope[0]) / 2);
                    }
                    else if (compare > 0)
                    {
                        searchScope[0] += Math.Floor((searchScope[1] - searchScope[0]) / 2);
                    }
                }
            }
        }

        private void AddAtIndex(int index, NAW item)
        {
            for (int i = _used; i > index; i--)
            {
                _nawArray.Swap(i, i - 1);
            }
            _nawArray[index] = item;
            _used++;
        }

    }
}

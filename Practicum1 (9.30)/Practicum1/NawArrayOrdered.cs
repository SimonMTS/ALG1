using System;
using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Exceptions;
using Alg1.Practica.Utils.Models;


namespace Alg1.Practica.Practicum1
{
    public class NawArrayOrdered : INawArray, INawArrayOrdered
    {
        protected Alg1NawArray _nawArray;

        public Alg1NawArray Array => _nawArray;

        protected int _size;
        protected int _used = 0;

        public NawArrayOrdered(int initialSize)
        {
            if (initialSize < 1 || initialSize > 1000000)
            {
                throw new NawArrayOrderedInvalidSizeException();
            }
            else
            {
                _nawArray = new Alg1NawArray(initialSize);

                _size = initialSize;
            }
        }

        public void Show()
        {
            // Niet gevraagd

            System.Console.WriteLine("Array contains {0} of {1} items.", _used, _size);
            for (int i = 0; i < _size; i++)
            {
                if (i == _used)
                {
                    System.Console.WriteLine("------------------------------------------------------");
                }
                System.Console.Write("Item {0} contains: ", i);
                if (_nawArray[i] != null)
                {
                    _nawArray[i].Show();
                }
                else
                {
                    System.Console.WriteLine("nothing");
                }
            }
        }

        public int Count
        {
            get { return ItemCount(); }
            set { _used = value; }

        }

        public int ItemCount()
        {
            return _used;
        }

        public virtual void Add(NAW item)
        {
            if (_used < _size)
            {
                int insertPos = -1;
                for (int i = 0; i < _used; i++)
                {
                    if (item.CompareTo(_nawArray[i]) == -1)
                    {
                        insertPos = i;
                        break;
                    }
                }

                if (insertPos >= 0)
                {
                    for (int i = _used; i > insertPos; i--)
                    {
                        _nawArray[i] = _nawArray[i - 1];
                    }
                    _nawArray[insertPos] = item;
                    _used++;
                    return;
                } else
                {
                    _nawArray[_used] = item;
                    _used++;
                }
            }
            else
            {
                throw new NawArrayOrderedOutOfBoundsException();
            }
        }

        public void RemoveAtIndex(int index)
        {
            if (index > _used || index < 0)
            {
                throw new NawArrayOrderedInvalidSizeException();
            } else
            {
                _used--;
                for (int i = index; i < _used; i++)
                {
                    _nawArray[i] = _nawArray[i + 1];
                }
                _nawArray[_used] = null;
            }
        }

        public bool Remove(NAW item)
        {
            int index = this.Find(item);

            if (index > 0 && index < _used)
            {
                RemoveAtIndex(index);

                return true;
            } else
            {
                return false;
            }
        }

        public NAW ItemAtIndex(int index)
        {
            if (index <= _used && index >= 0 &&_nawArray[index] != null)
            {
                return _nawArray[index];
            } else
            {
                throw new NawArrayOrderedOutOfBoundsException();
            }
        }


        public int Find(NAW item)
        {
            if (item.CompareTo(_nawArray[0]) < 0 || item.CompareTo(_nawArray[_used-1]) > 0)
            {
                return -1;
            }

            for (int i = 0; i < _used; i++)
            {
                if (item.Equals(_nawArray[i]))
                {
                    return i;
                }
            }

            return -1;
        }

        public bool Update(NAW oldValue, NAW newValue)
        {
            if (Remove(oldValue))
            {
                Add(newValue);

                return true;
            } else
            {
                return false;
            }
        }
    }
}



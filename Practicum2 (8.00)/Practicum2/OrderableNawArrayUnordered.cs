using System;
using Alg1.Practica.Practicum1;
using Alg1.Practica.Utils;

namespace Alg1.Practica.Practicum2
{
    public class OrderableNawArrayUnordered : NawArrayUnordered, IToNawArrayOrdered
    {
        public OrderableNawArrayUnordered(int initialSize) : base(initialSize)
        {
        }

        public INawArrayOrdered ToNawArrayOrdered()
        {
            int length = this.ItemCount();
            NawArrayOrdered orderedArray = new NawArrayOrdered(length);

            for (int i = 0; i < length; i++)
            {
                orderedArray.Add( this.ItemAtIndex(i) );
            }

            return orderedArray;
        }
    }
}

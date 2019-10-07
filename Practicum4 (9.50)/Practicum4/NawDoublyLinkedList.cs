using System;
using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum4
{
    public class NawDoublyLinkedList
    {
        public DoubleLink First { get; set; }
        public DoubleLink Last { get; set; }

        public void InsertHead(NAW naw)
        {
            if (First == null)
            {
                DoubleLink head = new DoubleLink()
                {
                    Naw = naw,
                    Next = null,
                    Previous = null
                };

                First = head;
                Last = head;
            }
            else
            {
                DoubleLink oldHead = First;

                DoubleLink newHead = new DoubleLink()
                {
                    Naw = naw,
                    Next = oldHead,
                    Previous = null
                };

                oldHead.Previous = newHead;

                First = newHead;
            }
        }

        public NAW ItemAtIndex(int index)
        {
            throw new System.NotImplementedException();
        }

        public DoubleLink SwapLinkWithNext(DoubleLink link)
        {
            if (link == Last) return null;

            DoubleLink linkA = link;
            DoubleLink linkB = link.Next;

            // change first/last if applicable
            {
                if (linkA.Previous == null)
                {
                    First = linkB;
                }
                else if (linkB.Previous == null)
                {
                    First = linkA;
                }

                if (linkA.Next == null)
                {
                    Last = linkB;
                }
                else if (linkB.Next == null)
                {
                    Last = linkA;
                }
            }

            // swap link references
            DoubleLink tempAprev = linkA.Previous;

            linkA.Next = linkB.Next;
            linkA.Previous = linkB;

            linkB.Next = linkA;
            linkB.Previous = tempAprev;

            // set adjacent link references
            if (linkB.Previous != null)
            {
                linkB.Previous.Next = linkB;
            }
            if (linkA.Next != null)
            {
                linkA.Next.Previous = linkA;
            }

            return linkB;
        }

        public void BubbleSort()
        {
            bool didSwap = true;
            while (didSwap)
            {
                didSwap = false;
                DoubleLink link = First;
                while (link != null && link.Next != null)
                {
                    if (link.Naw.CompareTo(link.Next.Naw) > 0)
                    {
                        SwapLinkWithNext(link);
                        didSwap = true;
                    }

                    link = link.Next;
                }
            }
        }

        public BigO OrderOfBubbleSort()
        {
            return BigO.N2;
        }
    }
}

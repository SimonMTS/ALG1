using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum5
{
    public class Stack : IStack
    {
        protected StackLink First { get; set; }

        public void Push(string value)
        {
            if (First == null)
            {
                StackLink head = new StackLink()
                {
                    String = value,
                    Next = null
                };

                First = head;
            }
            else
            {
                StackLink oldHead = First;

                StackLink newHead = new StackLink()
                {
                    String = value,
                    Next = oldHead
                };

                First = newHead;
            }
        }

        public string Pop()
        {
            if (IsEmpty())
            {
                return null;
            }

            StackLink oldHead = First;

            First = oldHead.Next;

            return oldHead.String;
        }

        public string Peek()
        {
            return (First == null ? null : First.String);
        }

        public bool IsEmpty()
        {
            return First == null;
        }
    }
}

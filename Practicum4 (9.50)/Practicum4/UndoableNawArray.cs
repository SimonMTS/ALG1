using System;
using System.Runtime.Remoting.Messaging;
using Alg1.Practica.Practicum1;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum4
{
    public class UndoableNawArray : NawArrayOrdered
    {

        public UndoLink First { get; private set; }
        public UndoLink Current { get; private set; }

        public UndoableNawArray(int size)
            : base(size)
        {
            First = null;
            Current = null;
        }

        public override void Add(NAW item)
        {
            base.Add(item);
            AddOperation(Operation.Add, item);
        }

        private bool DoRemove(NAW naw)
        {
            var index = Find(naw);
            if (index < 0)
                return false;
            RemoveAtIndex(index);
            return true;
        }

        public override bool Remove(NAW item)
        {
            if (!DoRemove(item))
                return false;
            AddOperation(Operation.Remove, item);
            return true;
        }

        public void Undo()
        {
            if (Current != null)
            {
                ReverseOperation(Current);

                if (Current.Previous != null)
                {
                    Current = Current.Previous;
                } else
                {
                    Current = null;
                }
            }
        }

        public void Redo()
        {
            if (Current != null && Current.Next != null)
            {
                ApplyOperation(Current.Next);

                Current = Current.Next;
            }
            else if (Current == null)
            {
                ApplyOperation(First);

                Current = First;
            }
        }

        private void AddOperation(Operation operation, NAW naw)
        {
            UndoLink link = new UndoLink()
            {
                Naw = naw,
                Operation = operation
            };

            if (First == null)
            {
                link.Next = null;
                link.Previous = null;

                First = link;
            }
            else
            {
                link.Next = null;
                link.Previous = Current;

                Current.Next = link;
            }

            Current = link;
        }

        private void ApplyOperation(UndoLink link)
        {
            switch (link.Operation)
            {
                case Operation.Add:
                    base.Add(link.Naw);
                    break;

                case Operation.Remove:
                    DoRemove(link.Naw);
                    break;
            }
        }

        private void ReverseOperation(UndoLink link)
        {
            switch (link.Operation)
            {
                case Operation.Add:
                    DoRemove(link.Naw);
                    break;

                case Operation.Remove:
                    base.Add(link.Naw);
                    break;
            }
        }
    }
}

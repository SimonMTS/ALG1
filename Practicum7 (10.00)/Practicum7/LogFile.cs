using System;
using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Models;


namespace Alg1.Practica.Practicum7
{
    public class LogFile : INawDictionary
    {
        protected LogFileLink Head { get; set; }

        public virtual void Insert(string key, NAW value)
        {
            if (key == null)
            {
                throw new ArgumentNullException();
            }

            LogFileLink tmp = Head;

            Head = new LogFileLink(key, value, tmp);
        }

        public virtual NAW Find(string key)
        {
            if (key == null)
            {
                return null;
            }

            LogFileLink link = Head;
            while (link != null)
            {
                if (link.Key == key)
                {
                    return link.Value;
                }

                link = link.Next;
            }

            return null;
        }

        public virtual NAW Delete(string key)
        {
            if (key == null)
            {
                return null;
            }

            LogFileLink link = Head;
            LogFileLink prevLink = null;
            while (link != null)
            {
                if (link.Key == key)
                {
                    NAW naw = link.Value;

                    Remove(link, prevLink);

                    return naw;
                }

                prevLink = link;
                link = link.Next;
            }

            return null;
        }

        private void Remove(LogFileLink link, LogFileLink prevLink)
        {
            if (link.Equals(Head))
            {
                Head = link.Next;
                return;
            }

            prevLink.Next = link.Next;
        }

        public void Show()
        {
            LogFileLink link = Head;
            while (link != null)
            {
                Console.WriteLine(link.Key + ": " + link.Value);

                link = link.Next;
            }
        }
    }

}

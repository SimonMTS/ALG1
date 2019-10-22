using System;
using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum7
{
    public class NawDictionary : INawDictionary
    {
        public int Size { get; }
        private int _used = 0;
        protected LogFile[] logFiles;

        public NawDictionary(int size)
        {
            Size = size;
            logFiles = new LogFile[size];
            for (int i = 0; i < logFiles.Length; ++i)
                logFiles[i] = new LogFile();
        }

        protected int KeyToIndex(string key)
        {
            if (key == null)
            {
                throw new ArgumentNullException();
            }

            int index = (int)Math.Abs((decimal)key.GetHashCode() / Int32.MaxValue * Size);

            return index;
        }

        public void Insert(string key, NAW value)
        {
            if (key == null)
            {
                throw new ArgumentNullException();
            }

            int index = KeyToIndex(key);

            logFiles[index].Insert(key, value);
            _used++;
        }

        public NAW Find(string key)
        {
            if (key == null)
            {
                throw new ArgumentNullException();
            }

            int index = KeyToIndex(key);

            return logFiles[index].Find(key);
        }

        public NAW Delete(string key)
        {
            if (key == null)
            {
                throw new ArgumentNullException();
            }

            int index = KeyToIndex(key);
            NAW naw = logFiles[index].Delete(key);

            if (naw != null)
            {
                _used--;
            }

            return naw;
        }


        public int Count
        {
            get
            {
                return _used;
            }
        }

        public double LoadFactor
        {
            get
            {
                return (double)_used / Size;
            }
        }

        public void Show()
        {
            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine("-- -- v -- -- " + i);
                logFiles[i].Show();
                Console.WriteLine("-- -- ^ -- --\n");
            }
        }
    }
}

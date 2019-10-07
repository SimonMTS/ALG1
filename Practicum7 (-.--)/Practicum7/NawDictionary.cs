using System;
using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum7
{
    public class NawDictionary : INawDictionary
    {
        public int Size { get; }
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
            throw new System.NotImplementedException();
        }



        public void Insert(string key, NAW value)
        {
            throw new System.NotImplementedException();
        }

        public NAW Find(string key)
        {
            throw new System.NotImplementedException();
        }

        public NAW Delete(string key)
        {
            throw new System.NotImplementedException();
        }


        public int Count
        {
            get
            {
            throw new System.NotImplementedException();
            }
        }

        public double LoadFactor
        {
            get
            {
            throw new System.NotImplementedException();
            }
        }
    }
}

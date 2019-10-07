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
            throw new System.NotImplementedException();
        }

        public virtual NAW Find(string key)
        {
            throw new System.NotImplementedException();
        }

        public virtual NAW Delete(string key)
        {
            throw new System.NotImplementedException();
        }
    }

}

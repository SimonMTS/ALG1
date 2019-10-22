using System;

namespace Alg1.Practica.Practicum7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            NawDictionary dict = new NawDictionary(10);

            dict.Insert("a", new Utils.Models.NAW("0", "0", "0"));
            dict.Insert("bb", new Utils.Models.NAW("0", "0", "1"));
            dict.Insert("ccc", new Utils.Models.NAW("0", "0", "2"));
            dict.Insert("dddd", new Utils.Models.NAW("0", "0", "3"));
            dict.Insert("eeeee", new Utils.Models.NAW("0", "0", "4"));
            //dict.Insert("fffff", new Utils.Models.NAW("0", "0", "5"));
            //dict.Insert("gggggg", new Utils.Models.NAW("0", "0", "6"));
            //dict.Insert("hhhhhhh", new Utils.Models.NAW("0", "0", "7"));
            //dict.Insert("iiiiiiii", new Utils.Models.NAW("0", "0", "8"));
            //dict.Insert("jjjjjjjjj", new Utils.Models.NAW("0", "0", "9"));

            //Console.WriteLine(dict.Find("a"));

            //dict.Show();

            Console.WriteLine( dict.LoadFactor );
            Console.ReadKey();
        }
    }
}

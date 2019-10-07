using System;
using System.Linq;
using Alg1.Practica.Utils.Logging;
using Alg1.Practica.Utils.Models;
namespace Alg1.Practica.Practicum2
{
    public class MainClass
    {
        public static void Main(String[] args)
        {
            //PerformanceTest.TestSortPerformance();

            BinarySearchableNawArrayOrdered array = new BinarySearchableNawArrayOrdered(100);

            for (int i = 1; i < 100; i++)
            {
                Logger.Instance.ClearLog();
                array.AddBinary(new NAW("Persona 0", "Adres 0", "Woonplaats "+i));
            }

            Logger.Instance.ClearLog();
            array.AddBinary(new NAW("Persona 0", "Adres 0", "Woonplaats 0"));

            var actualSearches = Logger.Instance.LogItems.Where(li => li.ArrayAction == ArrayAction.GET).Count();
            array.Show();
            Console.WriteLine("\n"+actualSearches);

            Console.ReadLine();
        }


    }
}

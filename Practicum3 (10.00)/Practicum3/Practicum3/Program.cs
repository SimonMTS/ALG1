using Alg1.Practica.Utils.Logging;
using Alg1.Practica.Utils.Models;
using System;
using System.Linq;

namespace Alg1.Practica.Practicum3
{
    class Program
    {
        public static void Main(string[] args)
        {
            //PerformanceTest.TestSortPerformance();

            SelectionSortableNawArrayUnordered array = new SelectionSortableNawArrayUnordered(10);
            array.Add(new NAW("Persoon 0", "Adres 0", "Woonplaats 9"));
            array.Add(new NAW("Persoon 0", "Adres 0", "Woonplaats 0"));
            array.Add(new NAW("Persoon 0", "Adres 0", "Woonplaats 1"));
            array.Add(new NAW("Persoon 0", "Adres 0", "Woonplaats 2"));
            array.Add(new NAW("Persoon 0", "Adres 0", "Woonplaats 3"));
            array.Add(new NAW("Persoon 0", "Adres 0", "Woonplaats 4"));
            array.Add(new NAW("Persoon 0", "Adres 0", "Woonplaats 5"));
            array.Add(new NAW("Persoon 0", "Adres 0", "Woonplaats 6"));
            array.Add(new NAW("Persoon 0", "Adres 0", "Woonplaats 7"));
            array.Add(new NAW("Persoon 0", "Adres 0", "Woonplaats 8"));

            array.Show();
            //Logger.Instance.ClearLog();

            //array.SelectionSort();
            array.SelectionSortInverted();

            var asd = Logger.Instance.LogItems.Where(li => li.ArrayAction == ArrayAction.COMPARE).Count();

            Console.WriteLine("\n");
            array.Show();
            Console.WriteLine("\n");

            Console.WriteLine(asd);

            Console.ReadLine();
        }
    }
}

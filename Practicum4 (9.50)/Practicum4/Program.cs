using Alg1.Practica.Utils.Logging;
using Alg1.Practica.Utils.Models;
using System;

namespace Alg1.Practica.Practicum4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            {
                //UndoableNawArray array = new UndoableNawArray(10);

                //for (int i = 0; i < 1; i++)
                //{
                //    array.Add(new NAW("0", "0", "" + i));
                //}

                //array.Remove(new NAW("0", "0", "0"));

                //array.Undo();
                //array.Redo();

                //array.Show();
                //Console.WriteLine("\n\n");

                //UndoLink link = array.First;
                //while (link != null)
                //{
                //    if (link == array.Current)
                //    {
                //        Console.Write("-> ");
                //    }

                //    Console.WriteLine(link.Operation + "\t - " + link.Naw);

                //    link = link.Next;
                //}
            }

            {
                NawDoublyLinkedList list = new NawDoublyLinkedList();

                for (int i = 0; i < 10; i++)
                {
                    list.InsertHead(new Utils.Models.NAW("0", "0", ""+i));
                }

                {
                    DoubleLink link = list.First;
                    while (link != null)
                    {
                        if (link == list.First)
                        {
                            Console.Write("-> ");
                        }
                        if (link == list.Last)
                        {
                            Console.Write("<- ");
                        }

                        Console.WriteLine(link.Naw);

                        link = link.Next;
                    }
                }

                Console.WriteLine("\n");
                list.BubbleSort();
                Console.WriteLine("\n");

                {
                    DoubleLink link = list.First;
                    while (link != null)
                    {
                        if (link.Previous == null)
                        {
                            Console.Write("-> ");
                        }
                        if (link.Next == null)
                        {
                            Console.Write("<- ");
                        }

                        Console.WriteLine(link.Naw);

                        link = link.Next;
                    }
                }


                Console.WriteLine("\n");
            }
            Console.ReadKey();

        }


    }
}

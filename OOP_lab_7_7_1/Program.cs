using System;

namespace OOP_lab_7_7_1
{
    class Program
    {
        public static Trees garden;

        static void Main(string[] args)
        {
            new IO().Read();

            new IO().Write();

            Array.Sort(garden.trees);

            Console.WriteLine();

            new IO().Write();

            Array.Sort(garden.trees, new Tree.SortByHeight());

            Console.WriteLine();

            new IO().Write();

            Array.Sort(garden.trees, new Tree.SortByPrice());

            Console.WriteLine();

            new IO().Write();
        }
    }
}

using System;
using System.IO;

namespace OOP_lab_7_7_1
{
    class IO : IReadWrite
    {
        public const string Format = "{0, -15} {1, -15} {2, -15} {3, -20} {4, -20}";

        public void Read()
        {
            StreamReader file = new StreamReader("base.txt");

            Program.garden = new Trees(file.ReadToEnd().Split("\r\n", StringSplitOptions.RemoveEmptyEntries));

            file.Close();
        }

        public void Write()
        {
            Console.WriteLine(Format, "Порода", "Цiна", "Висота", "Плодоноснiсть", "Кiлькiсть");

            foreach (Tree tree in Program.garden)
            {
                Console.WriteLine(Format, tree.Type, tree.Price, tree.Height, tree.Fruitfulness.ToString(), tree.Count);
            }
        }
    }
}

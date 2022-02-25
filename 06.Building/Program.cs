using System;

namespace _06.Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            for (int floor = floors; floor > 0; floor--)
            {
                for (int room = 0; room < rooms; room++)
                {
                    if (floor == floors)
                    {
                        Console.Write($"L{floor}{room} ");
                        continue;
                    }
                    if (floor % 2 == 0)
                    {
                        Console.Write($"O{floor}{room} ");
                    }
                    else
                    {
                        Console.Write($"A{floor}{room} ");
                    }
                }
                Console.WriteLine();
            }
            //Output : L60 L61 L62 L63
            // A50 A51 A52 A53
            // O40 O41 O42 O43
            // A30 A31 A32 A33
            // O20 O21 O22 O23
            // A10 A11 A12 A13
        }
    }
}

using System;

namespace MagicNum
{
    class Program
    {
        static void Main(string[] args)
        {           
            int start = int.Parse(Console.ReadLine());//1 23
            int end = int.Parse(Console.ReadLine());//10 24
            int magicNum = int.Parse(Console.ReadLine());//5 20
            int counter = 0;
            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    counter++;
                    if (i + j == magicNum)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicNum})");//Combination N:4 (1 + 4 = 5)
                        return;                     
                    }
                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {magicNum}");//4 combinations - neither equals 20
        }
    }
}


using System;

namespace Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            //x1 + x2 + x3 = n
            int c = int.Parse(Console.ReadLine());
            int validCombination = 0;
            for (int i = 0; i <= c; i++)
            {
                for (int ii = 0; ii <= c; ii++)
                {
                    for (int iii = 0; iii <= c; iii++)
                    {
                        if (i + ii + iii == c)
                        {
                            validCombination++;
                        }
                    }
                }
            }
            Console.WriteLine(validCombination);
        }
    }
}

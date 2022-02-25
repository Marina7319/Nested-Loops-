using System;

namespace multiplying
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 10; i++)
            {
               
                for (int ii = 1; ii <= 10; ii++)
                {
                    Console.WriteLine($"{i} * {ii} = {i * ii}");
                }
            }
            //Output: 1 * 1 = 1
            //  1 * 2 = 2
            //1 * 3 = 3
            //1 * 4 = 4
            //1 * 5 = 5
            //...
            //10 * 4 = 40
            //10 * 5 = 50
            //10 * 6 = 60
            //10 * 7 = 70
            //10 * 8 = 80
            //10 * 9 = 90
            //10 * 10 = 100
        }
    }
}

using System;
using System.Threading;

namespace и
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int hour = 0; hour <= 23; hour++)
            {
                for (int min = 0; min < 60; min++)
                {
                    Console.WriteLine($"{hour}:{min}");
                }
                //Output :
                //00 : 00
                //00 : 01
                //00 : 02
                //00 : 03
                //00 : 04
                //00 : 05
                //...
                //22 : 26
                //22 : 27
                //22 : 28
                //22 : 29
                //22 : 30
            }
        }
    }
}

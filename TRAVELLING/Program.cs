using System;

namespace TRAVELLING
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("");

            string destination = Console.ReadLine();
            //double savings = 0; 
            while(destination != "End")
            {
                double sumMoney = double.Parse(Console.ReadLine());
                double savings = 0; 
                while(savings < sumMoney)
                {
                    savings += double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}

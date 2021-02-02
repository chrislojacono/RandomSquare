using System;
using System.Collections.Generic;

namespace RandomSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var assortedList = new List<int>();

            for (int ctr = 0; ctr <= 19; ctr++)
                assortedList.Add(random.Next(1, 50));

            foreach (var item in assortedList)
            {
                Console.WriteLine($"{item}");
            }
            
        }
    }
}

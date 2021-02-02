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

            var finalList = new List<int>();
            foreach (var item in assortedList)
            {
                var squaredValue = item * item;
                finalList.Add(squaredValue);
            }
            foreach (var item in finalList)
            {
                Console.WriteLine($"{item}");
            }
            //Removes all odd integers. The for each wont work because you are modifiying the list as you go through it 

            finalList.RemoveAll((i) => i % 2 != 0);

            foreach (var item in finalList)
            {
                Console.WriteLine($"{item}");
            }

        }
    }
}

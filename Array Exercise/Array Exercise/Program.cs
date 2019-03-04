using System;

namespace Array_Exercise
{
    class Program
    {
        static void Main (string[] args)
        {
            int size = 1000;
            Random rand = new Random();
            int[] numbers = new int[size];
            double[] Doublenumbers = new double[size];

            Console.WriteLine("Integers\t\tDoubles");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(1000, 10000);
                Doublenumbers[i] = rand.NextDouble() * 10;
                Console.WriteLine(numbers[i] + "\t\t" + Doublenumbers[i]);
                

               
            }
            Console.ReadLine();
            
            
        }

        
    }

}
//Create an array of 1000 random doubles that range from 0 - 10 and display the entire data set to the user with only 10 elements per row.
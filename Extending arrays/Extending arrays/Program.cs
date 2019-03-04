using System;

namespace Extending_arrays
{
    class Program
    {
        static void Main(string[] args)
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

            double[] apple = new double[size];

            Array.Copy(Doublenumbers, apple, 1000);
            //Doublenumbers.CopyTo(apple, 0);

            foreach(double x in apple)
                Console.Write(x + " ");


            Console.ReadLine();



        }
    }
}
//Extend the previous application so that creates another array and copies the contents of the original array to the new one.Now add the functionality so that it uses a LINQ query to find all of the numbers greater than 2 in the copied data set and display them to the user.

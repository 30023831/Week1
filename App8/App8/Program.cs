using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomNum = new int[1000];
            Random RandomNumber = new Random();


            for (int i = 0; i < 1000; i++)
            {
                randomNum[i] = RandomNumber.Next(1, 1000);
            }


            foreach (int j in randomNum)
            {
                Console.WriteLine("First Number:{0}", j);
                Console.Read();
            }

        }

    }
}

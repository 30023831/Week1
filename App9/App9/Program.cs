using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App9
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("****Random 3 digits*****");

            Random rand = new Random();
            for (int ctr = 0; ctr <= 100; ctr++)
            {
                //Console.WriteLine("{0,4:N0}",rand.Next(100, 1000));
                //Console.Write("*****Random Numbers******");
                Console.Write(rand.Next(100, 1000));
                Console.Write(" ");

            }
                       
            Console.ReadLine();
        }

    }

}
                        
        
        
            


        

        
    


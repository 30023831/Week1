using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[5] { 1, 2, 3, 4, 5 };
            int[] copy = new int[10];
            nums.CopyTo(copy, 5);
            foreach(int x in copy)
                Console.WriteLine(x);

            Array.Copy(nums, copy, 5);
            foreach (int x in copy)
                Console.WriteLine(x);
        }
    }
}

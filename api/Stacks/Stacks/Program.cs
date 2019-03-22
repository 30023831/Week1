using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s1 = new Stack();
            string tryAgain = "";
            while (tryAgain != "n")
            {
                Console.Write("Would you like to add an item(y/n): ");
                tryAgain = Console.ReadLine().ToLower();
                if (tryAgain == "y")
                {
                    Console.Write("Please enter something: ");
                    s1.Push(Console.ReadLine());
                }
                else
                    break;
            }
            /*Using the Count property to veiw the number of elements in the stack*/
            Console.WriteLine("\n... Count ...");
            Console.WriteLine("Count: " + s1.Count);
            Console.Write("What would you like to look for: ");
            string usercheck = Console.ReadLine();
           bool check = false;

            if (s1.Contains(usercheck))
                check = true;

            while (check)
            {
                if (s1.Peek().ToString() != usercheck)
                {
                    Console.WriteLine(s1.Pop()+" Removed");
                }
                else if(s1.Peek().ToString() == usercheck)
                {
                    Console.WriteLine("Item found.");
                    check = false;
                }
            }
            Console.WriteLine("Program finnished...");
            Console.ReadLine();
        }

        
            
    }
}

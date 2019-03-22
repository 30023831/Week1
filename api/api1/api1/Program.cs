using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            string json = new WebClient().DownloadString("https://uinames.com/api/?ext&amount=500");

            //Console.WriteLine(json);
            //Console.ReadLine();
            //Console.Clear();

            List<Person> lst = new JavaScriptSerializer().Deserialize<List<Person>>(json);

            foreach (Person x in lst)
            {
                Console.WriteLine($"Name: {x.name}\nAge: {x.age}");
            }
            Console.ReadLine();
        }

    }


    public class Person
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string gender { get; set; }
        public string region { get; set; }
        public int age { get; set; }
        public string title { get; set; }
        public string phone { get; set; }
        public Birthday birthday { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public CreditCard credit_card { get; set; }
        public string photo { get; set; }

    }
    public class Birthday
    {
        public string dmy { get; set; }
        public string mdy { get; set; }
        public int raw { get; set; }

    }
    public class CreditCard

    {
        public string expiration { get; set; }
        public string number { get; set; }
        public int pin { get; set; }
        public int security { get; set; }
    }

}

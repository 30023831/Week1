using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Please Enter Your Name");
            string name = Console.ReadLine();

            Console.Write("Enter your age ");
            int age = Convert.ToInt32(Console.ReadLine());

            Person p1 = new Person();
            p1.Age = age;
            p1.Name = name;

            Console.WriteLine("Age: " + p1.Age + "\nName: " + p1.Name);

            Console.ReadLine();*/

            Person[] people = new Person[2];

            Student s1 = new Student();
            Console.WriteLine("Please Enter Your Name");
            s1.Name = Console.ReadLine();
            Console.Write("Enter your age ");
            s1.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your student ID");
            s1.StID = Convert.ToInt32(Console.ReadLine());

            people[0] = s1;

            Teacher t1 = new Teacher();
            Console.WriteLine("Please Enter Your Name");
            t1.Name = Console.ReadLine();
            Console.Write("Enter your age ");
            t1.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your username");
            t1.UserName = Console.ReadLine();

            people[1] = t1;

            foreach(Person person in people)
            {
                Console.WriteLine(person.Name + " " + person.Age);
            }

            Console.ReadKey();
        }

        class Person
        {
            ///*Atribute*/
            //private int number;
            ///*getter and setter*/
            //public int Number
            //{
            //    private get { return number; }
            //    set { number = value; }
            //}

            public int Age { get; set; }
            public string Name { get; set; }

        }

        class Teacher : Person
        {
            public string UserName { get; set; }
        }

        class Student : Person
        {
            public int StID { get; set; }
        }

    }
}
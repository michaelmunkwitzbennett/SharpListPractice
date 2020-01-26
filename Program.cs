using System;
using System.Collections.Generic;

namespace SharpListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Teacher t1 = new Teacher();
            List<Person> people = new List<Person>();

            int option = 1;

            while (option != 3)
            {
                Console.WriteLine("Please enter a [1 - Student | 2 - Teacher | 3 - End]: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        people.Add(s1.Create());
                        break;
                    case 2:
                        people.Add(t1.Create());
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Invalid entry, Try again...");
                        break;
                }
            }
            foreach (Person p in people)
            {
                p.Print();
            }
        }
    }
}

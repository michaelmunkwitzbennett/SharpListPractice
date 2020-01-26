using System;
using System.Collections.Generic;
using System.Text;

namespace SharpListPractice
{
    class Student: Person
    {
        public int CreditsEarned { get; set; }

        public override void Print()
        {
            Console.WriteLine($"{ID:D6} {Name} {Age} {Program} - {CreditsEarned}");
        }

        public override Person Create()
        {
            Student s1 = new Student();
            Console.Write("Name: ");
            s1.Name = Console.ReadLine();
            Console.Write("Age: ");
            s1.Age = int.Parse(Console.ReadLine());
            Console.Write("ID: ");
            s1.ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Program [1 - Computer Science | 2 - Accounting | 3 - Marketing | 4 - Nursing]: ");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    s1.Program = EnrolledProgram.ComputerScience;
                    break;
                case 2:
                    s1.Program = EnrolledProgram.Accounting;
                    break;
                case 3:
                    s1.Program = EnrolledProgram.Marketing;
                    break;
                case 4:
                    s1.Program = EnrolledProgram.Nursing;
                    break;
                default:
                    s1.Program = EnrolledProgram.ComputerScience;
                    Console.WriteLine("Invalid input, defaulted to COMPUTER SCIENCE");
                    break;
            }
            Console.Write("Credis Earned: ");
            s1.CreditsEarned = int.Parse(Console.ReadLine());

            return s1;
        }
    }
}

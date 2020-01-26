using System;
using System.Collections.Generic;
using System.Text;

namespace SharpListPractice
{
    class Teacher: Person
    {
        public int YearsOfService { get; set; }

        public override void Print()
        {
            Console.WriteLine($"{ID:D6} {Name} {Age} {Program} - {YearsOfService}");
        }

        public override Person Create()
        {
            Teacher t1 = new Teacher();
            Console.Write("Name: ");
            t1.Name = Console.ReadLine();
            Console.Write("Age: ");
            t1.Age = int.Parse(Console.ReadLine());
            Console.Write("ID: ");
            t1.ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Program [1 - Computer Science | 2 - Accounting | 3 - Marketing | 4 - Nursing]: ");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    t1.Program = EnrolledProgram.ComputerScience;
                    break;
                case 2:
                    t1.Program = EnrolledProgram.Accounting;
                    break;
                case 3:
                    t1.Program = EnrolledProgram.Marketing;
                    break;
                case 4:
                    t1.Program = EnrolledProgram.Nursing;
                    break;
                default:
                    t1.Program = EnrolledProgram.ComputerScience;
                    Console.WriteLine("Invalid input, defaulted to COMPUTER SCIENCE");
                    break;
            }
            Console.Write("Years of Service: ");
            t1.YearsOfService = int.Parse(Console.ReadLine());

            return t1;
        }
    }
}

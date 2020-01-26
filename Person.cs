using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SharpListPractice
{
    enum EnrolledProgram
    {
        [Display(Name = "Computer Science")]
        ComputerScience,
        [Display(Name = "Accounting")]
        Accounting,
        [Display(Name = "Marketing")]
        Marketing,
        [Display(Name = "Nursing")]
        Nursing
    }

    abstract class Person
    {
        public String Name { get; set; }

        public int Age { get; set; }

        public int ID { get; set; }

        public EnrolledProgram Program { get; set; }

        public abstract void Print();
        public abstract Person Create();
    }
}

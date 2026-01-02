using Assignment4.Abstractions;
using Assignment4.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4.Classes
{
    public class Teachers : Users
    {
        public decimal Salary { get; set; } = 500;
        public Teachers(int id, string name, int age, decimal numberof_subjects) : base(id, name, age, numberof_subjects)
        {

        }
        public Teachers(int id, string name, int age) : base(id, name, age)
        {

        }

        public override decimal Calculate()
        {

            Salary += NumberOf_Subjects * 100;
            return Salary;
        }

        public override void info()
        {
            Console.WriteLine($" Teachers  , Id :  {Id} , Name : {Name} , Age : {Age} ,Salary :  {Salary}");

        }
    }
}

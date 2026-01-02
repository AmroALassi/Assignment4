using Assignment4.Abstractions;
using Assignment4.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4.Classes
{
    public class Students:Users
    {
        public Students(int id, string name, int age, decimal numberof_subjects) : base(id, name, age)
        {

            NumberOf_Subjects=numberof_subjects;
        }
        public Students(int id, string name, int age) : base(id, name, age)
        {
           
        }


        public decimal fees { set; get; } = 250;

        public override decimal Calculate()
        {
            if(NumberOf_Subjects == 0)
            {
                return fees;
            }
            else
            {
                fees = NumberOf_Subjects * 150;

            }

            return fees;

        }
      

        public override void info()
        {
            Console.WriteLine($" Students ,   Id : {Id} , Name : {Name} , Age : {Age} , Fees :  {fees}");
        }
    }
}

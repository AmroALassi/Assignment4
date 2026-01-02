using Assignment4.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4.Abstractions
{
    public abstract class Users:IUserSystem
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal NumberOf_Subjects { get; set; } = 0;
        public Users(int id, string name, int age, decimal numberof_subjects)
        {
            Id = id;
            Name = name;
            Age = age;
            NumberOf_Subjects = numberof_subjects;
        }

        public Users(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public abstract void info();

        public virtual decimal Calculate()
        {
            throw new NotImplementedException();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Student : Person
    {
        public Student()
        {
        }

        public Student(string firstName, string lastName, DateTime birthDate, int index) : base(firstName, lastName, birthDate)
        {
            Index = index;
        }

        public int Index { get; set; }
        
        public override string GetFullName()
        {
            return base.GetFullName() + " " + Index;
        }
    }
}
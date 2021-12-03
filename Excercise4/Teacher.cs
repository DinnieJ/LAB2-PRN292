using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excercise4
{
    abstract class Teacher
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public Teacher()
        {

        }

        public Teacher(string Code, string Name)
        {
            this.Code = Code;
            this.Name = Name;
        }

        public override string ToString()
        {
            return $"{Code}\t\t|{Name}\t\t|{this.GetType().Name}\t\t|{GetSalary()}\t\t";
        }

        public abstract int GetSalary();
    }
}

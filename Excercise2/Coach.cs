using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excercise2
{
    class Coach : Staff
    {
        private int year;

        public Coach()
        {
        }

        public Coach(int code, string name, string address, int salary, int year, string position)
        : base(code, name, address, salary, position)
        {
            this.year = year;
        }

        public int Year { get => year; set => year = value; }

        public override string ToString()
            => base.ToString() + $"Year:{year}";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excercise2
{
    class Staff
    {
        protected int code;
        protected string name;
        protected string address;
        protected int salary;
        protected string position;

        public Staff()
        {
        }
        public Staff(int code, string name, string address, int salary, string position)
        {
            this.code = code;
            this.name = name;
            this.address = address;
            this.salary = salary;
            this.position = position;
        }

        public int Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public int Salary { get => salary; set => salary = value; }
        public string Position { get => position; set => position = value; }

        public override string ToString()
        {
            return "Code: " + code + ", Name: " + name + ", Address: " + address + ", Salary: " + salary + ", Position: " + position;
        }
    }
}


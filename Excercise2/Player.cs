using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excercise2
{
    class Player : Staff
    {
        private int number;

        public Player()
        {
        }

        public Player(int code, string name, string address, int salary, int number, string position)
        : base(code, name, address, salary, position)
        {
            this.number = number;
        }

        public int Number { get => number; set => number = value; }

        public override string ToString()
            => base.ToString() + $"Number: {number}";
    }
}

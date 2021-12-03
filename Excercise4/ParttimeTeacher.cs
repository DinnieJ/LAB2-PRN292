using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excercise4
{
    class ParttimeTeacher : Teacher
    {
        public int Slot { get; set; }
        public ParttimeTeacher() : base() { }

        public ParttimeTeacher(string code, string name, int slot) : base(code, name)
        {
            this.Slot = slot;
        }
        public override int GetSalary()
        {
            return Slot * 50000;
        }
    }
}

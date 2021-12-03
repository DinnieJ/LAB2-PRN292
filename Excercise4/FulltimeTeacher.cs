using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Excercise4
{
    class FulltimeTeacher : Teacher
    {
        public int SalaryCoefficent { get; set; }
        public FulltimeTeacher() : base() { }

        public FulltimeTeacher(string code, string name, int SalaryCoefficent) : base(code, name)
        {
            this.SalaryCoefficent = SalaryCoefficent;
        }
        public override int GetSalary()
        {
            return SalaryCoefficent * 2000000;
        }

        public string FirstName
        {
            get { return Regex.Split(Name.Trim(), @"\s+").Last(); }
        }

        public string LastName
        {
            get { return Regex.Split(Name.Trim(), @"\s+").First(); }
        }
    }
}

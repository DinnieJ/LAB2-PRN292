using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Excercise3
{
    class Employee
    {
        private string _code;

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private DateTime _dob;

        public string DateOfBirth
        {
            get { return _dob.ToString("dd/MM/yyyy"); }
            set { _dob = DateTime.ParseExact(value, "dd/MM/yyyy", CultureInfo.InvariantCulture); }
        }

        private GenderType _gender;

        public GenderType Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        private int _noOfChildren;

        public int NoOfChildren
        {
            get { return _noOfChildren; }
            set { _noOfChildren = value; }
        }

        private double _salary;

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public Employee()
        {

        }

        public Employee(string Code, string Name, string Dob, GenderType Gender, int NoOfChildren, double Salary)
        {
            this._code = Code;
            this._name = Name;
            this.DateOfBirth = Dob;
            this._gender = Gender;
            this._noOfChildren = NoOfChildren;
            this._salary = Salary;
        }

        public bool IsGettingAllowance()
        {
            return _noOfChildren == 0;
        }

        public int Age
        {
            get
            {
                DateTime zeroTime = new DateTime(1, 1, 1);
                TimeSpan diff = DateTime.Now - this._dob;
                return (zeroTime + diff).Year - 1;
            }
        }

        public double Income
        {
            get
            {
                return this._salary + (
                    this._noOfChildren == 0
                    ? 0
                    : this._noOfChildren <= 2
                    ? 1000000
                    : 1500000
                );
            }
        }

        public override string ToString()
        {
            return $"{_code}\t\t|{_name}\t\t|{DateOfBirth}\t\t|{_gender}\t\t|{_noOfChildren}\t\t|{_salary}\t\t|";
        }
    }
}

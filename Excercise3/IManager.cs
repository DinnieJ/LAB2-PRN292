using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excercise3
{
    interface IManager
    {
        void InputList(int Size);
        void ShowList();
        int CountFemaleWithoutAllowance();
        List<Employee> GetEmployeesWithChildNo(int ChildNumber);
        void SortMaleEmployeeSalary();
        List<Employee> GetMaleEmployeesWithChildNo(int ChildNumber);
        List<Employee> GetEmployeesByName(string Name);
        void UpdateSalary();
    }
}

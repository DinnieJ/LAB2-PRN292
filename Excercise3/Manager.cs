using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Excercise3
{
    class Manager : IManager
    {
        private List<Employee> ListEmployee;
        public Manager()
        {
            this.ListEmployee = new List<Employee>();
        }
        public int CountFemaleWithoutAllowance()
        {
            return ListEmployee.AsEnumerable()
                .Where(item => item.Gender == GenderType.Female && !item.IsGettingAllowance())
                .ToList()
                .Count();
        }

        public List<Employee> GetEmployeesByName(string name)
        {
            return (List<Employee>)ListEmployee.AsEnumerable()
                .Where(item => item.Name.Contains(name)).ToList();
        }

        public List<Employee> GetEmployeesWithChildNo(int ChildNumber)
        {
            return (List<Employee>)ListEmployee.AsEnumerable()
                .Where(item => item.NoOfChildren < ChildNumber).ToList();
        }

        public List<Employee> GetMaleEmployeesWithChildNo(int ChildNumber)
        {
            return (List<Employee>)ListEmployee.AsEnumerable()
                .Where(item => item.Gender == GenderType.Male && item.NoOfChildren > ChildNumber).ToList();
        }

        public void InputList(int Size)
        {
            for (int i = 0; i < Size; i++)
            {
                try
                {
                    Console.Write("Name:");
                    string name = Console.ReadLine();
                    Console.Write("Date Of Birth (dd/mm/yyyy): ");
                    string dob = Console.ReadLine();
                    if (!Regex.IsMatch(dob, @"^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4}|[0-9]{2})$"))
                    {
                        throw new Exception("Date invalid");
                    }
                    Console.Write("Gender(1: Male, 2: Female): ");
                    int n_gender = Int32.Parse(Console.ReadLine());
                    if (n_gender != 1 && n_gender != 2)
                    {
                        throw new Exception("Invalid gender input");
                    }

                    GenderType gender = n_gender == 1 ? GenderType.Male : GenderType.Female;
                    Console.Write("Children: ");
                    int children = Int32.Parse(Console.ReadLine());
                    if (children < 0) children = 0;
                    Console.Write("Salary: ");
                    double salary = Double.Parse(Console.ReadLine());

                    ListEmployee.Add(new Employee((ListEmployee.Count() + 1 + ""), name, dob, gender, children, salary));

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    i--;
                }
            }
        }

        public void SortMaleEmployeeSalary()
        {
            ListEmployee = ListEmployee.OrderBy(item => item.Gender != GenderType.Female).ThenBy(item => item.Salary).ToList();
        }

        public void ShowList()
        {
            ListEmployee.ForEach((item) => Console.WriteLine(item));
        }

        public void UpdateSalary()
        {
            for (int i = 0; i < ListEmployee.Count(); i++)
            {
                if (ListEmployee[i].Age < 30)
                {
                    ListEmployee[i].Salary += ListEmployee[i].Salary * 0.05;
                }
                else if (ListEmployee[i].Age >= 30 && ListEmployee[i].Age < 40)
                {
                    ListEmployee[i].Salary += ListEmployee[i].Salary * 0.1;
                }
                else
                {
                    ListEmployee[i].Salary += ListEmployee[i].Salary * 0.15;
                }
            }
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("1. TC1- Enter the employee list");
                Console.WriteLine("2. TC2- Display the employee list");
                Console.WriteLine("3. TC3- Counts the number of female employees with no allowances");
                Console.WriteLine("4. TC4- Displays employees with the number <given number.");
                Console.WriteLine("5. TC5- Arranging an increasing number of male employees' salaries.");
                Console.WriteLine("6. TC6- Removing male employees according to the number of entries entered from the keyboard.");
                Console.WriteLine("7. TC7- Display employees by name.");
                Console.WriteLine("8. TC8- Update salary");
                Console.WriteLine("q. Quit");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Write("Enter no of employee: ");
                        int e_no = Int32.Parse(Console.ReadLine());
                        InputList(e_no);
                        break;
                    case "2":
                        Console.WriteLine("Code\t\t|Name\t\t|Date Of Birth\t\t|Gender\t\t|Children\t\t|Salary\t\t|");
                        ShowList();
                        break;
                    case "3":
                        Console.WriteLine($"Number of female employees with no allowances: {CountFemaleWithoutAllowance()}");
                        break;
                    case "4":
                        Console.Write("Enter no of child:");
                        int nc = Int32.Parse(Console.ReadLine());
                        List<Employee> rs = GetEmployeesWithChildNo(nc);
                        rs.ForEach(item => Console.WriteLine(item));
                        break;
                    case "5":
                        SortMaleEmployeeSalary();
                        break;
                    case "6":
                        Console.Write("Enter no of child: ");
                        int nc2 = Int32.Parse(Console.ReadLine());
                        ListEmployee.RemoveAll(item => item.Gender == GenderType.Male && item.NoOfChildren > nc2);
                        break;
                    case "7":
                        Console.Write("Enter name: ");
                        string name = Console.ReadLine();
                        GetEmployeesByName(name).ForEach(item => Console.WriteLine(item.ToString()));
                        break;
                    case "8":
                        UpdateSalary();
                        break;
                    case "q":
                        return;
                }
            }
        }
    }
}

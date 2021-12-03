using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excercise4
{
    class Manager
    {
        List<Teacher> list;
        public Manager()
        {
            list = new List<Teacher>()
            {
                new ParttimeTeacher("100000", "Nguyen Van A", 30),
                new ParttimeTeacher("100001", "Ha Thi B", 1),
                new FulltimeTeacher("100002", "Ho Van C", 5),
                new FulltimeTeacher("100006", "Dao Van F", 5),
                new FulltimeTeacher("100004", "Tran Van D", 2),
                new ParttimeTeacher("100005", "Hello World E", 25)
            };
        }

        private void ShowList() => list.ForEach(item => Console.WriteLine(item.ToString()));

        private List<Teacher> GetTeachersWithHighestSalary()
        {
            int highestSalary = list.AsEnumerable().Max(item => item.GetSalary());
            return list.AsEnumerable().Where(item => item.GetSalary() == highestSalary).ToList();
        }

        private int CountTeacherWithSlot(int slot)
            => list.OfType<ParttimeTeacher>().AsEnumerable().Where(item => item.Slot > slot).Count();

        private int TotalParttimeTeacherSlot()
            => list.OfType<ParttimeTeacher>().AsEnumerable().Aggregate(0, (total, current) => total + current.Slot);

        private List<Teacher> GetTeacherByName(string name)
            => list.AsEnumerable().Where(item => item.Name.ToLower().StartsWith(name.ToLower())).ToList();

        private List<FulltimeTeacher> GetFulltimeTeachersBySalaryCo(int SalaryCoefficent)
            => list.OfType<FulltimeTeacher>().AsEnumerable().Where(item => item.SalaryCoefficent < SalaryCoefficent).ToList();

        private void SortBySalary()
            => list.Sort((a, b) => a.GetSalary().CompareTo(b.GetSalary()));




        public void Run()
        {
            while (true)
            {
                Console.WriteLine("1.Show List");
                Console.WriteLine("2.Highest Salary");
                Console.WriteLine("3.Parttime teacher with slot > 10");
                Console.WriteLine("4.Total PT teacher slots");
                Console.WriteLine("5.Sort the list of teachers increased by salary.");
                Console.WriteLine("6.Teacher with name start with T");
                Console.WriteLine("7.FT teacher with coefficent < 3");

                try
                {
                    string input = Console.ReadLine();
                    switch (input)
                    {
                        case "1": ShowList(); break;
                        case "2": GetTeachersWithHighestSalary().ForEach(item => Console.WriteLine(item.ToString())); break;
                        case "3": Console.WriteLine("No of PT Teacher with Slot > 10: " + CountTeacherWithSlot(10)); break;
                        case "4": Console.WriteLine($"Total PT Teachers Slot: {TotalParttimeTeacherSlot()}"); break;
                        case "5": SortBySalary(); break;
                        case "6": GetTeacherByName("T").ForEach(item => Console.WriteLine($"Name:{item.Name}\t|Salary:{item.GetSalary()}"));break;
                        case "7": GetFulltimeTeachersBySalaryCo(3).ForEach(item => Console.WriteLine($"Name:{item.Name}\t|FirstName:{item.FirstName}\t|LastName:{item.LastName}"));break;
                        case "q": return;
                        default: throw new Exception("Invalid input");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}

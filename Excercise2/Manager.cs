using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excercise2
{
    class Manager : IManager
    {
        List<Player> players = new List<Player>();
        List<Coach> coaches = new List<Coach>();
        public void ChangePlayer()
        {

            Console.WriteLine("Enter code: ");
            int code = ValidateData.CheckNumber();
            bool isOK = false;
            foreach (var item in players)
            {
                if (item.Code.Equals(code))
                {
                    isOK = true;
                    return;
                }
            }
            if (!isOK)
            {
                return;
            }
            int shirt = 0;
            int salary = 0;
            Console.WriteLine("Enter option, 0 to change shirt, non-0 to change salary");
            int option = ValidateData.CheckNumber();
            if (option == 0)
            {
                Console.WriteLine("Enter shirt number: ");
                shirt = ValidateData.CheckNumber();
            }
            else
            {
                Console.WriteLine("Enter salary: ");
                salary = ValidateData.CheckNumber();
            }

            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].Code == code)
                {
                    if (option != 0)
                    {
                        players[i].Salary = salary;
                    }
                    else
                    {
                        players[i].Number = shirt;
                    }
                    break;
                }
            }
        }

        public int CountCoach()
            => coaches.AsEnumerable().Count(item => item.Year >= 3);

        public void InputCoachList()
        {
            Console.WriteLine("Enter number of coach input: ");
            int n = ValidateData.CheckNumber();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Input name: ");
                string name = ValidateData.CheckString();
                Console.WriteLine("Input address ");
                string address = ValidateData.CheckString();
                Console.WriteLine("Input salary");
                int salary = ValidateData.CheckNumber();
                Console.WriteLine("Input position");
                string pos = ValidateData.CheckString();

                Console.WriteLine("Input year experiment");
                int year = ValidateData.CheckNumber();

                int code = coaches.Count() + 1;

                coaches.Add(new Coach(code, name, address, salary, year, pos));
            }
        }

        public void InputPlayerList()
        {
            Console.WriteLine("Enter number of player input: ");
            int n = ValidateData.CheckNumber();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Input name: ");
                string name = ValidateData.CheckString();
                Console.WriteLine("Input address ");
                string address = ValidateData.CheckString();
                Console.WriteLine("Input salary");
                int salary = ValidateData.CheckNumber();
                Console.WriteLine("Input position");
                string pos = ValidateData.CheckString();

                Console.WriteLine("Input shirt number");
                int shirt = ValidateData.CheckNumber();

                int code = players.Count() + 1;

                players.Add(new Player(code, name, address, salary, shirt, pos));
            }
        }

        public void ShowCoachList()
        {
            coaches.ForEach(item => Console.WriteLine(item.ToString()));
        }

        public void ShowMaxSalary()
        {
            int salaryPlayer = players.Max(item => item.Salary);
            
            Console.WriteLine("Show max salary players: ");
            players.AsEnumerable()
                   .Where(item => item.Salary == salaryPlayer)
                   .ToList()
                   .ForEach(item => Console.WriteLine(item.ToString()));

            int salaryCoach = coaches.Max(item => item.Salary); ;

            Console.WriteLine("Show max salary coachs: ");
            coaches.AsEnumerable()
                   .Where(item => item.Salary == salaryPlayer)
                   .ToList()
                   .ForEach(item => Console.WriteLine(item.ToString()));
        }

        public void ShowPlayerList()
        {
            Console.WriteLine("Show Player List: ");
            players.ForEach(item => Console.WriteLine(item.ToString()));
        }

        public void SortDescCoach3Year()
        {
            throw new NotImplementedException();
        }

        public void SortPlayerAscendingNumber()
           => players.Sort((a, b) => a.Number.CompareTo(b.Number));

        public int SumSalaryStriker()
            => players.AsEnumerable().Where(item => item.Position.Equals("Striker")).Aggregate(0, (prev, current) => prev + current.Salary);
    }
}


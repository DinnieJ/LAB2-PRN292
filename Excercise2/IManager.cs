using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excercise2
{
    interface IManager
    {
        void InputPlayerList();
        void InputCoachList();
        void ShowPlayerList();
        void ShowCoachList();
        void ChangePlayer();
        int CountCoach();
        int SumSalaryStriker();
        void ShowMaxSalary();
        void SortPlayerAscendingNumber();
        void SortDescCoach3Year();
    }
}

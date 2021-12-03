using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            HinhChuNhat hcn = new HinhChuNhat();
            int l = Convert.ToInt32(Console.ReadLine());
            int w = Convert.ToInt32(Console.ReadLine());
            hcn.Length = l;
            hcn.Width = w;

            hcn.Show();
            Console.ReadLine();
        }
    }
}

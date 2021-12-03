using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excercise2
{
    class ValidateData
    {
        public static string CheckString()
        {
            string res = Console.ReadLine();
            while (res == null || res == "")
            {
                Console.WriteLine("Invalid option: ");
                Console.Write("Choose your option");
                res = Console.ReadLine();
            }
            return res;
        }

        public static int CheckNumber()
        {
            int res = 0;
            try
            {
                res = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            return res;
        }
    }
}

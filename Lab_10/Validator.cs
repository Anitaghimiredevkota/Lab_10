using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab_10
{
    class Validator
    {
        public static double GetData()
        {
            bool success;
            string input = Console.ReadLine();
            success = double.TryParse(input, out double radius);
            if(success && radius > 0)
            {
                return radius;
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
                return GetData();
            }
           
        }
    }
}

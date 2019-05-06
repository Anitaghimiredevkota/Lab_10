using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Program
    {
        //private static double radius;

        static void Main(string[] args)
        {
            double radius;
            string success = "y";
            Console.WriteLine("Welcome to the Circle Tester");
            while (success == "y")
            {

                Console.WriteLine("enter radius");
                radius = Validator.GetData();//Console.ReadLine();
               // double radius = double.Parse(Console.ReadLine());
                double rounded = Math.Round(radius, 2);
                Circle c = new Circle(radius);
                //Console.WriteLine(c.CalculateCircumference());
                Console.WriteLine(c.CalculateFormattedCircumference());
                //Console.WriteLine(c.CalculatedArea());
                Console.WriteLine(c.CalculateFormattedArea());

                Console.WriteLine("Would you like to continue?(y/n)");                
                success = Console.ReadLine();
                if (success == "y") { }
        
                else
                {
                    Console.WriteLine("Goodbye. You created {0} Circle object(s)", rounded);
                }
            }
        }
    }
}

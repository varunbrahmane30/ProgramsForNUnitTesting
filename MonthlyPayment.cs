using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramsForNUnitTesting
{
    class MonthlyPayment
    {
        public static void calMOnthlyPayment()
        {
            Console.Write("Enter years 'Y' : ");
            int Y = int.Parse(Console.ReadLine());
            Console.Write("Enter principal loan amount 'P' : ");
            double P = double.Parse(Console.ReadLine());
            Console.Write("Enter percent interest compounded monthly 'R' : ");
            double R = double.Parse(Console.ReadLine());

            double n = 12 * Y;
            double r = R / (12 * 100);

            double payment = (P * r) / (1 - Math.Pow((1 + r), (-n)));

            Console.WriteLine("Your Payment is: " + payment);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramsForNUnitTesting
{
    class TempConversion
    {
        public static void convertTemperature()
        {
            // variable Declarations 
            int check, celsius, fahrenheit;


            // ask user for input

            while (true)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Enter 1 :  Celsius to Fahrenheit");
                Console.WriteLine("Enter 2 :  Fahrenheit to Celsius ");
                Console.WriteLine("Enter 3 :  Exit");
                Console.WriteLine("-------------------------------");
                check = int.Parse(Console.ReadLine());

                Console.WriteLine("-------------------------------");
                // calculations 



                if (check == 1)
                {
                    Console.WriteLine("Enter temperature in °C: ");
                    celsius = int.Parse(Console.ReadLine());
                    int fahrenheitC = (celsius * 9 / 5) + 32;
                    Console.WriteLine(+celsius + "°C = " + fahrenheitC + "°F");
                }
                else if (check == 2)
                {
                    Console.Write("Enter temperature in °F: ");
                    fahrenheit = int.Parse(Console.ReadLine());
                    int celsiusF = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine(+fahrenheit + "°F = " + celsiusF + "°C");
                }
                else if (check == 3)
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Enter valid input.");
                }
            }
        }
    }
}

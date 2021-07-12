using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramsForNUnitTesting
{
    class BinaryNumGen
    {
        public static void toBinary()
        {
            Console.Write("Enter number: ");
            int N = Convert.ToInt32(Console.ReadLine());

            string answer = " ";

            while (N > 1)
            {
                int remainder = N % 2;
                N = N / 2;
                answer = Convert.ToString(remainder) + answer;

            }
            answer = Convert.ToString(N) + answer;
            Console.WriteLine("Binary : {0}", answer);
        }
    }
}

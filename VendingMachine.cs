using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramsForNUnitTesting
{
    class VendingMachine
    {
		// variable declaration
		static int i = 0;
		public static int total = 0;

		
		
		static int money;

		// implementation
		public static int calculate(int money, int[] notes)
		{
			
			int rem;
			if (money == 0)
			{
				return -1;
			}
			else
			{
				if (money >= notes[i])
				{
					
					int calNotes = money / notes[i];
					rem = money % notes[i];
					money = rem;
					total += calNotes;
                    Console.WriteLine(notes[i]    + "       Notes -> " + calNotes);
				}
				i++;
				return calculate(money, notes);
			}
		}
	}
}

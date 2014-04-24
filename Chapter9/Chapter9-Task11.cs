using System;

namespace Chapter9Task11
{
	class MultipleTasks
	{
		static int Menu()
		{
			int choice; 
			Console.WriteLine ("--------------Menu---------------");
			Console.WriteLine ("||1. Reverse digits of a number||\n" +
							   "||2. Calculate avarage 		||\n" +
							   "||3. Solve a * x + b = 0	||\n");
			do
			{
				Console.Write ("Choose your option: ");
			}
			while(!(int.TryParse (Console.ReadLine(), out choice)) || choice < 1 || choice > 3);
			return choice;
		}
				
		static uint ReverseDigits()
		{
			uint num, cpy, multy = 0, newNum = 0;
			Console.WriteLine("You have chosen to reverse the order of the digits in a number!");
			do
			{
				Console.Write ("Please enter your number: ");
			}
			while(!(uint.TryParse (Console.ReadLine (), out num) )|| num < 0);
			cpy = num;
			while(cpy != 0)
			{
				multy++;
				cpy /= 10;
			}
			multy--;
			while(num != 0)
			{
				newNum += (num % 10)*(uint)(Math.Pow (10, multy));
				num /= 10;
				multy--;
			}
			return newNum;
		}
		
		static double CalculateAverage()
		{
			int size;
			double num, sum = 0;
			Console.WriteLine ("You have chosen to find the average of an array!");
			do
			{
				Console.Write ("Please enter the size of the array: ");
			}
			while((!(int.TryParse(Console.ReadLine (), out size))) || size <= 0);
			for(int i = 0; i <= size - 1; i++)
			{
				do
				{
					Console.Write ("Enter element {0}: ", i + 1);
				}
				while(!(double.TryParse (Console.ReadLine (), out num)));
				sum += num;
			}
			return sum / size;
		}
			
		static double SolveEquasion()
		{
			double a, b;
			Console.WriteLine ("You have chosen to solve the equasion: a * x + b = 0");
			do
			{
				Console.Write ("a = ");
			}
			while(!(double.TryParse (Console.ReadLine (), out a)) || a == 0);
			do
			{
				Console.Write ("b = ");
			}
			while(!(double.TryParse (Console.ReadLine (), out b)));
			return (-b) / a;
		}
			
		static void Main()
		{
			Console.Clear ();
			switch(Menu())
			{
				case 1: 
						Console.WriteLine ("Reverse: {0}", ReverseDigits());
						break;
				case 2: 
						Console.WriteLine ("Average: {0:F2}", CalculateAverage());
						break;
				case 3: 
						Console.WriteLine("x = {0:F2}", SolveEquasion());
						break;
			}
		}
	}
}
						
					
					

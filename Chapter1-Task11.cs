using System;

namespace Chapter1Task11
{
	class NumberRow
	{
		static void Main()
		{
			int year, step;
			Console.Write("Please enter your age: ");
			while(!(int.TryParse(Console.ReadLine(), out year)))
			{
				Console.Clear();
				Console.WriteLine("Wrong input! Try again!");
				Console.Write("Age = ");
			}
			Console.Write("Please enter after how many years you want to see your age: ");
			while(!(int.TryParse(Console.ReadLine(), out step)))
			{
				Console.Clear();
				Console.WriteLine("Wrong input! Try again!");
				Console.Write("Step = ");
			}
			Console.WriteLine("Your age after {0} years will be {1}!", step, year + step);
		}
	}
}

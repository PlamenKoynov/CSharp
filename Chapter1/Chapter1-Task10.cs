using System;

namespace Chapter1Task10
{
	class NumberRow
	{
		static void Main()
		{
			int number = 2; 
			for(int i = 1; i <= 100; i++, number++)
			{
				if(i % 2 == 0)
				{
					Console.Write(number * (-1));
				}
				else
				{
					Console.Write (number);
				}
				Console.Write(" ");
			}
			Console.WriteLine ();
		}
	}
}
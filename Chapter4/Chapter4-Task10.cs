using System;
using System.Text;

namespace Chapter5Task10
{
	class Points
	{
				
		static void Main()
		{
			int n, number, sum = 0;
			do
			{
				Console.Write("Enter the size of the array: ");
			}
			while(!(int.TryParse(Console.ReadLine (), out n)) || n <= 0);
			
			for(int i = 0; i <= n - 1; i++)
			{
				do
				{
					Console.Write("Enter element {0}: ", i + 1);
				}
				while(!(int.TryParse(Console.ReadLine (), out number)));
				
				sum += number; 
			}
				
			Console.WriteLine("Sum of all elements: {0}", sum);
		}
	}
}




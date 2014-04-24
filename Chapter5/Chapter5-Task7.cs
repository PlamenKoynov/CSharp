using System;
using System.Text;

namespace Chapter5Task7
{
	class MaximalNumber
	{
				
		static void Main()
		{
			int size, max = int.MinValue;
			do
			{
				Console.Write("Enter the size of the array: ");
			}
			while(!(int.TryParse(Console.ReadLine (), out size)));
			
			int [] arr = new int [size];
			
			for(int i = 0; i <= size - 1; i++)
			{
				do
				{
					Console.Write("Enter element {0}: ", i + 1);
				}
				while(!(int.TryParse(Console.ReadLine (), out arr[i])));
			}
			
			for(int i = 0; i <= size - 1; i++)
			{
				if(arr[i] > max)
				{
					max = arr[i];
				}
			}
			Console.WriteLine("Maximal number: {0}", max);
		}
	}
}


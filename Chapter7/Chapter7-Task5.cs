using System;
using System.Text;

namespace Chapter9Task3
{
	class Converter
	{
		
		static string ConvertToText(int num)
		{
			string []digits = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
			return digits[num];
		}
				
		static void Main()
		{
			int size, number = 0, counter = 0, max = 0;
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
			
			for(int i = 1; i <= size - 1; i++)
			{
				while(arr[i] > arr[i - 1])
				{
					i++;
					counter++;
					if(i > size - 1)
					{
						break;
					}
				}
				if(counter > max)
				{
					max = counter;
					number = arr[i - 1];
				}
				
				counter = 0;
			}
			if(max == 0)
			{
				Console.WriteLine("There is no consiquent equal elements!");
			}
			else
			{
				for(int i = 0; i <= max; i++)
				{
					Console.Write (number + " ");
				}
				Console.WriteLine ();
			}
		}
	}
}


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
			ulong number;
			do
			{
				Console.Write("Enter your number: ");
			}
			while(!(ulong.TryParse(Console.ReadLine (), out number)));
			
			Console.WriteLine (ConvertToText((int) number % 10));
		}
	}
}


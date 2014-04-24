using System;
using System.Text;

namespace Chapter8Task7
{
	class Converter
	{
		static void Main()
		{
			ulong dec = 0;
			int size, p = 0;
			string number;
			Console.Write("Enter your hexidecimal number: ");
			number = Console.ReadLine ();
			size = number.Length;
			for(int i = size - 1; i >= 0; i--)
			{
				if(number[i] >= 'A' && number[i] <= 'F')
					dec += ((ulong)(number[i] - 'A') + 10) * (ulong)Math.Pow(16, p);
				else
					dec += (ulong)(number[i] - '0') * (ulong)Math.Pow (16, p);
				p++;
			}
			Console.WriteLine("The decimal representation is {0}", dec);
		}
	}
}

using System;

namespace Chapter8Task14
{
	class Converter
	{
		static void Main()
		{
			ulong dec;
			int [] bin = new int [64];
			int i = 0;
			do
			{
				Console.Write ("Enter your decimal number: ");
			}
			while(!(ulong.TryParse(Console.ReadLine(), out dec)));
			while(dec != 0)
			{
				bin[i++] = (int) (dec % 2);
				dec /= 2;
			}
			Console.WriteLine("The binary representation is:");
			for(i -= 1; i >= 0; i--)
				Console.Write (bin[i]);
			Console.WriteLine ();
		}
	}
}
	

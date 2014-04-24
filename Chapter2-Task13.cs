using System;

namespace Chapter2Task13
{
	class SwapElements
	{
		static void Main()
		{
			int a, b, temp;
			do
			{
				Console.Write ("a = ");
			}
			while(!(int.TryParse(Console.ReadLine(), out a)));
			
			do
			{
				Console.Write ("b = ");
			}
			while(!(int.TryParse(Console.ReadLine(), out b)));
			
			temp = a;
			a = b;
			b = temp;
			
			Console.WriteLine ("After swapping:\na = {0}\nb = {1}", a, b);
		}
	}
}
				
		

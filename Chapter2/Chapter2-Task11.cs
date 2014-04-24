using System;

namespace Chapter2Task11
{
	class Triangle
	{
		static void Main()
		{
			int length, space, inner;
			Console.Write("Please enter the length of the side of the triangle you want to print: ");
			while(!(int.TryParse(Console.ReadLine(), out length)))
			{
				Console.Clear();
				Console.WriteLine("Wrong input! Try again!");
				Console.Write("Length = ");
			}
			space = length - 1;
			inner = -1;
			for(int i = 0; i <= length - 2; i++)
			{
				for(int j = 0; j <= space - 1; j++)
				{
					Console.Write (" ");
				}
				Console.Write("*");
				for(int p = 1; p <= inner; p++)
				{
					Console.Write (" ");
					if(p == inner)
					{
						Console.Write("*");
					}
				}
				Console.WriteLine ();
				inner += 2;
				space--;
			}
			for(int i = 0; i <= length - 1; i++)
			{
				Console.Write ("* ");
			}
			Console.WriteLine ();
			
		}
	}
}


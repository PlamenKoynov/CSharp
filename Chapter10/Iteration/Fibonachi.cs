using System;

namespace Fibonachi
{
	class FibonachiNumbers
	{
		static void Main()
		{
			int number;
			ulong current = 1, last = 1; 
			
			Console.Write ("Please enter which number you want to find: ");
			number = int.Parse (Console.ReadLine());
			
			if(number == 1 || number == 2)
			{
				Console.WriteLine(1);
			}
			else
			{
				for(int i = 3; i <= number; i++)
				{
					current += last;
					last = current - last;
				}
				Console.WriteLine ("The {0} Fibonachi number is {1}", number, current);	
			}
		}
	}
}


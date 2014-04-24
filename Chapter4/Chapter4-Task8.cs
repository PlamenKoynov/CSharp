using System;

namespace Chapter4Task8
{
	class MaximalNumber
	{
		static void Main()
		{
			int [] numbers = new int [5];
			int maxNum;
			for(int i = 0; i <= 4; i++)
			{
				do
				{
					Console.Write ("Enter element {0}: ", i + 1);
				}
				while(!(int.TryParse(Console.ReadLine(), out numbers[i])));
			}
			
			maxNum = numbers[0];
			
			for(int i = 1; i <= 4; i++)
			{
				if(numbers[i] > maxNum)
				{
					maxNum = numbers[i];
				}
			}
			
			Console.WriteLine("Max: {0}", maxNum);
		}
	}
}
			
			

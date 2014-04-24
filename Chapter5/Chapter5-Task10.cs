using System;
using System.Text;

namespace Chapter5Task10
{
	class Points
	{
				
		static void Main()
		{
			int points;
			do
			{
				Console.Write("Enter the points on the test: ");
			}
			while(!(int.TryParse(Console.ReadLine (), out points)) || points <= 0 || points > 9);
			
			if(points >= 1 && points <= 3)
			{
				points *= 10;
			}
			else if(points >= 4 && points <= 6)
			{
				points *= 100;
			}
			else
			{
				points *= 1000;
			}
			Console.WriteLine("Final score: {0}", points);
		}
	}
}



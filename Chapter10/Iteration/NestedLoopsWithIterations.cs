using System;

namespace NestedLoopsWithIterations
{
	class NestedLoops
	{
		
		static void Init(int n, int [] loops)
		{
			for(int i = 0; i <= n - 1; i++)
				loops[i] = 1;
		}
		
		static void Print(int n, int [] loops)
		{
			for(int i = 0; i <= n - 1; i++)
				Console.Write (loops[i] + " ");
			Console.WriteLine ();
		}
		
		static void Main()
		{
			bool exit = false;
			int numberOfLoops, numberOfElements, pos; 
			
			Console.Write ("Please enter how many loops you want to have: ");
			numberOfLoops = int.Parse (Console.ReadLine());
			
			Console.Write ("Please enter how many elements you want to have: ");
			numberOfElements = int.Parse(Console.ReadLine ());
			
			int [] loops = new int [numberOfLoops];
			
			Init(numberOfLoops, loops);
			
			while(exit == false)
			{
				Print(numberOfLoops, loops);
				pos = numberOfLoops - 1;
				loops[pos] += 1;
				while(loops[pos] > numberOfElements)
				{
					loops[pos--] = 1;
					if(pos < 0)
					{
						exit = true;
						break;
					}
					loops[pos] += 1;
				}
			}
		}
	}
}

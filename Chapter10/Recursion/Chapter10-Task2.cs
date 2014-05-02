using System;

namespace Chapter10Task2
{
	class AllCombinations
	{
		static int n, k, last = 1;
		static int []comb;
				
		static void Main()
		{
			Console.WriteLine ("Please enter n and k!");
			Console.Write("n = ");
			n = int.Parse (Console.ReadLine ());
			Console.Write ("k = ");
			k = int.Parse (Console.ReadLine ());
			
			comb = new int[n];
						
			combinations(1);
		}
		
		static void combinations(int p)
		{ 
			for(int counter = last; counter <= n; counter++)
			{
				comb[p] = counter;
				if(p == k)
					print();
				else
					combinations (p + 1);
				if(counter == n)
				{
					last++;
					return;
				}
			}
		}
		
		static void print()
		{
			for(int i = 1; i <= k; i++)
				Console.Write (comb[i] + " ");
			Console.WriteLine();
		}
	}
}
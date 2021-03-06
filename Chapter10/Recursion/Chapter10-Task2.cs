using System;

namespace Chapter10Task2
{
	class AllCombinations
	{
		static int n, k;
		static int []comb;
				
		static void Main()
		{
			Console.WriteLine ("Please enter n and k!");
			Console.Write("n = ");
			n = int.Parse (Console.ReadLine ());
			Console.Write ("k = ");
			k = int.Parse (Console.ReadLine ());
			
			comb = new int[k + 1];
						
			combinations(1, 1);
		}
		
		static void combinations(int p, int last)
		{ 
			if(p > k)
				return;
			for(int counter = last; counter <= n; counter++)
			{
				comb[p] = counter;
				if(p == k)
					print ();
				combinations(p + 1, counter);
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
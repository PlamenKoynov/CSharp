using System;

namespace Chapter10Task5
{
	class Words
	{
		static int n = 4;
		static int []comb;
		static string []words = {"test", "rock", "fun"};
				
		static void Main()
		{
			comb = new int[100];
						
			for(int j = 1; j <= n; j++)
				combinations(j, 1, 1);
		}
		
		static void combinations(int k, int p, int last)
		{ 
			for(int counter = last; counter <= n; counter++)
			{
				comb[p] = counter;
				if(p == k)
					print(k);
				combinations(k, p + 1, counter + 1);
			}
		}
		
		static void print(int k)
		{
			for(int i = 1; i <= k; i++)
				Console.Write (comb[i] + " ");
			Console.WriteLine();
		}
	}
}

using System;

namespace Chapter10Task4
{
	class AllWords
	{
		static int k;
		static int []comb;
		static string []words = {"test", "rock", "fun"};
				
		static void Main()
		{
			Console.WriteLine ("Please enter k!");
			Console.Write ("k = ");
			k = int.Parse (Console.ReadLine ());
			
			comb = new int[k + 1];
						
			combinations(1, 1);
		}
		
		static void combinations(int p, int last)
		{ 
			if(p > k)
				return;
			for(int counter = last; counter <= 3; counter++)
			{
				comb[p] = counter;
				if(p == k)
					print();
				combinations(p + 1, counter + 1);
			}
		}
		
		static void print()
		{
			for(int i = 1; i <= k; i++)
				Console.Write (words[comb[i] - 1] + " ");
			Console.WriteLine();
		}
	}
}
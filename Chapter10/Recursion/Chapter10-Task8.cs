using System;

namespace Chapter10Task8
{
	class Words
	{
		static int s, n;
		static int []comb;
		static int []arr;
				
		static void Main()
		{
			Console.Write("Enter the size of your array: ");
			n = int.Parse(Console.ReadLine());
			
			comb = new int[n + 1];
			arr = new int[n + 1];
			
			Console.WriteLine("Enter the elements of your array!");
			for(int i = 0; i <= n - 1; i++)
				arr[i] = int.Parse(Console.ReadLine());
					
			Console.Write ("What sum you want to find: ");
			s = int.Parse(Console.ReadLine());
			
			for(int j = 1; j <= n; j++)
				combinations(j, 1, 1);
		}
		
		static void combinations(int k, int p, int last)
		{ 
			for(int counter = last; counter <= n; counter++)
			{
				comb[p] = counter;
				if(p == k)
					print(k, s);
				combinations(k, p + 1, counter + 1);
			}
		}
		
		static void print(int k, int s)
		{
			int sum = 0;
			for(int i = 1; i <= k; i++)
				sum += arr[comb[i] - 1];
			if(sum == s)
			{
				Console.Write ("Found: ");
				for(int i = 1; i <= k; i++)
					Console.Write (arr[comb[i] - 1] + " ");
				Console.WriteLine();
			}
		}
	}
}


using System;

namespace Chapter7Task3
{
	class Checker
	{
		static void Main()
		{
			bool flag = false;
			string word1, word2;
			int size1, size2;
			
			Console.Write("Enter your first word: ");
			word1 = Console.ReadLine ();
			Console.Write("Enter your first word: ");
			word2 = Console.ReadLine ();
			
			size1 = word1.Length;
			size2 = word2.Length;
			
			if(size1 < size2)
			{
				for(int i = 0; i <= size1 - 1; i++)
				{
					if(word1[i] > word2[i])
					{	
						flag = true;
						break;
					}
				}
				if(flag == true)
				{
					Console.WriteLine ("{1} is before {0}!", word1, word2);
				}
				else
				{
					Console.WriteLine("{0} is before {1}", word1, word2);
				}
			}
			else
			{
				for(int i = 0; i <= size1 - 1; i++)
				{
					if(word1[i] < word2[i])
					{	
						flag = true;
						break;
					}
				}
				if(flag == true)
				{
					Console.WriteLine ("{0} is before {1}!", word1, word2);
				}
				else
				{
					if(size1 == size2)
					{
						Console.WriteLine ("The words are equal!");
					}
					else
					{
						Console.WriteLine("{1} is before {0}", word1, word2);
					}
				}
			}
						
		}
	}
}
	

using System;

namespace Chapter9Task8
{
	class SumOfBigNumbers
	{
		
		static void Sum(int []arr1, int []arr2, int size1, int size2)
		{
			int [] arr = new int [10000];
			int mod = 0;
			if(size1 > size2)
			{
				
				for(int i = 0; i <= size2 - 1; i++)
				{
					if(arr1[i] + arr2[i] > 9)
					{
						arr[i] = 0;
						mod = arr[i] + arr2[i] - 10;
					}
					else
					{
						if(mod != 0)
						{
							if(arr1[i] + arr2[i] + mod > 9)
							{
								arr[i] = 0;
								mod = arr1[i] + arr2[i] + mod - 10;
							}
							else
							{
								arr[i] = arr1[i] + arr2[i] + mod;
								mod = 0;
							}
						}
						else
						{
							arr[i] = mod;
							mod = 0;
						}
					}
				}
				if(mod != 0)
				{
					while(mod != 0)
					{
						if(mod > 9)
						{
							arr[size2++] = 0;
							mod -= 10;
						}
						else
						{
							arr[size2++] = mod;
							mod = 0;
						}
					}
					
					while(size1 < size2)
					{
						arr[size1++] = arr1[size2];
					}
	
					for(size2 -= 1; size2 >= 0;  size2--)
					{
						Console.Write(arr[size2]);
					}
					Console.WriteLine ();
				}
				
			else
			{
				
				for(int i = 0; i <= size1 - 1; i++)
				{
					if(arr1[i] + arr2[i] > 9)
					{
						arr[i] = 0;
						mod = arr[i] + arr2[i] - 10;
					}
					else
					{
						if(mod != 0)
						{
							if(arr1[i] + arr2[i] + mod > 9)
							{
								arr[i] = 0;
								mod = arr1[i] + arr2[i] + mod - 10;
							}
							else
							{
								arr[i] = arr1[i] + arr2[i] + mod;
								mod = 0;
							}
						}
						else
						{
							arr[i] = mod;
							mod = 0;
						}
					}
				}
				if(mod != 0)
				{
					while(mod != 0)
					{
						if(mod > 9)
						{
							arr[size1++] = 0;
							mod -= 10;
						}
						else
						{
							arr[size1++] = mod;
							mod = 0;
						}
					}
				}
				while(size1 < size2)
					{
						arr[size1++] = arr1[size2 - 1];
					}
				
					Console.Write ("Here!");
					for(size1 -= 1; size1 >= 0;  size1--)
					{
						Console.Write (arr[size2]);
					}
					Console.WriteLine ();
						
			}
			}
					
		}
				
		static void Main()
		{
			int [] arr1 = new int[10000];
			int [] arr2 = new int[10000];
			int size1, size2;
			do
			{
				Console.Write("Enter the size of array 1: ");
			}
			while(!(int.TryParse(Console.ReadLine (), out size1)));
			
			Console.WriteLine("Enter the first number, but reverse!");
			for(int i = 0; i <= size1 - 1; i++)
			{
				arr1[i] = int.Parse (Console.ReadLine());
			}
			
			
			do
			{
				Console.Write("Enter the size of array 2: ");
			}
			while(!(int.TryParse(Console.ReadLine (), out size2)));
			
			Console.WriteLine("Enter the second number, but reverse!");
			for(int i = 0; i <= size2 - 1; i++)
			{
				arr2[i] = int.Parse (Console.ReadLine());
			}
			Sum(arr1, arr2, size1, size2);
		}
	}
}

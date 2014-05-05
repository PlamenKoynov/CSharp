using System;
using System.Text;

namespace Chapter13Task3
{
	class CheckEquation
	{
		static void Main()
		{
			string str;
			int size = 0, counter = 0;
		
			Console.Write ("Enter the equation you want to check: ");
			str = Console.ReadLine ();
			size = str.Length - 1;
		
			for(int i = 0; i <= size; i++)
			{
				if(str[i] == '(')
					counter++;
				if(str[i] == ')')
					counter--;
				if(counter < 0)
					break;
			}
			if(counter < 0)
				Console.WriteLine("Too many closing brackets!");
			else if(counter > 0)
				Console.WriteLine ("Too many opening brackets!");
				else 
					Console.WriteLine("The equasion is right!");
		}
	}
}


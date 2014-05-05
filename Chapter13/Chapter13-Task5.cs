using System;
using System.Text;

namespace Chapter13Task5
{
	class Search
	{	
		static void Main()
		{
			string text, sub;
			int counter = 0, index = 0;
		
			Console.Write ("Enter your text! For end press Enter: ");
			text = Console.ReadLine ();
			Console.Write ("Enter the substring you want to find: ");
			sub = Console.ReadLine ();
			
			index = text.IndexOf(sub);
			while(index != -1)
			{
				counter++;
				index = text.IndexOf (sub, index + 1);
			}
			
			if(counter == 0)
				Console.WriteLine("There are no words in which the substring {0} is met!", sub);
			else
				Console.WriteLine ("There are {0} words in which the substring {1} is met!", counter, sub);
		}
	}
}


using System;
using System.Text;

namespace Chapter13Task24
{
	class PrintSequence
	{	
		static void Main()
		{
			string text;
			char current;
			int size = 0, i = 0;
			StringBuilder str = new StringBuilder();
		
			Console.Write ("Enter your string! For end press Enter: ");
			text = Console.ReadLine ();
			size = text.Length;
			current = text[0];
			str.Append (text[0]);
			
			while(i <= size - 1)
			{
				if(text[i] != current)
				{
					current = text[i];
					str.Append(text[i]);
				}
				i++;
			}
			Console.WriteLine("String after processing: " + str.ToString());
		}
	}
}


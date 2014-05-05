using System;
using System.Text;

namespace Chapter13Task10
{
	class PrintSentences
	{	
		static void Main()
		{
			string text, check;
			string [] sent;
			string [] words;
		
			Console.Write ("Enter your text! For end press Enter: ");
			text = Console.ReadLine ();
			Console.Write ("Enter the word you are looking for: ");
			check = Console.ReadLine ();
			
			sent = text.Split('.');
			
			foreach(string str in sent)
			{
				words = str.Split (' ');
				foreach(string word in words)
				{
					if(string.Compare(word, check, true) == 0)
						Console.WriteLine (str + ".");
				}
			}
		}
	}
}


using System;
using System.Text;

namespace Chapter13Task2
{
	class Reverse
	{
		static string reverseWord(string s, int len)
		{
			StringBuilder reverse = new StringBuilder();
			for(len -= 1; len >= 0; len--)
				reverse.Append(s[len]);
			return reverse.ToString();
		}
		
		static void Main()
		{
			string str;
			int size = 0;
		
			Console.Write ("Enter the word you want to reverse: ");
			str = Console.ReadLine ();
			size = str.Length;
		
			Console.WriteLine("Reverse: " + reverseWord(str, size));
		}
	}
}

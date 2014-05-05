using System;
using System.Text;

namespace Chapter13Task6
{
	class ToUpperWords
	{	
		static void Main()
		{
			string text;
			int start = 0, last = 0;
		
			Console.Write ("Enter your text! For end press Enter: ");
			text = Console.ReadLine ();
			
			start = text.IndexOf("<upcase>");
			last = text.IndexOf("<\\upcase>");
			while(start >= 0)
			{
				StringBuilder old = new StringBuilder();
				StringBuilder st = new StringBuilder();
				old.Append ("<upcase>");
				for(int i = start + 8; i <= last - 1; i++)
				{
					old.Append(text[i]);
					st.Append (char.ToUpper(text[i]));
					
				}
				old.Append ("<\\upcase>");;
				text = text.Replace (old.ToString(), st.ToString());
				start = text.IndexOf ("<upcase>", start + 1);
				last = text.IndexOf ("<\\upcase>", start + 2);
			}
			Console.WriteLine ("Text after changes: ");
			Console.WriteLine (text);
		}
	}
}
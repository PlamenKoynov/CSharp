using System;
using System.Text;
namespace Chapter14Task25
{
	public class Fraction
	{
		private string decimalFraction;
		
		public string DecimalFraction
		{
			get
			{
				return decimalFraction;
			}
			set
			{
				bool flag = false;
				for(int i = 0; i <= value.Length - 1; i++)
					if(value[i] == '/')
					{
						flag = true;
						break;
					}
				if(flag == true)
					decimalFraction = value;
				else
					throw new Exception("Not a fraction!");
			}
		}
		
		public double Parse()
		{
			double first = 0, second = 0;
			int size, pr = 1; 
			
			size = decimalFraction.Length - 1;
			
			while(decimalFraction[size] != '/')
			{
				second += (decimalFraction[size] - '0') * pr;
				pr *= 10;
				size--;
			}
			
			size--;
			pr = 1;
			
			while(size >= 0)
			{
				first += (decimalFraction[size] - '0') * pr;
				pr *= 10;
				size--;
			}
			
			return first / second;
		}
		
		
	}
	
	public class MainClass
	{
		static void Main()
		{
			Fraction fr = new Fraction();
			Console.Write("Enter a fraction: ");
			fr.DecimalFraction = Console.ReadLine();
			Console.WriteLine("Fraction after parse: " + fr.Parse());
		}
	}
}
using System;
using System.Text;

namespace Chapter2Task12
{
	class CompanyEmployee
	{
		static void Main()
		{
			string firstName, lastName;
			int age;
			char sex; 
			uint number;
			
			Console.Write("First name of the employee: ");
			firstName = Console.ReadLine();
			
			Console.Write ("Family name of the employee: ");
			lastName = Console.ReadLine ();
			
			do
			{
				Console.Write ("Age: ");
			}
			while(!(int.TryParse(Console.ReadLine(), out age)));
			
			Console.Write ("Sex: ");
			sex = (char)Console.Read();
			Console.WriteLine ();
			
			do
			{
				Console.Write ("Number: ");
			}
			while(!(uint.TryParse(Console.ReadLine(), out number)));
			
			Console.Clear ();
			
			Console.WriteLine("You have entered information about the following employee: ");
			Console.WriteLine("First name: {0}\nLast name: {1}\nAge: {2}\nSex: {3}\nNumber: {4}", 
			                  firstName, lastName, age, sex, number);
		}
	}
}

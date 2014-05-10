using System;
using System.Text;
namespace Chapter14Task1
{
	public class Student
	{	
		private string studentNames;
		private int year;
		public string uni;
	    public string faculty;
	    public string email;
		private string tel;
		
		public Student (){}
		
		public Student(string studentNames, int year, string uni, string faculty, string email, string tel)
		{
			this.studentNames = studentNames;
			this.year = year;
			this.uni = uni;
			this.faculty = faculty;
			this.email = email;
			this.tel = tel;
		}
		
		public Student(string studentNames)
		{
			this.studentNames = studentNames;
			this.year = 0;
			this.uni = null;
			this.faculty = null;
			this.email = null;
			this.tel = null;
		}
		
		public Student(string studentNames, int year)
		{
			this.studentNames = studentNames;
			this.year = year;
			this.uni = null;
			this.faculty = null;
			this.email = null;
			this.tel = null;
		}
		
		//..................
		
		public string StudentNames
		{
			get 
			{
				return studentNames;
			}
			set
			{
				int size, counter = 0; 
				size = value.Length - 1;
				for(int i = 0; i <= size; i++)
					if(value[i] == ' ')
						counter++;
				if(counter >= 2)
						studentNames = value;
				else
					throw new Exception("Invalid name input! You have to enter 3 names!");
			}
		}
		
		public int Year
		{
			get 
			{
				return year;
			}
			set
			{
				if(value < 1 || value > 4)
					throw new Exception("Not a valid year!");
				else
					year = value;
			}
		}
		
		public string Tel
		{
			get 
			{
				return tel;
			}
			set
			{
				int size;
				size = value.Length;
				if(size == 10)
					tel = value;
				else
					throw new Exception("Not a valid telephone number!");
			}
		}
					
		
		public void PrintStudent()
		{
			Console.WriteLine("Names: " + studentNames);
			Console.WriteLine("Uni: " + uni);
			Console.WriteLine("Faculty: " + faculty);
			Console.WriteLine("Year: " + year);
			Console.WriteLine("E-mail: " + email);
			Console.WriteLine("Tel.number: " + tel);
		}
	}
	
	public class MainClass
	{
		static void Main()
		{
			Student st = new Student();
			Console.WriteLine("Enter the data for a student!");
			Console.Write("Names: ");
			st.StudentNames = Console.ReadLine();
			Console.Write("Year: ");
			st.Year = int.Parse (Console.ReadLine ());
			Console.Write("Uni: ");
			st.uni = Console.ReadLine();
			Console.Write ("Faculty: ");
			st.faculty = Console.ReadLine ();
			Console.Write ("Tel. number: ");
			st.Tel = Console.ReadLine ();
			Console.Write("E-mail: ");
			st.email = Console.ReadLine();
			st.PrintStudent();
		}
	}
}

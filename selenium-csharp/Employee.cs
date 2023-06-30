using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_selenium
{
	// Inheritance
	public class Employee : Person
	{
		public int Salary { get; set; }

		// Polymorphism - Overriding
		public override void SayHello()
		{
			Console.WriteLine("Hello Boss");
		}

		// Polymorphism - Overloading
		public void SayHello(string message)
		{
			Console.WriteLine($"Hello Boss with the message {message}");
		}

		public void PrintSalary()
		{
			Console.WriteLine(Salary);
		}
	}
}

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

		public void PrintSalary()
		{
			Console.WriteLine(Salary);
		}
	}
}

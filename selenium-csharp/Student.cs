using csharp_selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_csharp
{
	// Abstraction (0-100%)
	abstract class Student
	{
		public abstract void CalculateMarks();
	}

	class CollegeStudent : Student
	{
		public override void CalculateMarks()
		{
			Console.WriteLine("Calculating college student marks.");
		}
	}

	class SchoolStudent : Student
	{
		public override void CalculateMarks()
		{
			Console.WriteLine("Calculating school student marks.");
		}
	}
}

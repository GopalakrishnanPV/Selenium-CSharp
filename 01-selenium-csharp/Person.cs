using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_selenium
{
	// Class
	public class Person
	{
		public string name = string.Empty;

		// Encapsulation
		private int age = 0;

		public int Age
		{
			get { return age; }
			set {
				if (value >= 0)
				{
					age = value; 
				}
			}
		}

		public void Greet()
		{
			Console.WriteLine("Hello from " + name);
		}

		public virtual void SayHello()
		{
			Console.WriteLine("Hello");
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11
{
	public class Person
	{

		public string name { get; set; }
		public virtual string Greet()
		{
			return $"Hello, my name is {name}.";
		}	
	}
}

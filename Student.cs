using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11
{
	public class Student : Person 
	{ 
		public string gradeLevel { get; set; }
		public override string Greet()
	{
			return $"Hello, my name is {name} and I'm in grade {gradeLevel}.";
	}
}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11
{
	public class Shape
	{
		public int Area { get; set; }
		public virtual int GetArea() 
		{
			return 0;
		}
	}
}

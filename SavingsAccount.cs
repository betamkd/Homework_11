using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11
{
	
	public class SavingsAccount : BankAccount
	{
		public virtual float InterestRate { get; set; }

		
	
	public float CalculateInterest()
		{
		return Balance + CalculateInterest();
	}

}
}
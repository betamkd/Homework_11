using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11
{
	
	public class SavingsAccount : BankAccount
	{
		public decimal InterestRate { get; set; }

		//decimal rate = 0;
		
	
	public void CalculateInterest()
		{
			decimal interest = Balance * InterestRate;
			Deposit(interest);
		}

}
}
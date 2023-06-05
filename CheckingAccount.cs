using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11
{
	public class CheckingAccount : BankAccount
	{
		
		public decimal OverdraftFee { get; set; }

		//public override float Withdraw()
		//{

		//	if (balance < 0) 
		//	{

		//	return $"You have reached your balance! The overdraft fee is {float.Parse(overdraftFee)}";

		//	}
		//	else
		//	{
		//		return balance;
		//	}
		//}

		public override decimal Withdraw(decimal amount)
		{
			if (Balance - amount < 0)
			{
				return Balance -= amount + OverdraftFee;
			}

			else return Balance -= amount;
			
		}
	}
}

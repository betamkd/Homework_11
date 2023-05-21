using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11
{
	public class BankAccount
	{

		public BankAccount(string accountNumber, float balance)
		{
			AccountNumber = accountNumber;
			Balance = balance;
		}

		
		public string AccountNumber { get; set; }
		public float Balance { get; set; }


		public virtual float Deposit()
		{ 
		return Balance + Deposit();
		}
		public virtual float Withdraw() 
		{
		return Balance - Withdraw();
		}
	}
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11
{
	public class BankAccount
	{

		//public BankAccount(string accountNumber, float balance)
		//{
		//	AccountNumber = accountNumber;
		//	Balance = balance;
		//}

		public string AccountNumber { get; set; }
		public decimal Balance { get; set; }

		//decimal amount = 0;
		//public decimal initialBalance = 1500;

		public virtual decimal Deposit(decimal amount )
		{ 
			return Balance += amount;
		}
		public virtual decimal Withdraw(decimal amount) 
		{
			return Balance -= amount;
		}
	}
}


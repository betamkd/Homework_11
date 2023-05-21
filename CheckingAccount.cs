using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11
{
	public class CheckingAccount : BankAccount
	{
		
		public float OverdraftFee { get; set; }
		
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

		public override void Withdraw()
		{
			if (Balance < 0) 
			{
			return (OverdraftFee);
			}
		}
	}
}

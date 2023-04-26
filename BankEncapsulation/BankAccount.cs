using System;
namespace BankEncapsulation
{
	public class BankAccount
	{

        public BankAccount()
        {
        }

		private double balance = 0;

        public void Deposit(double ammount)
		{
			balance = ammount;
		}

		public double GetBalance()
		{
			return balance;
		}
	}
}


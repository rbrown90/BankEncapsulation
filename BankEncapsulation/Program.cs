using System.Collections.Generic;
namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();

            Console.WriteLine("How much would you like to Deposit?");

            var depositAmmount = double.Parse(Console.ReadLine());

            account.Deposit(depositAmmount);

            Console.WriteLine($"You have deposited {depositAmmount} today. Your new balanace now is {account.GetBalance()} Thank you!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//create account class acc has acount numb , type, balance
//write methods to accept details for account numb type and balance.
//create method to display acc info , create method to withraw to withraw money to current balnce
//create diposite method to increase balance , check balance
namespace PracticeQuestion
{
    public class Account
    {

        private int accountNumber;
        private string accountType;
        private double balance;

        public void AcceptDetails()
        {
            Console.Write("Enter account number: ");
            accountNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter account type: ");
            accountType = Console.ReadLine();

            Console.Write("Enter balance: ");
            balance = double.Parse(Console.ReadLine());
        }
        public void DisplayAccountInfo()
        {
            Console.WriteLine("\nAccount Information:");
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Account Type: {accountType}");
            Console.WriteLine($"Balance: {balance}");
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawal of {amount} successful.");
            }
            else
            {
                Console.WriteLine("Insufficient balance or invalid amount for withdrawal.");
            }
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposit of {amount} successful.");
            }
            else
            {
                Console.WriteLine("Invalid amount for deposit.");
            }
        }

        public double CheckBalance()
        {
            return balance;
        }

        static void Main(string[] args)
        {
            Account account = new Account();

            // Accepting details for the account
            Console.WriteLine("Enter account details:");
            account.AcceptDetails();

            // Displaying account information
            account.DisplayAccountInfo();

            // Perform a withdrawal
            Console.Write("\nEnter amount to withdraw: ");
            double withdrawAmount = double.Parse(Console.ReadLine());
            account.Withdraw(withdrawAmount);

            // Perform a deposit
            Console.Write("\nEnter amount to deposit: ");
            double depositAmount = double.Parse(Console.ReadLine());
            account.Deposit(depositAmount);

            // Check balance
            double currentBalance = account.CheckBalance();
            Console.WriteLine($"\nCurrent Balance: {currentBalance}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class BankAccount
    {
        public string Name { get; private set; }
        public int AccountNumber { get; private set; }
        public int Amount { get; private set; }

        public BankAccount(string name, int initialAmount)
        {
            Name = name;
            AccountNumber = new Random().Next(10000000, 999999999);
            Amount = initialAmount;
            Console.WriteLine($"Account created successfully! Your account number is {AccountNumber}.");
            Console.WriteLine($"Total amount: {Amount}");
        }

        public void Deposit(int depositAmount)
        {
            if (depositAmount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }

            Amount += depositAmount;
            Console.WriteLine($"Deposited: {depositAmount}");
            Console.WriteLine($"Total amount after deposit: {Amount}");
        }

        public void Withdraw(int withdrawAmount)
        {
            if (withdrawAmount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return;
            }

            if (withdrawAmount > Amount)
            {
                Console.WriteLine("Insufficient balance. Please enter a valid amount.");
            }
            else
            {
                Amount -= withdrawAmount;
                Console.WriteLine($"You withdrew: {withdrawAmount}");
                Console.WriteLine($"Total amount after withdrawal: {Amount}");
            }
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("\n---- Account Detail ----");
            Console.WriteLine($"Name of account holder: {Name}");
            Console.WriteLine($"Account number: {AccountNumber}");
            Console.WriteLine($"Amount in your account: {Amount}");
        }
    }

}

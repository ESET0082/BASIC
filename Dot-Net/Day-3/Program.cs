using System;

namespace Day_3
{
    internal class Program
    {
        static void GiveAccountDetail(int amount, string name, int account_number)
        {
            Console.WriteLine("\n----account Detail----");
            Console.WriteLine($"Name of account holder: {name}");
            Console.WriteLine($"Account number: {account_number}");
            Console.WriteLine($"Amount in your account: {amount}");
        }
        static void Withdraw()
        {
            Console.Write("Enter the amount to withdraw: ");
            int withdraw_amount = Convert.ToInt32(Console.ReadLine());
            if (amount < withdraw_amount)
            {
                Console.WriteLine("Insufficient balance.Please enter valid amoun");
            }
            else
            {
                amount -= withdraw_amount;
                Console.WriteLine($"You withdrew {withdraw_amount}");
                Console.WriteLine($"Total amount  after withdrew : {amount}");

            }
            
        }
        static void Deposit()
        {
            Console.Write("Enter the amount to deposit: ");
            int deposit_amount = Convert.ToInt32(Console.ReadLine());
            amount += deposit_amount;
            Console.WriteLine($"Total amount after deposit: {amount}");

        }
        static int amount = 0, account_number;
        static string name = "";

        static void Main(string[] args)
        {
            Random rnd = new Random();

            while (true)
            {
                Console.WriteLine("\n--- Options  ---");
                Console.WriteLine("1. Create a new bank account");
                Console.WriteLine("2. Deposit money");
                Console.WriteLine("3. Withdraw money");
                Console.WriteLine("4. Display account details");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                int choice;
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter your name: ");
                        name = Console.ReadLine();
                        account_number = rnd.Next(10000000, 999999999);  
                        Console.Write("Enter the initial amount to deposit: ");
                        int initial_amount;
                        initial_amount= Convert.ToInt32(Console.ReadLine());
                        amount += initial_amount;
                        Console.WriteLine($"Account created successfully! Your account number is {account_number}.");
                        Console.WriteLine($"Total amount : {amount}");
                        break;

                    case 2:
                        Deposit();
                        break;

                    case 3:
                        Withdraw();
                        break;

                    case 4:
                        GiveAccountDetail(amount, name, account_number);
                        break;

                    case 5:
                        Console.WriteLine("Exit from syatem!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                        
                }
            }
        }
    }
}

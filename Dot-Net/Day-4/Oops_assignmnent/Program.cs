
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = null;

            while (true)
            {
                Console.WriteLine("\n--- Options ---");
                Console.WriteLine("1. Create a new bank account");
                Console.WriteLine("2. Deposit money");
                Console.WriteLine("3. Withdraw money");
                Console.WriteLine("4. Display account details");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                int choice;

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        if (account != null)
                        {
                            Console.WriteLine("Account already exists.");
                            break;
                        }

                        Console.Write("Enter your name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter the initial amount to deposit: ");

                        if (!int.TryParse(Console.ReadLine(), out int initialAmount) || initialAmount < 0)
                        {
                            Console.WriteLine("Invalid amount. Please enter a positive number.");
                            break;
                        }

                        account = new BankAccount(name, initialAmount);
                        break;

                    case 2:
                        if (account == null)
                        {
                            Console.WriteLine("No account found. Please create one first.");
                            break;
                        }

                        Console.Write("Enter the amount to deposit: ");
                        if (int.TryParse(Console.ReadLine(), out int depositAmount))
                            account.Deposit(depositAmount);
                        else
                            Console.WriteLine("Invalid amount.");
                        break;

                    case 3:
                        if (account == null)
                        {
                            Console.WriteLine("No account found. Please create one first.");
                            break;
                        }

                        Console.Write("Enter the amount to withdraw: ");
                        if (int.TryParse(Console.ReadLine(), out int withdrawAmount))
                            account.Withdraw(withdrawAmount);
                        else
                            Console.WriteLine("Invalid amount.");
                        break;

                    case 4:
                        if (account == null)
                        {
                            Console.WriteLine("No account found. Please create one first.");
                            break;
                        }

                        account.DisplayAccountDetails();
                        break;

                    case 5:
                        Console.WriteLine("Exiting from system...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        
        }
    }
}

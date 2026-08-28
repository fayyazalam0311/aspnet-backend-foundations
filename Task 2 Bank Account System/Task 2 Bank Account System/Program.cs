using System;

class BankAccount
{
    public int AccountNumber { get; init; }
    public string HolderName { get; set; }
    public decimal Balance { get; private set;}

    public BankAccount(int accountNumber, String holderName, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        HolderName = holderName;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Amount deposited successfully. New balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Enter amount should be above 0");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Amount withdrawn successfully. New balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
        }
    }

}
static class Program
{ 
    static void Main(string[] args)
    {
        Console.WriteLine("******** Welcome to the Bank Account System! ********");

        List<BankAccount> AllStoredAccounts = new List<BankAccount>();

        bool running = true;

        while (running)
        {
            Console.WriteLine("\n*********** MAIN MENU ***********");
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Press 1 to Create a New Account\n2. Press 2 to Deposit\n3. Press 3 to Withdraw\n4. Press 4 to View Balance\n5. Press 5 to View All Accounts\n6. Press 6 to Exit");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter Account Number:");
                int accountNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Holder Name:");
                string holderName = Console.ReadLine();
                Console.WriteLine("Enter Initial Balance:");
                decimal initialBalance = Convert.ToDecimal(Console.ReadLine());

                
                if(!AllStoredAccounts.Any(e=> e.AccountNumber == accountNumber))
                {
                    BankAccount AccountCreated = new BankAccount(Convert.ToInt32(accountNumber), holderName, initialBalance);

                    AllStoredAccounts.Add(AccountCreated);
                    Console.WriteLine($"Account created successfully!");
                }
                else
                {
                    Console.WriteLine("Account already exist.");
                }


            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter Account Number:");
                int accountDeptInput = Convert.ToInt32(Console.ReadLine());

                if (AllStoredAccounts.Any(e => e.AccountNumber == accountDeptInput))
                {
                    BankAccount AccountForDeposit = AllStoredAccounts.First(e => e.AccountNumber == accountDeptInput);
                    Console.WriteLine("Enter the amount to deposit:");
                    decimal DepositAmount = Convert.ToDecimal(Console.ReadLine());
                    AccountForDeposit.Deposit(DepositAmount);
                    Console.WriteLine("Amount Deposited Successfully");
                    Console.WriteLine($"New Balance is {AccountForDeposit.Balance:C}");
                }
                else
                {
                    Console.WriteLine("Account not found. Enter a valid account number.");
                }
            }
            else if (choice == 3)
            { 
                Console.WriteLine("Enter Account Number:");
                int accountWithInput = Convert.ToInt32(Console.ReadLine());

                if (AllStoredAccounts.Any(e=> e.AccountNumber == accountWithInput ))
                {
                    BankAccount AccountForWithdraw =AllStoredAccounts.First(e => e.AccountNumber == accountWithInput);
                    Console.WriteLine("Enter the amount to withdraw:");
                    decimal WithdrawAmount = Convert.ToDecimal(Console.ReadLine());
                    AccountForWithdraw.Withdraw(WithdrawAmount);
                }
                else
                {
                    Console.WriteLine("Account not found. Enter a valid account number.");
                }
            }
            else if (choice == 4)
            {
                Console.WriteLine("Enter Account Number:");
                int accountBalInput = Convert.ToInt32(Console.ReadLine());

                if (AllStoredAccounts.Any( e => e.AccountNumber == accountBalInput))
                {
                    BankAccount BalanceAccount = AllStoredAccounts.First(e => e.AccountNumber == accountBalInput);
                    Console.WriteLine($"Your current balance is: {BalanceAccount.Balance:C}");
                }
                else
                {
                    Console.WriteLine("Account not found. Enter a valid account number.");
                }
            }
            else if (choice == 5)
            {
                Console.WriteLine("\nAll Stored Accounts:\n");
                foreach (BankAccount account in AllStoredAccounts)
                {
                    Console.WriteLine($"Account Number: {account.AccountNumber}, \nHolder Name: {account.HolderName}, \nBalance: {account.Balance:C}");
                }
            }
            else if (choice == 6)
            {
                Console.WriteLine("Exiting the program. Thank you for using the Bank Account System!");
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a valid option.");
            }

        }

    }

}


enum BankOperation : byte
{
    Balance=1,
    Withdrawal=2,
    Deposit=3,
    Exit=4
}

struct Std
{
    public int roll;
}
internal class MainClass
{
    private static void Main()
    {
        Account accountObj = new Account(10000);
        int amount = 0;
        BankOperation option;

        Console.WriteLine("Welcome to your bank account!\n");

    Retry:
        Console.WriteLine("Here are the services we provide:\n");

        Console.WriteLine("1. Balance Enquiry\n2. Withdrawal\n3. Deposit\n4. Exit\n");

        Console.Write("What would you like to do today?");

        option = (BankOperation)byte.Parse(Console.ReadLine());

        switch (option)
        {
            case BankOperation.Balance:
                Console.WriteLine("\n*****************************\n\nYour account balance is " + accountObj.GetBalance() + "\n\n*****************************\n");

                goto Retry;
            case BankOperation.Withdrawal:
                Console.Write("Enter the amount for withdrawal: ");
                amount = int.Parse(Console.ReadLine());
                accountObj.Withdraw(amount);
                goto case BankOperation.Balance;

            case BankOperation.Deposit:
                Console.Write("Enter the amount for deposit: ");
                amount = int.Parse(Console.ReadLine());
                accountObj.Deposit(amount);
                goto case BankOperation.Balance;

            case BankOperation.Exit:
                Console.WriteLine("\n\nThank you for visiting!\n\n");
                Environment.Exit(0);
                break;
            default:
                goto Retry;
        }
    }
}
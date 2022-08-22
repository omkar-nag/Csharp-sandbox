using System;


namespace CoffeeVendingMachine
{
    internal class MainClass
    {
        static void Main()
        {
            Byte cost = 0;
            Byte size;

            Console.WriteLine("Welcome to Coffee Vending Machine!");
            Console.WriteLine("Please select a size for your coffee.");
            Console.WriteLine("Press 1 for a 'SMALL'");
            Console.WriteLine("Press 2 for a 'MEDIUM'");
            Console.WriteLine("Press 3 for a 'LARGE'");

            Retry:
            size = Byte.Parse(Console.ReadLine());

            switch (size)
            {
                case 1:
                        cost += 25;
                        break;
                case 2:
                        cost += 15;
                        goto case 1;
                case 3:
                        cost += 10;
                        goto case 2;
                default:
                    Console.WriteLine("Please enter a valid choice.");
                    Console.WriteLine("Your choices are\n1 for a 'SMALL'\n2 for a 'MEDIUM'\n3 for a 'LARGE'");
                    goto Retry;
            }
            Console.WriteLine("Your total cost is {0}", cost);
            Console.WriteLine();
            Console.WriteLine("Thank you for stopping by!\n");
        }
    }
}
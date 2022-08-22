using System;

namespace NumberTable
{
    internal class MainClass
    {
        static void Main()
        {
            int i, j, m, n;
            Console.Write("Enter the First Number: ");
            i = int.Parse(Console.ReadLine());
            Console.Write("Enter the Second Number: ");
            j = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for(m = i; m < j + 1; m++)
            {
                for (n = 1; n < 6; n++)
                {
                    Console.WriteLine("{0} x {1} = {2}", m, n, m * n);
                }
                Console.WriteLine();
            }
        }
    }
}

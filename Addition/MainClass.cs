using System;

namespace Addition
{
    internal class MainClass {
        static void Main() {
            int i, j;
            Console.Write("Enter the first number: ");
            i = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            j = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", i, j, i + j);

        }
    }
}

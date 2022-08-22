using System;

namespace AscendingOrder
{
    internal class MainClass
    {
        static void Main()
        {
            int i, j, k;

            while ( true)
            {
                Console.Write("Enter the First Number: ");
                i = int.Parse(Console.ReadLine());
                Console.Write("Enter the Second Number: ");
                j = int.Parse(Console.ReadLine());
                Console.Write("Enter the Third Number: ");
                k = int.Parse(Console.ReadLine());

                if (i < j)
                {
                    if (k < i)
                    {
                        Console.WriteLine("{2} < {0} < {1}", i, j, k);
                    }
                    else if (k < j)
                    {
                        Console.WriteLine("{0} < {2} < {1}", i, j, k);
                    }
                    else
                    {
                        Console.WriteLine("{0} < {1} < {2}", i, j, k);
                    }
                }
                else
                {
                    if (k < j)
                    {
                        Console.WriteLine("{2} < {0} < {1}", j, i, k);
                    }
                    else if (k < i)
                    {
                        Console.WriteLine("{0} < {1} < {2}", j, k, i);
                    }
                    else
                    {
                        Console.WriteLine("{0} < {1} < {2}", j, i, k);
                    }
                }
            }
        }
    }
}

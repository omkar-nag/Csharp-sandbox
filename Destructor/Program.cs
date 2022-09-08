// using System;

// public class Employee
// {
//     public int ID;
//     public Employee(int ID)
//     {
//         this.ID = ID;
//         Console.WriteLine("Constructor for Employee " + this.ID);
//     }
//     ~Employee()
//     {
//         Console.WriteLine("---> Destructor for Employee " + this.ID);
//     }
// }

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Employee obj;

//         for (int i = 0; i < 30; i++)
//         {
//             // if (i % 10 == 0)
//             // {
//             //     System.Console.WriteLine("----------------------------------");
//             //     GC.Collect();
//             // }
//             GC.Collect();
//             obj = new Employee(i + 1);
//         }
//         System.Console.WriteLine("----------------------------------");
//     }
// }



using System;


namespace Destructor
{
    class Employee
    {
        public int Id;
        public Employee(int id)
        {
            this.Id = id;
            Console.WriteLine("Constructor for ID Employee {0}", this.Id);
        }
        ~Employee()
        {
            Console.WriteLine("Destructor for Employee ID {0}", this.Id);
        }
    }
    internal class MainClass
    {
        static void Main()
        {
            Employee obj;
            for (int i = 0; i < 100; i++)
            {
                //if (i % 10 == 0)
                //{
                //    Console.WriteLine("------------------------------------");
                //    GC.Collect();
                //}
                obj = new Employee(i + 1);
            }
            Console.WriteLine("--------------------------------------------");
            System.Threading.Thread.Sleep(50000);
        }
    }
}
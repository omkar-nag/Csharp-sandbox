using System;

public class Employee
{
    public int ID;
    public Employee(int ID)
    {
        this.ID = ID;
        Console.WriteLine("Constructor for Employee " + this.ID);
    }
    ~Employee()
    {
        Console.WriteLine("---> Destructor for Employee " + this.ID);
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Employee obj;

        for (int i = 0; i < 30; i++)
        {
            // if (i % 10 == 0)
            // {
            //     System.Console.WriteLine("----------------------------------");
            //     GC.Collect();
            // }
            GC.Collect();
            obj = new Employee(i + 1);
        }

        System.Console.WriteLine("----------------------------------");
        System.Threading.Thread.Sleep(50000);
    }

}


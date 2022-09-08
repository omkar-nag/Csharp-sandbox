public class Employee : IDisposable
{
    int id;
    public Employee(int i)
    {
        id = i;
        Console.WriteLine("Employee is being constructed for " + id);
    }
    ~Employee()
    {
        Console.WriteLine("Destructor is being called for " + id);
    }
    public void Dispose()
    {
        Console.WriteLine("Running cleanup code for " + id);
        GC.SuppressFinalize(this);
    }
}

internal class Program
{
    private static void Main()
    {
        Employee obj;
        for (int i = 0; i < 30; i++)
        {
            obj = new Employee(i + 1);
            obj.Dispose();
        }
        Console.WriteLine("*******");
        Employee[] empArray = new Employee[30];
        for (int i = 0; i < 30; i++)
        {
            empArray[i] = new Employee(i + 1);
        }
        using (Employee emp = new Employee(101))
        {
        };
    }
}
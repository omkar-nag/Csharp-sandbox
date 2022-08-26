using EmployeeArrayExericse;

class MainClass
{
    private static void Main()
    {
        Employee[] employees = new Employee[6];

        for (int i = 0; i < employees.Length; i++)
        {
            HR hrObj = new HR("Kishore N A", 15000, 10000, 500);
            employees[i] = hrObj;
        }
        for (int i = 0; i < employees.Length; i++)
        {
            Console.WriteLine(employees[i].PaySlip());
            Console.WriteLine(employees[i].PaySlip());

        }
    }
}
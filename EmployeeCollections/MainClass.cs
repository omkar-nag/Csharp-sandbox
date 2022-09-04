using EmployeeCollections;

internal class MainClass
{
    private static void Main(string[] args)
    {
        List<Employee> empList = new List<Employee>()
          { new Employee{EmpId=1,EmpName="FirstEmployee",Salary=6000},
            new Employee{EmpId=2,EmpName="SecondEmployee",Salary=10000},
            new Employee{EmpId=3,EmpName="ThirdEmployee",Salary=40000},
            new Employee{EmpId=4,EmpName="ForthEmployee",Salary=8000},
            new Employee{EmpId=5,EmpName="FifthEmployee",Salary=15000},
            };
        var below = empList.FindAll(n => n.Salary < 10000);
        Console.WriteLine("Employees below 10000 Salary");
        foreach(Employee emp in below)
        {
            Console.WriteLine(emp);
        }
        empList.Sort((n, x) => n.Salary.CompareTo(x.Salary));
        Console.WriteLine("Employees Sorted By Salary :");
        foreach( Employee emp in empList)
        {
            Console.WriteLine(emp);
        }
        empList.RemoveAll(n => n.Salary > 30000);
        Console.WriteLine("After removing Employee Greater than 30000");
        foreach (Employee emp in empList)
        {
            Console.WriteLine(emp);
        }
    }
}
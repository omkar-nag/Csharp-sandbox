namespace EmployeeCollections
{
    class MainClass
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

            Console.WriteLine("Employees below 10000 Salary:");
            var below10K = Employee.FilterBySalaryBelow(empList, 10000);
            foreach (Employee emp in below10K) Console.WriteLine(emp);

            
            Console.WriteLine("\nEmployees Sorted By Salary:");
            Employee.SortEmployeeSalary(empList);
            foreach( Employee emp in empList) Console.WriteLine(emp);


            Console.WriteLine("\nAfter removing Employee Greater than 30000:");
            Employee.RemoveBySalaryAbove(empList, 30000);
            foreach (Employee emp in empList)Console.WriteLine(emp);
        }
    }
}
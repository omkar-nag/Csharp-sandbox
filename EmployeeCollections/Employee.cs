namespace EmployeeCollections
{
    internal class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return String.Format($"{EmpId}\t {EmpName}\t {Salary}");
        }

<<<<<<< Updated upstream
        public static List<Employee> FilterBySalaryBelow(List<Employee> empList, int salary)
        {
            var below = empList.FindAll(n => n.Salary < salary);
=======
        public static List<Employee> SalaryBelow10K(List<Employee> empList)
        {
            var below = empList.FindAll(n => n.Salary < 10000);
>>>>>>> Stashed changes
            return below;
        }

        public static void SortEmployeeSalary(List<Employee> empList)
        {
            empList.Sort((n, x) => n.Salary.CompareTo(x.Salary));
        }

<<<<<<< Updated upstream
        public static void RemoveBySalaryAbove(List<Employee> empList, int salaryCap)
=======
        public static void RemoveEmployee(List<Employee> empList, int salaryCap)
>>>>>>> Stashed changes
        {
            empList.RemoveAll(n => n.Salary > salaryCap);
        }
    }
}

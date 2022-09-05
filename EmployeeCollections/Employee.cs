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

        public static List<Employee> FilterBySalaryBelow(List<Employee> empList, int salary)
        {
            var below = empList.FindAll(n => n.Salary < salary);
            return below;
        }

        public static void SortEmployeeSalary(List<Employee> empList)
        {
            empList.Sort((n, x) => n.Salary.CompareTo(x.Salary));
        }

        public static void RemoveBySalaryAbove(List<Employee> empList, int salaryCap)
        {
            empList.RemoveAll(n => n.Salary > salaryCap);
        }
    }
}

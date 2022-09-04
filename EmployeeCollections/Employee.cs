using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

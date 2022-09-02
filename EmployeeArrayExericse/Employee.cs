namespace EmployeeArrayExericse
{
    public class Employee
    {
        private static int _id = 1;
        private readonly int _empID;
        private string _name;
        private int _HRA;
        private int _DA;
        public Employee(string name, int hRA, int dA)
        {
            this._name = name;
            _empID = _id++;
            _HRA = hRA;
            _DA = dA;
        }
        protected virtual int CalculateSalary() { return _HRA + _DA;}
        public int EmpID { get { return _empID; }}
        public int HRA { get { return _HRA; }}
        public int DA { get { return _DA; }}
        public string Name { get { return _name; }}
        public virtual string PaySlip() { return ""; }
    }

    public class HR : Employee
    {
        private static string employeeType = "HR";
        private int specialAllowance;
        public HR(string name, int HRA, int DA, int specialAllowance) : base(name, HRA, DA)
        {
            this.specialAllowance = specialAllowance;
        }
        protected override int CalculateSalary()
        {
            return base.CalculateSalary() + this.specialAllowance;
        }
        public override string PaySlip()
        {
            return string.Format($"{EmpID}\t{Name} ({employeeType})\tHRA: {HRA}\tDA: {DA}\tSA: {specialAllowance}\tNetSalary: {CalculateSalary()}");
        }
    }
}

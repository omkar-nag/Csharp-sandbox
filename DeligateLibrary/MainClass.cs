namespace DeligateLibrary
{
    delegate void PrintDelegate();
    class MainClass
    {
        public delegate void PrintDeligate();
        private static void Main()
        {
            Employee employee = new Employee(1,"MyEmployee");
            Student student = new Student(2, "MyStudent");
            Customer customer = new Customer(3, "MyCustomer");
            PrintDelegate del = employee.Display;
            del+=student.Display;
            del+=customer.Display;
            Printer.Print(del);
        }
    }
}
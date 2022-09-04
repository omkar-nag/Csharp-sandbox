using DeligateLibrary;
using System;



delegate void PrintDelegate();
class MainClass
{
    public delegate void PrintDeligate();
    private static void Main()
    {
        Employee employee = new Employee(1,"Employee1");
        Student student = new Student(1, "Student1");
        Customer customer = new Customer(1, "Customer 1");
        PrintDelegate del = employee.Display;
        del+=student.Display;
        del+=customer.Display;
        Printer.Print(del);



      
    }
}
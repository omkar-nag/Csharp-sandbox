using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

public class Student
{
    public int ID;
    public string Name;
    public Student()
    {
    }
    public Student(int ID, string Name)
    {
        this.ID = ID;
        this.Name = Name;
    }
    public void Display()
    {
        Console.WriteLine($"{this.ID}\t{this.Name}");
    }
    private static void Main(string[] args)
    {
    }
}
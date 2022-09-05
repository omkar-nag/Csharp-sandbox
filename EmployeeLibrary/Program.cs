public class Employee
{
    public int ID;
    public string Name;
    public Employee()
    {
        this.ID = 0;
        this.Name = "";
    }
    public Employee(int ID,string Name)
    {
        this.ID = ID;
        this.Name = Name;
    }
    public  void  Display()
    {
        Console.WriteLine($"{this.ID}\t{this.Name}");
    }
    private static void Main()
    {

    }

}
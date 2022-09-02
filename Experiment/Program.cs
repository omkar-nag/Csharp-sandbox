public class c1
{
    public virtual void M1()
    {
        Console.WriteLine("C1");
    }
}
public class c2:c1
{
    public override void M1()
    {
        Console.WriteLine("c2");
    }
}

public class c3:c2
{
    public override void M1()
    {
        Console.WriteLine("C3");
    }
}

struct Program

{
    static void Main()

    {

        Console.WriteLine("Hello");

    }
}
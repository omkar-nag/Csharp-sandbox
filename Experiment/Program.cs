public class c1
{
    public virtual void M1()
    {
        Console.WriteLine("C1 :: M1");
    }
}
public class c2:c1
{
    public void M2()
    {
        Console.WriteLine("C2 :: M2");
    }

    public override void M1()
    {
        base.M1();
    }
}
internal class Program

{
    private static void Main()
    {
        c2 c = new c2();
        c.M2();
        c.M1();
        c1 cx = new c1();
        cx = c;
    }
}
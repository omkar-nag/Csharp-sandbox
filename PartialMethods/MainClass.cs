public partial class MyPartialClass {
    public partial int Method() {
        Console.WriteLine("HELLO, WORLD");
        return 0;
    }
    public void M() {
        Method();
    }
}

internal class MainClass
{
    private static void Main()
    {
        MyPartialClass obj = new MyPartialClass();
        obj.M();
    }
}
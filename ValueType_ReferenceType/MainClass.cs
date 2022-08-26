internal class MainClass
{
    struct S
    {
        public int id;
    }

    class C
    {
        public int id;
    }
    private static void Main()
    {
        S s1 = new S(); S s2 = new S();
        s1.id = 5; s1 = s2; s2.id = 8;
        Console.WriteLine(s1.Equals(s2));

        C c1 = new C(); C c2 = new C();
        c1.id = 5; c1 = c2; c2.id = 8;
        Console.WriteLine(c1.Equals(c2));
    }
}
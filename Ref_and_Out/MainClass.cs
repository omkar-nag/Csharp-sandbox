internal class MainClass

{
    static void CreateAlias(ref int x)
    {
        x = 100;
    }
    static void DontCreateAlias(int x)
    {
        x = 200;
    }
    static void UseOut(out int y)
    {
        y = 300;
    }

    public static bool DictFunc(string s)
    {
        return true;
    }
    private static void Main()
    {
        //int j;
        //UseOut(out j);
        //Console.WriteLine("Using Out: j = " + j);

        //CreateAlias(ref j);
        //Console.WriteLine("Using ref and creating alias: j = " + j);

        //j = 10;
        //DontCreateAlias(j);
        //Console.WriteLine("Using ref and NOT creating alias: j = " + j);

        //j = 10;
        //ref int z = ref j;
        //z = 6;
        //Console.WriteLine("Using ref within main func: j = " + j);

        //hashmap of functions
        Dictionary<int, Func<string, bool>> Pairs = new Dictionary<int, Func<string, bool>>();
        Console.WriteLine(Pairs[1]("hi"));
    }
}
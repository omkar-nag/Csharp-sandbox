using System.Security.Cryptography.X509Certificates;

internal class Program
{
    public static async void M()
    {
        VeryLongTask();
        VeryLongTask();
        for (int i = 0; i < 100; i++) Console.WriteLine(i);
        Console.WriteLine("Startng Long Task After Finishing Very Long Task");
        await Task.Run(new Action(LongTask));
        Console.WriteLine("-----------");
    }
    public static void LongTask()
    {
        Thread.Sleep(10000);
        Console.WriteLine("Long Task Over");
    }
    public static Task VeryLongTask()
    {
        return Task.Factory.StartNew(() =>
        {
            Thread.Sleep(5000);
            Console.WriteLine("Very Long Task Over");
        });
    }
    private static void Main(string[] args)
    {
        M();
        Console.WriteLine("Main Thread");
        Console.ReadKey();
    }
}
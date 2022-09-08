//using System.Threading.Tasks;
internal class Program
{
    private static void Main()
    {
        Task t1 = new Task(new Action(M));
        Task t2 = new Task(() => Console.WriteLine("HELLO 2"));
        Task t3 = new Task(delegate()
        {
            for (int i = 0; i < 100; i++) {
                Thread.Sleep(1);
            }
            Console.WriteLine("HELLO 3");
        });
        t1.Start();
        t2.Start();
        t3.Start();
        //Thread.Sleep(1500);
        //Console.ReadLine();

        Task<string> t;
    }
    private static void M()
    {
        Console.WriteLine("hello 1 ");
    }
}
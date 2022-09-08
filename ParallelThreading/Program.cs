using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

internal class Program
{
    private static void Main()
    {
        static void M() { Thread.Sleep(1000); Console.WriteLine("Done"); }
        static void N() { Thread.Sleep(2000); Console.WriteLine("Done Done"); }

        Task t1 = new Task(M);
        Task t2 = new Task(M); 
        Task t3 = new Task(M); 
        Task t4 = new Task(M); 
        Task t5 = new Task(N);

        List<Task> tasks = new List<Task>() {
            t1, t2, t3, t4, t5
        };
        Stopwatch stopwatch;

        //Serial Processing
        //stopwatch = new Stopwatch();
        //stopwatch.Start();
        //for (int i = 0; i < 9; i++) {
        //    Thread.Sleep(1000); 
        //}
        //stopwatch.Stop();
        //Console.WriteLine("Serial Time: " + stopwatch.Elapsed.Seconds.ToString());

        //Parallel Processing Without Tasks ( Threads Only )
        stopwatch = new Stopwatch();
        stopwatch.Start();
        Parallel.For(1, 10, i =>
        {
            Console.WriteLine(
                    "iteration: " + i + " processid: " + Thread.GetCurrentProcessorId()
                );
            Thread.Sleep(5000);
            Console.WriteLine("Iteration " + i + " has ended");
        });
        stopwatch.Stop();
        Console.WriteLine("Parallel Time: " + stopwatch.Elapsed.TotalMilliseconds.ToString());

        //Parallel Processing With Tasks
        //stopwatch = new Stopwatch();
        //stopwatch.Start();
        //Parallel.ForEach(tasks, t =>{t.Start();});
        //stopwatch.Stop();
        //Console.WriteLine("Parallel Time with tasks: " + stopwatch.Elapsed.Seconds.ToString());
        //Task.WaitAny(t1,t5);
    }
}
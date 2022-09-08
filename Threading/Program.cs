namespace Threads
{

    class Program
    {
        public static void M()
        {
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(200);
                Console.WriteLine("Thread M: {0}", i + 1);
            }
        }

        public static void N()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Thread Another: {0}", i + 1);
            }
        }

        public static void P(object s)
        {
            Console.WriteLine("Hello " + (string)s);
        }
        static void Main()
        {
            Thread t1 = new Thread(new ThreadStart(M));
            Thread t2 = new Thread(N);
            t1.Start();
            t2.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread Main: {0}", i);
            }

            Thread t3 = new Thread(new ParameterizedThreadStart(P));
            t3.Start("agsdsasas");
            Console.WriteLine("----------------------------------------------");
        }
    }
}
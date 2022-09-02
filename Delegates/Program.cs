using System.Collections.Generic;

namespace Delegate_experiment
{
    public delegate void MyDelegate(string s);

    internal class Program
    {
        private static void M(string? s, Action a)
        {
            //Console.WriteLine(s);
            Console.WriteLine("Hi");
            a();
        }
        private static void N()
        {
            Console.WriteLine("Bye");
        }
        private static void Main(string[] args)
        {

            List<Delegate> ld = new List<Delegate>();

            //ld.Add(M);
            //ld.Add(N);

            //int i = 0;

            //ld[0].DynamicInvoke("x");
            //ld[1].DynamicInvoke();

            //Console.WriteLine(ld[0].GetInvocationList()[0]);

            M("hi", N);

        }
    }
}

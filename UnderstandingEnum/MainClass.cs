using System;

namespace UnderstandingEnum
{
    enum Env : byte
    {
        QA=1,
        STAG,
        PROD
    }
    internal class MainClass
    {
        static void Main()
        {
            Env currentEnv;

            Console.WriteLine("Please choose the current environment");
            Console.WriteLine("1. QA\n2. STG\n3. PROD");
            currentEnv = (Env)byte.Parse(Console.ReadLine());

            switch (currentEnv)
            {
                case Env.QA:
                    Console.WriteLine("The current environment is QA");
                    break;
                case Env.STAG:
                    Console.WriteLine("The current environment is Staging");
                    break;
                case Env.PROD:
                    Console.WriteLine("The current environment is Production");
                    break;
                default:
                    Console.WriteLine("INVALID CHOICE");
                    break;
            }
        }
    }
}

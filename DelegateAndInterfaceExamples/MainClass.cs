namespace DelegateAndInterfaceExamples
{
    class MainClass
    {
        private static void Main()
        {

            Console.WriteLine("CLASS1: USES INTERFACE");
            Class1 calc = new Class1();
            CalculatorService.Calculate(calc);

            Console.WriteLine("\n\nCLASS2: USES DELEGATES:");

            Class2 calc2 = new Class2();
            calc2.Calculate();
        }
    }
}

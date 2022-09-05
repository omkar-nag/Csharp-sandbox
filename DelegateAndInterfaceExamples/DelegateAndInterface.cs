namespace DelegateAndInterfaceExamples
{

    delegate void MathDelegate(int a, int b);

    interface ICalculator
    {
        void Add(int a, int b);
        void Sub(int a, int b);
        void Mul(int a, int b);
        void Div(int a, int b);
    }

    class Class1 : ICalculator
    {
        void ICalculator.Add(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }
        void ICalculator.Sub(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }
        void ICalculator.Mul(int a, int b)
        {
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        }
        void ICalculator.Div(int a, int b)
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
        }
        public static void SayHello()
        {

            Console.WriteLine("hello");
        }
    }

    class Class2
    {
        private void Add(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }
        private void Sub(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }
        private void Mul(int a, int b)
        {
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        }
        private void Div(int a, int b)
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
        }
        public void Calculate()
        {
            MathDelegate d = new MathDelegate(Add);
            d += Sub;
            d += Mul;
            d += Div;

            CalculatorService.DoCalculation(d);
        }
    }

    class CalculatorService
    {
        public static void Calculate(ICalculator calc)
        {
            calc.Add(2, 3);
            calc.Sub(2, 3);
            calc.Mul(2, 3);
            calc.Div(2, 3);
        }
        public static void DoCalculation(MathDelegate d)
        {
            d(6, 2);
            Console.WriteLine("\nUsing 'DynamicInvoke':");
            Delegate[] l = d.GetInvocationList();
            l[0].DynamicInvoke(6, 2);
        }
    }
}
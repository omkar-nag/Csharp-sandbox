namespace Assignment_Encapsulation
{

    enum Operator : byte
    {
        Addition=1,
        Subtraction,
        Division,
        Multiplication
    }

    public class Calculator
    {
        private int _num1, _num2;
        private float _res;
        private Operator _op;

        public bool ValidateData(int num1, int num2)
        {
            if (!ValidateNumbers(num1, num2)) {
                return false;
            }
            GetData(num1, num2);
            return true;
        }
        private bool ValidateNumbers(int num1, int num2)
        {
            return num1 > 0 && num2 > 0;
        }
        private void GetData(int num1, int num2)
        {
            this._num1 = num1;
            this._num2 = num2;
        }
        public bool ValidateChoice(byte op)
        {

            Operator opr = (Operator) op;

            if (Enum.IsDefined(typeof(Operator), opr))
            {
                this._op = opr;
                Calculate();

                return true;
            }
            return false;
        }

        private void Calculate()
        {
            switch (this._op)
            {
                case Operator.Addition:
                    Add();
                    break;
                case Operator.Subtraction:
                    Subtract();
                    break;
                case Operator.Division:
                    Divide();
                    break;
                case Operator.Multiplication:
                    Multiply();
                    break;
                default:
                    Console.WriteLine("SYSTEM ERROR");
                    return;
            }
            PrintData();
        }
        private void Add()
        {
            this._res = this._num1 + this._num2;
        }
        private void Subtract()
        {
            this._res = Math.Abs(this._num1 - this._num2);
        }
        private void Divide()
        {
            this._res = this._num1 / this._num2;
        }
        private void Multiply()
        {
            this._res = this._num1 * this._num2;
        }
        private void PrintData()
        {
            Console.WriteLine("Result = " + _res);
        }
    }
}

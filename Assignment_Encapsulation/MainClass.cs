/*
ASSIGNMENT BASED	ON	ENCAPSULATION
Design and Develop a project based on following specification
Project Name is Encapsulationn
Calculator Class to perform addition, subtraction, multiplication and division operation
User has to enter two positive integer numbers which will be validated and valid number will be stored in object. If wrong input is given print meaningful message and give option to input again
After valid data is entered user will enter choice to perform operations. Choice should be from options given only if wrong give another chance
Only calculate method will be called by user for any operation which should have no input parameter. Based on choice the operation will be performed and result will be stored in object. To display result another Display method is called.
Method to implement:
GetData()       Input
PrintData()     Output
Calculate()     Called by user for operation
Add()			Addition
Subtract()      Subtraction
Multiply()      Multiplication
Divide()        Division
ValidateData()  To validate Input Data
ValidateChoice()	To Validate Choice
Encapsulation all functions and data by Calculator Class
Encapsulate GetData() Method by Validate Method()
Encapsulate Add(), Subtract(), Multiply(), Divide() by Method Calculate()
Encapsulate Calculate() by Method ValidateChoice()
Client Code Main() Method will be in separate Class by Name MainClass
Use switch case to give choices to user for operations
Use do-while to give option again in case of invalid data entered.
Code should be well commented
Add a documentation page for project description in project folder
*/


namespace Assignment_Encapsulation
{
    public class MainClass
    {
        public static void Main()
        {
            int num1, num2;
            byte op;

            bool dataflag, opflag;

            do
            {

                Console.WriteLine("********* Welcome to Calulator *********");
                Calculator calc = new Calculator();

                do
                {
                    Console.Write("Enter the first number: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    num2 = int.Parse(Console.ReadLine());
                    dataflag = calc.ValidateData(num1, num2);

                    if (!dataflag)
                    {
                        Console.WriteLine("Invalid operands! Please enter 2 positive integers.");
                    }
                } while (!dataflag);

                do
                {
                    Console.WriteLine("Please enter the number against the desired operator.");
                    Console.WriteLine("Your valid choices are:\n1. Addition\n2. Subtraction\n3. Division\n4. Multiplication");
                    op = byte.Parse(Console.ReadLine());
                    opflag = calc.ValidateChoice(op);
                    if (!opflag)
                    {
                        Console.WriteLine("Invalid operator! Please enter a valid number.");
                    }
                } while (!opflag);


                Console.WriteLine("Do you want to start over? Y/N");
            } while (Console.ReadLine() == "y");
        }
    }
}

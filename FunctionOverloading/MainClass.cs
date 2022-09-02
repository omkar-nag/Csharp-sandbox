using AreaCalculatorLibrary;

enum Shape: byte
{
    Circle=1,
    Square,
    Rectangle
}

internal class MainClass
{
    private static void Main(string[] args)
    {
        Shape shape;
        float res = -1;
        Console.WriteLine("Welcome to Area Calculator.");
        Console.WriteLine("Please select a desired shape by entering the associated number: ");
        Console.WriteLine("1. Circle\n2. Square\n3. Rectangle");

        shape = (Shape) byte.Parse(Console.ReadLine());
        //Console.WriteLine(shape + " " + (byte) shape);

        switch(shape)
        {
            case Shape.Circle:
                float r;
                Console.WriteLine("Please enter the radius of the circle");
                r = float.Parse(Console.ReadLine());
                res = AreaCalculator.Area(r);
                break;
            
            case Shape.Square:
                byte s;
                Console.WriteLine("Please enter the side length of the square");
                s = byte.Parse(Console.ReadLine());
                res = AreaCalculator.Area(s);
                break;
            
            case Shape.Rectangle:
                byte l,h;
                Console.WriteLine("Please enter the length of the square");
                l = byte.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the height of the square");
                h = byte.Parse(Console.ReadLine());
                res = AreaCalculator.Area(l,h);
                break;
        }

        Console.WriteLine("The area of the {0} is {1}", shape, res);
    }
}
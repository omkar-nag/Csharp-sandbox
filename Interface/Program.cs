interface Shape
{
    void Area();
}
class Circle : Shape
{
    public void Area()
    {
        Console.WriteLine("Calculating Area of Circle");
    }
}
class Rectangle : Shape
{
    public void Area()
    {
        Console.WriteLine("Calculating Area of Rectangle");
    }
}
class Square : Shape
{
    public void Area()
    {
        Console.WriteLine("Calculating Area of Square ");
    }
}


internal class MainClass
{
    private void Main()
    {
        Shape[] shapes = new Shape[10];
        shapes[0] = new Rectangle();
        shapes[1] = new Circle();
        shapes[2] = new Square();
        for (int i = 0; i < 3; i++)
        {
            shapes[i].Area();
        }
    }
}
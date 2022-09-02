abstract public class Shape
{
    public virtual void Draw() {}
}

public class Circle : Shape
{
    public override void Draw() { Console.WriteLine("Drawing a circle..."); }
}

public class Rectange : Shape
{
    public virtual new void Draw() { Console.WriteLine("Drawing a rectangle..."); }
}
public class Square : Rectange
{
    public override void Draw() { Console.WriteLine("Drawing a square..."); }
}

internal class Program
{
    private static void Main()
    {
        Shape c = new Circle();
        Rectange r = new Rectange();
        Rectange s = new Square();

        //c.Draw();
        s.Draw();
        r.Draw();
    }
}
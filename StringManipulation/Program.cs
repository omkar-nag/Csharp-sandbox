using System.Text;
internal class Program
{
    private static void Main()
    {
        int i = 5;

        Console.WriteLine(object.ReferenceEquals(i, i));
        string x = "Hello World!";
        StringBuilder y = new StringBuilder("Hello World!");
        Console.WriteLine(x.GetHashCode() + " " + y.GetHashCode());

        //Console.WriteLine(y.Substring(x.IndexOf('W')));
    }
}
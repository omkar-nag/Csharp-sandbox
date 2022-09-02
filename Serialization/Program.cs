using System.Runtime.Serialization.Formatters.Binary;

using System.Xml.Serialization;

[Serializable]
public class Product
{
    public int i=100000000;
    private int j=2000000000;
    public Product() { }
    public Product(int i, int j)
    {
        this.i = i;
        this.j = j;
    }
    public int getJ
    {
        get
        {
            return j;
        }
    }
}

internal class Program
{
    private static void Main(string[] args)
    {

        Product p = new Product(1, 2);

        FileStream fs_bf = new FileStream(@"C:\Users\Admin\Desktop\abc.bin", FileMode.Create, FileAccess.Write);
        FileStream fs_xml = new FileStream(@"C:\Users\Admin\Desktop\abc.xml", FileMode.Create, FileAccess.Write);


        XmlSerializer xs = new XmlSerializer(typeof(Product));
        BinaryFormatter bf = new BinaryFormatter();
        
        
        xs.Serialize(fs_xml, p);
        bf.Serialize(fs_bf, p);
        
        
        fs_xml.Close();
        fs_bf.Close();

        FileStream fs_1 = new FileStream(@"C:\Users\Admin\Desktop\abc.bin", FileMode.Open, FileAccess.Read);
        FileStream fs_2 = new FileStream(@"C:\Users\Admin\Desktop\abc.xml", FileMode.Open, FileAccess.Read);

        Product obj2 = (Product)bf.Deserialize(fs_1);
        Product obj1 = (Product)xs.Deserialize(fs_2);


        Console.WriteLine(obj1.i + "  " + obj1.getJ);
        Console.WriteLine(obj2.i + "  " + obj2.getJ);
    }
}
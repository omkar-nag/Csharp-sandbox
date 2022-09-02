using Abstract_Polymorphism;

internal class Program
{
    private static void Main()
    {
        Animal[] animals = new Animal[3];
        animals[0] = new Cat();
        animals[1] = new Dog();
        animals[2] = new Cow();
        foreach (Animal a in animals) a.Speak();
    }
}
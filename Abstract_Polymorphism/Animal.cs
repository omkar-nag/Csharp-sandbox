namespace Abstract_Polymorphism
{
    abstract internal class Animal
    {
        public abstract void Speak();
    }
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Woof");
        }
    }
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Meow");
        }
    }
    class Cow : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Moo");
        }
    }
}

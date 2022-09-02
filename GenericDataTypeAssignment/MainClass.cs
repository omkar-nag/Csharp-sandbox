using System.Collections;

namespace Employee_Collections
{
    class Employee
    {
        public readonly int Id;
        private static int _counter = 0;
        public readonly string Name;

        public Employee(string name)
        {
            Id = _counter++;
            Name = name;
        }

        public override string ToString()
        {
            return this.Id + ". " + this.Name;
        }
    }

    internal class MainClass
    {
        static void Main(string[] args)
        {
            ArrayList empal = new ArrayList(5);
            empal.Add(new Employee("Ram"));
            empal.Add(new Employee("Sham"));
            empal.Add(new Employee("Shyam"));
            empal.Add(new Employee("Suri"));

            Console.WriteLine("ARRAY LIST:");
            foreach (object o in empal)
            {
                Console.WriteLine(o);

            }

            IEnumerator en = empal.GetEnumerator();

            Console.WriteLine("\n\nUSING ENUMERATOR");

            while (en.MoveNext())
            {
                Console.WriteLine(en.Current.ToString());
            }

            List<Employee> list = new List<Employee>(10);

            list.Add(new Employee("Sham"));
            list.Add(new Employee("Sham"));
            list.Add(new Employee("Sham"));

            en = list.GetEnumerator();
            Console.WriteLine("\n\nGENERIC LIST:");

            while (en.MoveNext())
            {
                Console.WriteLine(en.Current);
            }

            SortedList sl = new SortedList();
            for (int i = 0; i < 5; i++)
            {
                Employee t = new Employee("emp" + i.ToString());

                sl.Add(t.Id, t.Name);
            }
            
            Console.WriteLine("\n\nSORTED LIST:");

            foreach (int item in sl.Keys)
            {
                Console.WriteLine(sl[item]); ;
            }

            Dictionary<int, string> sb = new Dictionary<int, string>();

            for (int i = 0; i < 5; i++)
            {
                Employee t = new Employee("emp" + i.ToString());

                sb.Add(t.Id, t.Name);
            }
            Console.WriteLine("\n\nGENERIC HASH TABLE:");
            foreach (string o in sb.Values)
            {
                Console.WriteLine(o);
            }
        }
    }
}
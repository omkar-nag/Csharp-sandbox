namespace genericmethods
{


struct Student : IComparable
    {
        public int id = 0;

        public Student(int id)
        {
            this.id = id;
        }
        public int CompareTo(object student)
        {
            return this.id.CompareTo(((Student) student).id);
        }
    }
internal class Program
{

    public static void Swap<T>(ref T i, ref T j)
    {
        T temp = i;
        i = j;
        j = temp;
    }
    private static void Main(string[] args)
    {
            //int i, j;
            //Console.Write("Enter the first number to swap: ");
            //i = int.Parse(Console.ReadLine());
            //Console.Write("Enter the second number to swap: ");
            //j = int.Parse(Console.ReadLine());
            //Console.WriteLine("BEFORE SWAP: {0} {1}", i, j);
            //Swap(ref i, ref j);
            //Console.WriteLine("AFTER SWAP : {0} {1}", i, j);

            Student[] students = new Student[5];
            students[0] = new Student(4);
            students[1] = new Student(3);
            students[2] = new Student(1);
            students[3] = new Student(2);

            Array.Sort(students);
            foreach(Student s in students)
            {
                Console.WriteLine(s.id);
            }

    }
}
}
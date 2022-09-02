namespace SortingWithIcomparable
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
            return this.id.CompareTo(((Student)student).id);
        }
        public override string ToString()
        {
            return this.id + " ";
        }
    }
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Student[] yourArray = new Student[5];
            IComparable[] yourArray = new IComparable[5];
            yourArray[0] = new Student(3);
            yourArray[1] = new Student(5);
            yourArray[2] = new Student(2);
            yourArray[3] = new Student(4);
            yourArray[4] = new Student(1);
            IComparableSorting.Sort(yourArray);

            foreach(Student s in yourArray)
            {
                Console.WriteLine(s);
            }

        }
    }
}
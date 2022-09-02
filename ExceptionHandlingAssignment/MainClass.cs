using ExceptionHandlingAssignment;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

internal class MainClass
{

    class Student
    {
        private int _id;
        private static int count = 0;
        private string? _name;
        private int? _marks;

        public int ID {  
            get { return _id; }
        }

        public Student(string Name, int marks)
        {

            if (ValidateMarks(marks))
            {
                _id = ++count;
                _name = Name;
                _marks = marks;
                Console.WriteLine("Successfully created student: " + this.ToString() );
                return;
            }

            Console.WriteLine("\n\nFailed to create student. Please ensure marks are between 0 and 100.\n\n");
        }

        public override string ToString()
        {
            return _id  + "  " + _name;
        }

        private bool ValidateMarks(int marks)
        {

            if (marks < 0)
            {
                throw new MarksNegativeException(marks);
            }
            if (marks > 100)
            {
                throw new MarksOverException(marks);
            }
            return true;
        }


    }
    private static void Main(string[] args)
    {

        Student s = new Student("Gopi", 100);
    
    }
}
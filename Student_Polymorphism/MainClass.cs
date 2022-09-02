using Student_Polymorphism;

class MainClass
{
    public static void Main()
    {
        byte choice;
        int counter = 0;
        Console.WriteLine("Welcome to School!\n");
        Student[] students = new Student[50];

        do
        {
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine("1. Create a student\n2. Student marksheet\n3. All Students' Marksheets");
            choice = byte.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    string name;
                    int englishMarks, streamMarks;
                    byte stream;
                    bool flag = false;
                    Console.WriteLine("\nPlease enter the new student details.");
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Please enter the marks");
                    Console.Write("English Marks:");
                    englishMarks = int.Parse(Console.ReadLine());
                    do
                    {
                        flag = true;
                        Console.WriteLine("Enter the stream:\n1. Science\t2. Commerce\t3. Arts");
                        Console.Write("Stream: ");
                        stream = byte.Parse(Console.ReadLine());

                        switch (stream)
                        {
                            case 1:
                                Console.Write("Science Marks:");
                                streamMarks = int.Parse(Console.ReadLine());
                                Science scienceStudent = new Science(streamMarks, name, englishMarks);
                                students[counter++] = scienceStudent;
                                Console.WriteLine(  scienceStudent.printMarksSheet());
                                break;
                            case 2:
                                Console.Write("Commerce Marks:");
                                streamMarks = int.Parse(Console.ReadLine());
                                Commerce commerceStudent = new Commerce(streamMarks, name, englishMarks);
                                students[counter++] = commerceStudent;
                                Console.WriteLine( commerceStudent.printMarksSheet());
                                break;
                            case 3:
                                Console.Write("Arts Marks:");
                                streamMarks = int.Parse(Console.ReadLine());
                                Arts artsStudent = new Arts(streamMarks, name, englishMarks);
                                students[counter++] = artsStudent;
                                Console.WriteLine(  artsStudent.printMarksSheet());
                                break;
                            default:
                                Console.WriteLine("Invalid stream! Want to try again? y/n");
                                flag = Console.ReadLine() == "y";
                                break;
                        }
                    } while(!flag);
                    break;
                case 2:
                    Console.WriteLine("Please enter roll number");
                    int rollNumber;
                    rollNumber = int.Parse(Console.ReadLine());
                    for (int i = 0; i < counter; i++)
                    {   if (students[i]._rollNumber == rollNumber)
                        {
                            Console.WriteLine(students[i].printMarksSheet());
                            break;
                        }
                    }
                    break;
                case 3:
                    for (int i = 0; i< counter; i++)
                    {
                        Console.WriteLine(students[i].printMarksSheet());
                    }
                    break;
            }
        } while (true);
    }
}
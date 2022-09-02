using Indexer;

namespace Indexers
{
    class MainClass
    {
        static void Main()
        {
            Employee objEmp = new Employee();

            objEmp[0] = "A";
            objEmp[1] = "B";
            objEmp[2] = "C";
            objEmp[3] = "D";
            objEmp[4] = "E";


            for (int i = 0; i < Employee.size; i++)
            {
                Console.WriteLine(objEmp[i]);
            }


            Console.WriteLine("----------------------------------");


            objEmp["A"] = 104;
            objEmp["B"] = 105;
            objEmp["C"] = 106;
            objEmp["D"] = 107;
            objEmp["X"] = 108;


            for (int i = 0; i < Employee.size; i++)
            {
                Console.WriteLine(objEmp[objEmp[i]]);
            }

            Console.WriteLine("----------------------------------");

            Console.WriteLine(objEmp["D"]);
        }
    }
}

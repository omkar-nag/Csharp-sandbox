namespace DeligateLibrary
{
    internal class Printer
    {
        public static void Print(PrintDelegate printDetails)
        {
            printDetails();
        }
    }
}

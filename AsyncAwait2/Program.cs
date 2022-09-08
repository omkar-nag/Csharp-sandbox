internal class Program
{
    static void Main()
    {
        Task task = new Task(CallMethod);
        task.Start();
        task.Wait();
        Console.WriteLine("***************End of main method***************");
        Console.ReadLine();
    }
    static async void CallMethod()
    {
        string filePath = @"C:\Users\user\Desktop\abc.txt";
        Task<int> task = ReadFile(filePath);
        int result = await task;
        Console.WriteLine("Total length = " + result);

        Console.WriteLine("Other work 1");
        Console.WriteLine("Other work 2");
        Console.WriteLine("Other work 3");
        Console.WriteLine("Last work 1");
        Console.WriteLine("Last work 2");
    }
    static async Task<int> ReadFile(string filePath)
    {
        int length = 0;
        Console.WriteLine("Starting File Reading...");
        using (StreamReader sr = new StreamReader(filePath))
        {
            string s = await sr.ReadToEndAsync();
            length = s.Length;
        }
        Console.WriteLine("File Reading Completed.");
        return length;
    }
}
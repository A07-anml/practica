namespace task_2;

public static class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Programs:");
            Console.WriteLine("[T] - Train");
            Console.WriteLine("[Q] - Finish");
            string? command = Console.ReadLine();
            switch (command.ToUpper())
            {
                case "T":
                    Console.Clear();
                    TrainProgram.Run();
                    continue;
                case "Q":
                    Console.Clear();
                    Console.WriteLine("Finish");
                    break;
                default:
                    Console.WriteLine("ERROR");
                    continue;
            }

            break;
        }
    }
}

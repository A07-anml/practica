namespace task_2;

public static class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Programs:");
            Console.WriteLine("[S] - Student");
            Console.WriteLine("[T] - Train");
            Console.WriteLine("[N] - Numbers");
<<<<<<< HEAD
=======
            Console.WriteLine("[C] - Counter");
>>>>>>> counter
            Console.WriteLine("[Q] - Finish");
            string? command = Console.ReadLine();
            switch (command.ToUpper())
            {
                case "S":
                    Console.Clear();
                    StudentProgram.Run();
                    continue;
                case "T":
                    Console.Clear();
                    TrainProgram.Run();
                    continue;
                case "N":
                    Console.Clear();
                    NumbersProgram.Run();
<<<<<<< HEAD
=======
                    continue;
                case "C":
                    Console.Clear();
                    CounterProgram.Run();
>>>>>>> counter
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

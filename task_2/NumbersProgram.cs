namespace task_2;

internal static class NumbersProgram
{
    public static void Run()
    {
        var numbers = new Numbers();
        while (true)
        {
            Console.WriteLine("Commands:");
            Console.WriteLine("[E] - Edit");
            Console.WriteLine("[P] - Print");
            Console.WriteLine("[Q] - Exit");
            string? command = Console.ReadLine();
            switch (command.ToUpper())
            {
                case "E":
                    Console.Clear();
                    Edit(numbers);
                    continue;
                case "Q":
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("ERROR");
                    continue;
            }

            break;
        }
    }
    private static void Edit(Numbers numbers)
    {
        while (true)
        {
            Console.WriteLine("Numbers:");
            Console.WriteLine("[F] - First");
            Console.WriteLine("[S] - Second");
            Console.WriteLine("[Q] - Exit");
            string? property = Console.ReadLine();
            switch (property.ToUpper())
            {
                case "F":
                    Console.Clear();
                    Console.Write("Write number: ");
                    numbers.SetFirst(int.Parse(Console.ReadLine() ?? "0"));
                    Console.Clear();
                    break;
                case "S":
                    Console.Clear();
                    Console.Write("Write number: ");
                    numbers.SetSecond(int.Parse(Console.ReadLine() ?? "0"));
                    Console.Clear();
                    break;
                case "Q":
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("ERROR");
                    continue;
            }

            break;
        }
    }
}
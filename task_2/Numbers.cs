namespace task_2;

public class Numbers
{
    private int First { get; set; }

    public void PrintFirst()
    {
        Console.WriteLine($"First: {First}");
    }
    public int SetFirst(int value)
    {
        First = value;
        return First;
    }
}
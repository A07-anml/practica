namespace task_2;

public class Numbers
{
    private int First { get; set; }
    private int Second { get; set; }

    public int Sum()
    {
        return First + Second;
    }

    public int Maximal()
    {
        return int.Max(First, Second);
    }
}
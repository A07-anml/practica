namespace task_2;

public class Numbers
{
    private int First { get; set; }
    private int Second { get; set; }

    public int SetFirst(int value)
    {
        First = value;
        return First;
    }
    public int SetSecond(int value)
    {
        Second = value;
        return Second;
    }
}
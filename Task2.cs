namespace BasicsTanlash;

public static class Task2
{
    public static void Run()
    {
        int x = 15;
        int y = 10;

        string result = (x > y) ? "x is greater than y" : (x < y) ? "x is less than y" : "x is equal to y";

        Console.WriteLine(result);
    }
}

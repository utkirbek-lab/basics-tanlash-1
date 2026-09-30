namespace BasicsTanlash;

/// <summary>
/// 2-vazifa. Ternary operator bilan yozilgan ifodani if-else yordamida ifodalash.
/// </summary>
public static class Task2
{
    public static string Compare(int x, int y)
    {
        string result;

        if (x > y)
        {
            result = "x is greater than y";
        }
        else if (x < y)
        {
            result = "x is less than y";
        }
        else if (x == y)
        {
            result = "x is equal to y";
        }
        else
        {
            result = "x and y are not comparable";
        }

        return result;
    }

    public static void Run()
    {
        int x = 15;
        int y = 10;

        string result = Compare(x, y);

        Console.WriteLine(result);
    }
}

namespace BasicsTanlash;

public static class Task3
{
    public static string Translate(string uzDay)
    {
        if (uzDay == "dushanba") return "Monday";
        if (uzDay == "seshanba") return "Tuesday";
        if (uzDay == "chorshanba") return "Wednesday";
        return "Unknown";
    }

    public static void Run()
    {
        Console.Write("Hafta kunini kiriting: ");
        string input = Console.ReadLine() ?? string.Empty;
        Console.WriteLine(Translate(input));
    }
}

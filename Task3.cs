namespace BasicsTanlash;

public static class Task3
{
    public static void Run()
    {
        Console.Write("Hafta kunini kiriting: ");
        string input = Console.ReadLine() ?? string.Empty;

        switch (input)
        {
            case "dushanba":
                Console.WriteLine("Monday");
                break;
            case "seshanba":
                Console.WriteLine("Tuesday");
                break;
            case "juma":
                Console.WriteLine("Friday");
                break;
        }
    }
}

namespace BasicsTanlash;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Basics.Tanlash — 1-amaliy vazifa");
        Console.WriteLine("1 - String ustida amallar");
        Console.WriteLine("2 - Ternary operatorni if-else bilan ifodalash");
        Console.WriteLine("3 - Hafta kunini ingliz tiliga o'girish (switch expression)");
        Console.Write("Vazifa raqamini tanlang: ");

        string? choice = Console.ReadLine()?.Trim();

        switch (choice)
        {
            case "1":
                Task1.Run();
                break;
            case "2":
                Task2.Run();
                break;
            case "3":
                Task3.Run();
                break;
            default:
                Console.WriteLine("Noto'g'ri tanlov.");
                break;
        }
    }
}

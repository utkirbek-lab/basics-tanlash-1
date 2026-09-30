namespace BasicsTanlash;

/// <summary>
/// 3-vazifa. O'zbek tilida kiritilgan hafta kunini ingliz tiliga o'girish.
/// Switch expression dan foydalanilgan.
/// </summary>
public static class Task3
{
    public static string Translate(string uzDay)
    {
        string day = uzDay.Trim().ToLower().Replace('‘', '\'').Replace('’', '\'').Replace('`', '\'');

        return day switch
        {
            "dushanba" => "Monday",
            "seshanba" => "Tuesday",
            "chorshanba" => "Wednesday",
            "payshanba" => "Thursday",
            "juma" => "Friday",
            "shanba" => "Saturday",
            "yakshanba" => "Sunday",
            _ => "Noto'g'ri hafta kuni kiritildi"
        };
    }

    public static void Run()
    {
        Console.Write("Hafta kunini kiriting (o'zbekcha): ");
        string input = Console.ReadLine() ?? string.Empty;

        Console.WriteLine(Translate(input));
    }
}

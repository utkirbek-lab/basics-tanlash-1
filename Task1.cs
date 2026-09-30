namespace BasicsTanlash;

/// <summary>
/// 1-vazifa. String ustida amallar.
/// Agar kiritilgan son str uzunligidan katta bo'lsa — str katta harflarga,
/// aks holda kichik harflarga o'giriladi.
/// </summary>
public static class Task1
{
    public static string Convert(int x, string str)
    {
        if (x < str.Length)
        {
            return str.ToUpper();
        }
        else
        {
            return str.ToLower()
        }
    }

    public static void Run()
    {
        Console.Write("str = ");
        string str = Console.ReadLine() ?? string.Empty;

        Console.Write("x = ");
        int x;
        while (!int.TryParse(Console.ReadLine(), out x))
        {
            Console.Write("Iltimos, butun son kiriting. x = ");
        }

        Console.WriteLine($"Natija: \"{Convert(x, str)}\"");
    }
}

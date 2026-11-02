internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()!);
        int[] damages = new int[n];
        for (int i = 0; i < n; i++)
        {
            damages[i] = int.Parse(Console.ReadLine()!);
        }

        int hits = 0;
        int misses = 0;
        int maxDamage = damages[0];
        for (int i = 0; i < damages.Length; i++)
        {
            if (damages[i] > 0)
            {
                hits++;
            }
            else
            {
                misses++;
            }

            if (damages[i] > maxDamage)
            {
                maxDamage = damages[i];
            }
        }

        Console.WriteLine($"Tong sat thuong: {CalculateTotalDamage(damages)}");
        Console.WriteLine($"So don danh trung: {hits}");
        Console.WriteLine($"So don danh truot: {misses}");
        Console.WriteLine($"Sat thuong lon nhat: {maxDamage}");
    }

    static int CalculateTotalDamage(int[] damages)
    {
        int totalDamage = 0;
        for (int i = 0; i < damages.Length; i++)
        {
            totalDamage += damages[i];
        }
        return totalDamage;
    }
}

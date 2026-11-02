internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()!);
        string leaderName = "";
        int highestScore = -1;

        for (int i = 0; i < n; i++)
        {
            string name = Console.ReadLine()!;
            int kills = int.Parse(Console.ReadLine()!);
            int assists = int.Parse(Console.ReadLine()!);
            int score = CalculateScore(kills, assists);
            Console.WriteLine($"{name}: {score} diem");

            if (score > highestScore)
            {
                highestScore = score;
                leaderName = name;
            }
        }

        Console.WriteLine($"Dan dau: {leaderName}");
        Console.WriteLine($"Diem cao nhat: {highestScore}");
    }

    static int CalculateScore(int kills, int assists)
    {
        return kills * 100 + assists * 30;
    }
}

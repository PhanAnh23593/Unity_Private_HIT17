internal class Program
{
    static void Main(string[] args)
    {
        int initialHp = int.Parse(Console.ReadLine()!);
        int armor = int.Parse(Console.ReadLine()!);
        int n = int.Parse(Console.ReadLine()!);
        int[] attacks = new int[n];

        for (int i = 0; i < n; i++)
        {
            attacks[i] = int.Parse(Console.ReadLine()!);
        }

        int currentHp = initialHp;
        int processedAttacks = 0;
        for (int i = 0; i < attacks.Length; i++)
        {
            int damage = CalculateDamage(attacks[i], armor);
            currentHp = CalculateRemainingHp(currentHp, damage);
            processedAttacks++;
            Console.WriteLine($"Don {i + 1}: Sat thuong {damage} | HP {currentHp}");

            if (currentHp == 0)
            {
                break;
            }
        }

        Console.WriteLine($"Trang thai: {(currentHp > 0 ? "Song sot" : "Da bi ha")}");
        Console.WriteLine($"So don da xu ly: {processedAttacks}");
        Console.WriteLine($"Tong HP da mat: {initialHp - currentHp}");
        if (currentHp == 0)
        {
            Console.WriteLine($"Don ket lieu: {processedAttacks}");
        }
    }

    static int CalculateDamage(int attack, int armor)
    {
        int damage = attack - armor;
        if (damage < 0)
        {
            return 0;
        }
        return damage;
    }

    static int CalculateRemainingHp(int currentHp, int damage)
    {
        int remainingHp = currentHp - damage;
        if (remainingHp < 0)
        {
            return 0;
        }
        return remainingHp;
    }
}

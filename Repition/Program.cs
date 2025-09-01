using System.Threading.Tasks.Dataflow;

FightSim();

static void FightSim()
{
    int p1Hp = 100;
    int p2Hp = 75;

    string p1Name = "";
    string p2Name = "";

    int realname = 0;

    while (realname == 0)
    {
        Console.WriteLine("Write yo name fool");
        p1Name = Console.ReadLine();

        Console.WriteLine("Write yo opponents name fool");
        p2Name = Console.ReadLine();

        p1Name = p1Name.Trim();
        p2Name = p2Name.Trim();

        if (p2Name == p1Name)
        {
            Console.Clear();
            Console.WriteLine("write different names fool");
            Console.ReadKey();
        }
        else if (p1Name.Length > 0 && p2Name.Length > 0)
        {
            realname = 1;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Write names fool");
            Console.ReadKey();
        }
    }
        Console.Clear();
        Console.WriteLine($"{p1Name} vs {p2Name} - FIGHT!");
        Console.ReadKey();


    while (p1Hp > 0 && p2Hp > 0)
    {
        Console.WriteLine($"{p1Name}: {p1Hp}");
        Console.WriteLine($"{p2Name}: {p2Hp}");

        int p1Damage = Random.Shared.Next(25);
        p2Hp -= p1Damage;
        Console.WriteLine($"{p1Name} gör {p1Damage} i skada på {p2Name}");

        int p2Damage = Random.Shared.Next(25);
        p1Hp -= p2Damage;
        Console.WriteLine($"{p2Name} gör {p2Damage} i skada på {p1Name}");
        Console.ReadLine();
    }

    if (p2Hp <= 0 && p1Hp <= 0)
    {
        Console.WriteLine($"{p1Name} och {p2Name} svimmade båda!");
    }
    else if (p1Hp <= 0)
    {
        Console.WriteLine($"{p2Name} vann!");
    }
    else
    {
        Console.WriteLine($"{p1Name} vann!");
    }


    Console.ReadLine();
}
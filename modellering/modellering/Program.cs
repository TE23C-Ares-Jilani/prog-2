Enemy orc = new();
orc.Name = "Orc";

orc.Hp = 100;

Player player = new();

Console.WriteLine("what is your name");
player.Name = Console.ReadLine();

player.Hp = 100;

Console.WriteLine($"your nameo is {player.Name}");

Console.WriteLine($"your enemy is an {orc.Name}");

Console.WriteLine($"your hp is {player.Hp}");

Console.WriteLine($"your hp is {orc.Hp}");

Console.ReadLine();


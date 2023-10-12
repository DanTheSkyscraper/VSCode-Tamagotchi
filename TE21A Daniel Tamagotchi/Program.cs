using System.Security;

Console.WriteLine("Hello friend! Welcome to Tamagotchi! Here, you are tasked with taking care of, you guessed it, your very own Tamagotchi!");

TamagotchiC tama = new();
TamagotchiC player = new();

Console.WriteLine("\nBefore we begin, what is your name?");
player.playerName = Console.ReadLine();

Console.WriteLine("\nNow, before you start taking care of your new charge, you need to decide what to name them. Pick something you think fits them.");
tama.tamagotchiName = Console.ReadLine();

Console.WriteLine($"\nAww, look at your little buddy! They seem to like it! Take good care of 'em, you hear?");

while(tama.GetAlive() == true)
{
    tama.PrintStats();

    Console.WriteLine("\nYour Tamagotchi is looking up at you anticipation.");

    Console.WriteLine("\nChoose your next action...");
    Console.WriteLine($"Choice No.1: Feed {tama.tamagotchiName}");
    Console.WriteLine($"Choice No.2: Greet {tama.tamagotchiName}");
    Console.WriteLine($"Choice No.3: Teach {tama.tamagotchiName}");
    Console.WriteLine($"Choice No.4: Play with {tama.tamagotchiName}");


    Console.ReadLine();
}




Console.ReadLine();
using System.Security;

Console.WriteLine("Hello friend! Welcome to Tamagotchi! Here, you are tasked with taking care of, you guessed it, your very own Tamagotchi!");

TamagotchiC tama = new();
TamagotchiC player = new();

Console.WriteLine("Before we begin, what is your name?");
player.playerName = Console.ReadLine();

Console.WriteLine("Now, before you start taking care of your new charge, you need to decide what to name them. Pick something you think fits them.");
tama.tamagotchiName = Console.ReadLine();

Console.WriteLine($"Aww, look at your little buddy! They seem to like it! Take good care of 'em, you hear?");

while(tama.GetAlive() == true)
{
    tama.PrintStats();

    Console.WriteLine("Choose your next action...");
    Console.WriteLine($"Feed {tama.tamagotchiName}");

}




Console.ReadLine();
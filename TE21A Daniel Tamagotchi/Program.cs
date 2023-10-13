string restartGame = "y";
while (restartGame == "y")
{

    Console.WriteLine("Hello friend! Welcome to Tamagotchi! Here, you are tasked with taking care of, you guessed it, your very own Tamagotchi!");

    TamagotchiC tama = new();
    TamagotchiC player = new();

    Console.WriteLine("\nBefore we begin, what is your name?");
    tama.playerName = TamagotchiC.PlayerGameName();

    Console.WriteLine($"\nNow, before you start taking care of your new charge {player.playerName}, you need to decide what to name them. Pick something you think fits them.");
    tama.tamagotchiName = TamagotchiC.TamagotchiGameName();
    

    Console.WriteLine($"\nAww, look at your little buddy! They seem to like it! Take good care of 'em, you hear?");

    while(tama.GetAlive() == true)
    {
        tama.PrintStats();

        Console.WriteLine("\nYour Tamagotchi is looking up at you anticipation.");

        Console.WriteLine("\n Here, the player may choose by typing the following commands in lower case: 'feed', 'greet', 'teach' or 'play'.");

        Console.WriteLine("\nChoose your next action...");
        Console.WriteLine($"\nChoice No.1: Feed {tama.tamagotchiName}");
        Console.WriteLine($"Choice No.2: Greet {tama.tamagotchiName}");
        Console.WriteLine($"Choice No.3: Teach {tama.tamagotchiName}");
        Console.WriteLine($"Choice No.4: Play with {tama.tamagotchiName}");
        string playerChoice = Console.ReadLine();


        if (playerChoice == "feed")
        {
            Console.WriteLine($"\nYou decide to feed {tama.tamagotchiName} with their favorite food. They are delighted.");
            tama.Feed();
        }
        else if (playerChoice == "greet")
        {
            Console.WriteLine($"\nYou greet {tama.tamagotchiName}. They happily respond!");
            tama.Hi();
        }
        else if (playerChoice == "teach")
        {
            Console.WriteLine($"\nYou decide to teach {tama.tamagotchiName} a new word. Your tamagotchi is eager to learn it. What will it be?");
            string tamagotchiWord = Console.ReadLine();
            tama.Teach(tamagotchiWord);
        }
        else
        {
            Console.WriteLine($"\nYou decide to play with {tama.tamagotchiName}. They are incredibly happy to spend time playing with you!");
            tama.Play();
        }

        Console.WriteLine("\nDo you want to play again? [y/n]");
        restartGame = Console.ReadLine();
    }
}
Console.ReadLine();
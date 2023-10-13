public class TamagotchiC
{
    private int Hunger = 0;

    private int Boredom = 0;

    private int Mood = 50;

    private List<string> words = new List<string>() {"hellö"};
    
    private Random Generator = new Random();
    
    public string tamagotchiName;

    public string playerName;

    private bool isAlive = true;


    //-------------------------------

    public void Feed()
    {
        Console.WriteLine("\nYour Tamagotchi eats the food you gave them. They are not as hungry as before.");
        ReduceHunger();
    }

    public void Play()
    {
        Console.WriteLine("\nYou play with your Tamagotchi. Their mood has improved!");
        ImproveMood();
    }

    public void Hi()
    {
        int i = Generator.Next(words.Count);
        Console.WriteLine($"\nYour Tamagotchi says: {words[i]}");
        ImproveMood();
        ReduceBoredom();
    }

    public void Teach(string word)
    {
        Console.WriteLine($"\nYou taught your Tamagotchi a new word, which is '{word}'. {tamagotchiName} is eager to learn it.");
        words.Add(word);
        ImproveMood();
        ReduceBoredom();
    }

    public void Tick()
    {
        Hunger++;
        Boredom++;
        Mood--;

        if (Mood < 25)
        {
            Console.WriteLine($"\n//Your Tamagotchi {tamagotchiName} is upset. Turn that frown upside down!//");
        }
        else
        {
            Console.WriteLine($"\n//Your Tamagotchi {tamagotchiName} is happy. Look at that ball of sunshine!//");
        }
    }

    public void HungerStatusCheck()
    {
        if(Hunger > 10)
        {
            isAlive = false;
        }
    }

    public void BoredomStatusCheck()
    {
        if(Boredom > 10)
        {
            isAlive = false;
        }
    }

    public void PrintStats()
    {
        if (isAlive == true)
        {
            Console.WriteLine($"\nTamagotchi '{tamagotchiName}' status: Alive");
        }
        else
        {
            Console.WriteLine($"\nTamagotchi '{tamagotchiName}' status: Dead");
        }

        Console.WriteLine($"\nHunger: {Hunger}");
        Console.WriteLine($"Boredom: {Boredom}");
        Console.WriteLine($"Mood: {Mood}");

        
    
    }

    public bool GetAlive()
    {
        return isAlive;
    }

    private void ReduceBoredom()
    {
        Console.WriteLine($"\nYour Tamagotchi '{tamagotchiName}' is not as bored anymore!");
        Boredom -= 2;

        if (Boredom < 0)
        {
            Boredom = 0;
        }
    }

    private void ImproveMood()
    {
        Mood += 2;

        if (Mood < 0)
        {
            Mood = 0;
        }
        else if(Mood > 50)
        {
            Mood = 50;
        }
    }

    private void ReduceHunger()
    {
        Hunger -= 2;

        if (Hunger < 0)
        {
            Hunger = 0;
        }
    }

    public static string PlayerGameName()
    {
        string playerName;

        Console.WriteLine("\nMy name is:");
        playerName = Console.ReadLine();
        
        return playerName;
    }

    public static string TamagotchiGameName()
    {
        string tamagotchiName;

        Console.WriteLine("\nThe name of your Tamagotchi is:");
        tamagotchiName = Console.ReadLine();

        return tamagotchiName;
    }

}

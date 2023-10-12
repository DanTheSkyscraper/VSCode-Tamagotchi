using System.Net;

public class TamagotchiC
{
    private int tamagotchiHunger = 0;

    private int tamagotchiBoredom = 0;

    private int tamagotchiMood = 50;

    private List<string> words = new List<string>() {"hellö"};
    
    private Random Generator = new Random();
    
    public string tamagotchiName;

    public string playerName;

    private bool isAlive = true; //Change??


    //----------

    public void Feed()
    {
        Console.WriteLine("Your Tamagotchi eats the food you gave them. They are not as hungry as before.");
        ReduceHunger();
    }

    public void Play()
    {
        Console.WriteLine("You play with your Tamagotchi. Their mood has improved!");
        ImproveMood();
    }

    public void Hi()
    {
        int i = Generator.Next(words.Count);
        Console.WriteLine($"Your Tamagotchi says: {words[i]}");
        ReduceBoredom();
        ImproveMood();
    }

    public void Teach(string tamagotchiWord)
    {
        Console.WriteLine($"You taught your Tamagotchi a new word, which is '{tamagotchiWord}'. {tamagotchiName} is eager to learn it.");
        words.Add(tamagotchiWord);
        ReduceBoredom();
        ImproveMood();
    }

    public void Tick()
    {
        tamagotchiHunger++;
        tamagotchiBoredom++;
        tamagotchiMood--;


        if(tamagotchiHunger > 10 & tamagotchiBoredom > 10)
        {
            isAlive = false;
            Console.WriteLine($"Your Tamagotchi {tamagotchiName} has died! How could you let this happen?!");
        }

        if (tamagotchiMood < 25)
        {
            Console.WriteLine($"Your Tamagotchi {tamagotchiName} is upset. Turn that frown upside down!");
        }
        else
        {
            Console.WriteLine($"Your Tamagotchi {tamagotchiName} is happy. Look at that ball of sunshine!");
        }
    }

    public void PrintStats()
    {
        if (isAlive)
        {
            Console.WriteLine($"\nTamagotchi '{tamagotchiName}' status: Alive");
        }
        else
        {
            Console.WriteLine($"\nTamagotchi '{tamagotchiName}' status: Dead");
        }

        Console.WriteLine($"\nHunger: {tamagotchiHunger}");
        Console.WriteLine($"Boredom: {tamagotchiBoredom}");
        Console.WriteLine($"Mood: {tamagotchiMood}");

        
    
    }

    public bool GetAlive()
    {
        return isAlive;
    }

    private void ReduceBoredom()
    {
        Console.WriteLine($"Your Tamagotchi '{tamagotchiName}' is not as bored anymore!");
        tamagotchiBoredom -= 2;

        if (tamagotchiBoredom < 0)
        {
            tamagotchiBoredom = 0;
        }
    }

    private void ImproveMood()
    {
        Console.WriteLine("The mood of your tamagotchi has improved!");
        tamagotchiMood += 2;

        if (tamagotchiMood < 0)
        {
            tamagotchiMood = 0;
        }
        else if(tamagotchiMood > 50)
        {
            tamagotchiMood = 50;
        }
    }

    private void ReduceHunger()
    {
        Console.WriteLine($"Your Tamagotchi '{tamagotchiName}' is not as hungry anymore!");
        tamagotchiHunger -= 2;

        if (tamagotchiHunger < 0)
        {
            tamagotchiHunger = 0;
        }
    }


}

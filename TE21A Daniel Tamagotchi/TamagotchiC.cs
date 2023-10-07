using System.Net;

public class TamagotchiC
{
    private int tamagotchiHunger = 0;

    private int tamagotchiBoredom = 0;

    private int tamagotchiMood = 50;

    private List<string> words;
    
    private Random Generator;
    
    public string tamagotchiName;

    public string playerName;

    private bool isAlive = true;


    //----------

    public void Feed()
    {
        Console.WriteLine("Your Tamagotchi eats the food you gave them. They are not as hungry as before.");
        tamagotchiHunger -= 2;
    }

    public void Play()
    {
        Console.WriteLine("You play with your Tamagotchi. Their mood has improved!");
        tamagotchiMood += 2;
    }

    public void Hi()
    {

    }

    public void Teach()
    {
        
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

        if (tamagotchiMood > 25) //IS THIS CORRECT?? SHOULD IT BE PLACED ELSEWHERE?
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
        Console.WriteLine($"Tamagotchi '{tamagotchiName}' status: {isAlive}");
        

        Console.WriteLine($"\nHunger: {tamagotchiHunger}");
        Console.WriteLine($"Boredom: {tamagotchiBoredom}");
        Console.WriteLine($"Mood: {tamagotchiMood}");

        
    
    }

    public bool GetAlive()
    {
        return true;
    }

    private void ReduceBoredom()
    {
        Console.WriteLine($"Your Tamagotchi '{tamagotchiName}' is not as bored anymore!");
        tamagotchiBoredom -= 2;
    }


}

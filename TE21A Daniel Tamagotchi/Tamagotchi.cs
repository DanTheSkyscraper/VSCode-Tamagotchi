namespace TE21A_Daniel_Tamagotchi;

public class Tamagotchi
{
    private int hunger = 0;

    private int boredom = 0;

    private List<string> words;
    
    private Random Generator = new Random();
    
    public string name;

    private bool isAlive = true;


    //----------

    public void Feed()
    {

    }

    public void Hi()
    {

    }

    public void Teach()
    {
        
    }

    public void Tick()
    {

    }

    public void PrintStats()
    {
        Console.WriteLine($"Tamagotchi status: {isAlive}");
        
        Console.WriteLine($"\nHunger: {hunger}");
        Console.WriteLine($"Boredom: {boredom}");
    }

    public bool GetAlive()
    {
        return true;
    }

    private void ReduceBoredom()
    {

    }


}

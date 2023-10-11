public class Player
{ 
 
    public int Experience = 0;
    public int Level = 0;

  
    public void GrantExperience()
    {

        Experience++;
        if (Level > 100)
        {
            Level++;
        }
        Console.WriteLine($"The level is {Level} and the experience is{Experience}");   
    }
}  
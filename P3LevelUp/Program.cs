Player player = new Player();
player.GrantExperience();
player.GrantExperience();
player.GrantExperience();


 public class Player
 { 
 
  public int Experience = 0;
  public int Level = 0;

   private int userInput = int.Parse(Console.ReadLine());
    public void GrantExperience()
    { 
        
         Experience+= userInput;
            if (Level > 100)
            {
                Level++;
            }
         Console.WriteLine($"The level is {Level} and the experience is{Experience}");   
    }
 }

 
 

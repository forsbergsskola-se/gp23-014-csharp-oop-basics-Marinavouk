


public class Plant
{
   public bool isGrown ;
   
   public void PrintStatus()
   {
      {
         Console.WriteLine(isGrown == true ? "Plant is a tree." : "Plant is a seed.");
      }
    
   }

   public void Grow()
   {
      {
       
         if (isGrown == true)
         {
            Console.WriteLine("Plant has already grown.");
         }
         else
         {
            Console.WriteLine("Plant is growing.");
            this.isGrown = true; //we change the status to true
         }
         
      }
     
   }
}
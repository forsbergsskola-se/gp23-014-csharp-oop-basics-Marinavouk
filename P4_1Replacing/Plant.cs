


public class Plant
{
   public bool isGrown ;
   
   public void PrintStatus(bool plant)
   {
      {
         Console.WriteLine(isGrown == true ? "Plant is a seed." : "Plant is a tree.");
      }
    
   }

   public void Grow(bool plant)
   {
      {
       
         if (isGrown == true)
         {
            Console.WriteLine("Plant is growing.");
         }
         else
         {
            Console.WriteLine("Plant has already grown.");
         }
         
      }
     
   }
}
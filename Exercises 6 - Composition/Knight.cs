


class Knight
{
    public  Shield Shield;
    public  Sword Sword;

    public void GetHit(Sword sword)
    {
        if (Shield != null)
        {
            if (sword != null)
            {
                Console.WriteLine("Knights Shield was pierced by the Sword.");
                Shield = null;
            }
            else
            {
                Console.WriteLine("Knights Shield fends off the strike.");
            }
            
        }
        else
        {
            Console.WriteLine("The Knight has no Shield and is wounded.");
        }
    }

    public void Attack(Knight defender)
    {
        if (Sword!= null)
        {
           
            Console.WriteLine("Knight attacks Knight with a Sword.");
            defender.GetHit(Sword);   
        }
        else
        {
             Console.WriteLine("Knight attacks Knight with Bare Hands."); 
            defender.GetHit(null);
             
        }
       
    }
}


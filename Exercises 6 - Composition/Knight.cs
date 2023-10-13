


class Knight
{
    public  Shield Shield;
    public  Sword Sword;

    public void GetHit(Sword sword)
    {
        if (Shield != null)
        {
            Console.WriteLine("Knights Shield fends off the strike.");
            Shield = null;
        }
        else
        {
            Console.WriteLine("The Knight has no Shield and is wounded.");
        }
    }

    public void Attack(Knight shield)
    {
        if (Sword == null)
        {
           
           Console.WriteLine("Knight attacks Knight with a Sword.");
            shield.GetHit(Sword);
            if (Shield != null) 
                Console.WriteLine("Knights Shield was pierced by the Sword.");
        }
        else
        {
            Console.WriteLine("Knight attacks with Bare Hands.");
            shield.GetHit(null);
        }   
    }
}


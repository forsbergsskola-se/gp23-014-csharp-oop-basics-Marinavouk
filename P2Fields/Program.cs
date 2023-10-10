

using P2Fields;

AllPlayerInfo player = new AllPlayerInfo();

player.Name = "Marina";
player.Email = "marina.eleni.voukouresli@student.forsbergsskola.se";
player.Gold = 200;
player.Stone = 110;
player.Wood = 53;
player.Level = 12;
player.Experience = 123;

player.VIPSubscription = true;
player.PVP = false;

Console.WriteLine("Name: " + player.Name);
Console.WriteLine("E-mail addrerss: " + player.Email);
Console.WriteLine("Player A has " + player.Gold + "Gold, " + player.Stone+"Stone, "
    + player.Wood+"Wood. He is level " + player.Level + " and has experience " + player.Experience+"." +
     player.VIPSubscription,  player.PVP);


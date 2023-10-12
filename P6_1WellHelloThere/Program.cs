

ObiWan obiWan = new ObiWan();


Console.WriteLine(obiWan);
Console.WriteLine(obiWan.Weapon);


Lightsaber lightsaber = new Lightsaber();
obiWan.Weapon = lightsaber;
Console.WriteLine(obiWan.Weapon);

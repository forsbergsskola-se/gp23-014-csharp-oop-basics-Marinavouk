




House blueHouse = new House();
House redHouse = new House();


Console.WriteLine(redHouse.IsDoorOpen);//i0ts false
Console.WriteLine(blueHouse.IsDoorOpen);
redHouse.OpenDoor();//made it true
Console.WriteLine("Red house :" + redHouse.IsDoorOpen);
Console.WriteLine("Blue House: "+blueHouse.IsDoorOpen);
blueHouse.OpenDoor();//made the other true too
Console.WriteLine("Red house :" + redHouse.IsDoorOpen);
Console.WriteLine("Blue House: "+blueHouse.IsDoorOpen);
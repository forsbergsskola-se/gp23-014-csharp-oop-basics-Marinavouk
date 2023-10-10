

using P2_2ItemValues;

Items [] items = new Items[3];

for (var i = 0; i < items.Length; i++)
{
    items[i] = new Items();//assign the new itmes first to items
}

items[0].GoldValue =  100;//assign a balue to them
items[1].GoldValue =  200;
items[2].GoldValue =  300;

for (int i = 0; i < items.Length; i++)
{
    Console.WriteLine(items[i].GoldValue);
}












Person[] people = new Person[3];


for (var i = 0; i < people.Length; i++)
{
   people[i] = new Person();
   Console.WriteLine("What name would you like to give?");
   string userInput= Console.ReadLine();
   people[i].name = userInput;

}
 
for (var i = 0; i < people.Length; i++)
{ 
   people[i].Greeting();
}

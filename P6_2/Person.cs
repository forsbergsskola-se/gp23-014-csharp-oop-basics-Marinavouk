

public class Person
{
    public Pizza Meal;
    public string name;
    public void Eat()
    {
        while (Meal.Slices > 0)
        {
            Console.WriteLine($"{name}Eating one slices.There is {Meal.Slices} left.");
            Meal.Slices--;
        }

        if (Meal.Slices == 0)
        {
            Console.WriteLine($"Sorry {name} but{Meal.Slices} left");
        }
        
    }
}
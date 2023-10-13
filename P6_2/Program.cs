



Pizza pizza = new Pizza(7);

Person [] person = new Person[3];

person [0] = new Person { name = Console.ReadLine(), Meal = pizza};
person [1] = new Person { name = Console.ReadLine(), Meal = pizza};
person [2] = new Person { name = Console.ReadLine(), Meal = pizza};

while (pizza.Slices > 0)
{
    for (int i = 0; i < person.Length; i++)
    {
        person[i].Eat();
    }
}

 
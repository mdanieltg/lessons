using System;
using System.Collections.Generic;
using MyLinq.Classlib;
using MyLinq.Classlib.Basic;

int sum = 1.Add(2);

Console.WriteLine("El resultado de la suma es {0}.", sum);

Human human = new Human
{
    Name = "Pablito",
    Age = 15
};
human.Print();

var data = new List<int>() { -3, 0, 5, 12, 10, -100, 53 };

var result = data
                .Where(x => x > 0)
                .OrderBy(x => x)
                .FirstOrDefault(x => x == 50);
// .First(x => x < 50);
// .First();

// foreach (var item in result)
Console.WriteLine($"The first item is {result}.");

var humans = new Human[]
// var humans = new List<Human>()
{
    new Human{ Name = "Pablito", Age = 18 },
    new Human{ Name = "Neri", Age = 32 },
    new Human{ Name = "Dany", Age = 19 },
    new Human{ Name = "Brayayin", Age = 12 },
    new Human{ Name = "Jessi", Age = 98 },
    new Human{ Name = "Cesarín", Age = 20 },
    new Human{ Name = "Ricardín", Age = 40 }
};

var humanResult = humans
                    .Where(x => x.Name.ToLower().Contains('i'))
                    .OrderBy(x => x.Age);
                    // .FirstOrDefault();

foreach (var item in humanResult)
    Console.WriteLine($"{item.Name} is {item.Age} years old.");

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "result.txt";
            int i = 0;

            StreamWriter Writer = new StreamWriter(path, false);
            Random rnd = new Random();

            List<Animal> animals = new List<Animal>()
            {
                new Predator() {Name = "Wolf", LengthWay = rnd.Next(1, 500), Weight = rnd.Next(10, 110)},
                new Predator() {Name = "Racoon", LengthWay = rnd.Next(1, 500), Weight = rnd.Next(3, 9)},
                new Vegetarian() {Name = "Cow", LengthWay = rnd.Next(1, 500), Weight = rnd.Next(700, 1100)},
                new Omnivores(){Name = "Boar", LengthWay = rnd.Next(1, 500), Weight = rnd.Next(60, 100)},
                new Omnivores(){Name = "Fox", LengthWay = rnd.Next(1, 500), Weight = rnd.Next(6, 10)},
                new Vegetarian(){Name = "Deer", LengthWay = rnd.Next(1, 500), Weight = rnd.Next(150, 250)},
                new Omnivores(){Name = "Bear", LengthWay = rnd.Next(1, 500), Weight = rnd.Next(8, 600)},
                new Predator(){Name = "Badger", LengthWay = rnd.Next(1, 500), Weight = rnd.Next(10, 15)},
                new Predator(){Name = "Lynx", LengthWay = rnd.Next(1, 500), Weight = rnd.Next(8, 30)},
                new Vegetarian(){Name = "Beaver", LengthWay = rnd.Next(1, 500), Weight = rnd.Next(10, 30)}
            };

            foreach (var animal in animals)
            {
                var food = animal.Food();
            }


            var sort = from anm in animals
                       orderby anm.Count, anm.Name
                       select anm;


            foreach (var animal in sort)
            {
                var food = animal.Food();

                if(animal is Predator)
                {
                    Writer.WriteLine($"Predator {animal.Name} eats {animal.Count} kg of {food.Item1}");
                    Writer.WriteLine();
                }
                else if(animal is Vegetarian)
                {
                    Writer.WriteLine($"Vegeterian {animal.Name} eats {animal.Count} kg of {food.Item1}");
                    Writer.WriteLine();
                }
                else
                {
                    Writer.WriteLine($"Omnivores {animal.Name} eats {animal.Count} kg of {food.Item1}");
                    Writer.WriteLine();
                }
            }

            foreach (var animal in sort)
            {
                i++;

                if(i <= 5)
                {
                    Writer.WriteLine(animal.Name);
                }

                if (i > 7)
                {
                    if (i == 8)
                    {
                        Writer.WriteLine();
                    }

                    if (animal is Predator)
                        Writer.WriteLine("Predator");
                    else if (animal is Vegetarian)
                        Writer.WriteLine("Vegeterian");
                    else
                        Writer.WriteLine("Omnivores");
                }
            }

            Writer.Close();
        }
    }
}

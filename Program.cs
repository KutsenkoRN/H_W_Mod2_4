using System;

namespace H_W_Mod2_4
{/// <summary>
/// starter app.
/// </summary>
    internal class Program
    {/// <summary>
     /// app.
     /// </summary>
     /// <param name="args">info.</param>
        public static void Main(string[] args)
        {
            Vegetable[] ingredients =
            {
                new Cabbage(0.9),
                new Cabbage(1.5),
                new Cucumber(0.12),
                new Cucumber(0.10),
                new Cucumber(0.11),
                new Carrot(0.14),
                new Carrot(0.13),
                new Carrot(0.150),
                new Potato(0.14),
                new Potato(0.12),
                new Potato(0.13),
                new Potato(0.1),
                new Beet(0.2),
                new Beet(0.25),
            };

            Vegetable[] foundVegetables = ingredients.SearchForVegetables("Potato");
            for (int i = 0; i < foundVegetables.Length; i++)
            {
                Console.WriteLine(foundVegetables[i].GetInfo());
            }

            var salad = new Salad(capacity: 9);
            Random rnd = new Random();
            for (int i = 0; i < salad.Capacity;)
            {
                string info = salad.SortByWeight(ingredients[rnd.Next(0, ingredients.Length)], 0.95);
                Console.WriteLine(info);
                if (info != "Vegetable is too big.")
                {
                    i++;
                }
            }

            Console.WriteLine(salad.SaladPreparation());
        }
    }
}
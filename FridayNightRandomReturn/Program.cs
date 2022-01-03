using System;

namespace FridayNightRandomReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };
            string[] drinks = { "apple juice", "coke", "fanta", "sprite" };
            string[] movies = { "Iron Man", "Dark Knight", "Kevade" };

            string randomFood, randomDrink, randomMovie;

            randomFood = PickRandomElementFromArray(foods);
            randomDrink = PickRandomElementFromArray(drinks);
            randomMovie = PickRandomElementFromArray(movies);

            Console.WriteLine($"Tonight you will have some {randomFood} with {randomDrink} and watch {randomMovie}");

        }

        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }

        

        private static string PickRandomElementFromArray(string [] someArray)
        {
            string randomElement = someArray[GenerateRandomIndex(someArray)];
            return randomElement;
        }

        private static void DisplayRandomMovie()
        {
            string[] movies = { "Iron Man", "Dark Knight", "Kevade" };

            Console.WriteLine($"Computer picked: {movies[GenerateRandomIndex(movies)]}");
        }



    }
}

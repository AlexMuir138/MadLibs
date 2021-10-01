using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*
            MAD MAD LIBS
            This program is meant to mimic the classic Mad Lib algorithm. It will take user input of nouns, adjectives, verbs, etc. and print them into a story for the user.
            Author: Alex Muir
            */


            // Let the user know that the program is starting:
            Console.WriteLine("Your application is now running...");

            // Give the Mad Lib a title:
            string title = "Mad Mad Libs";

            Console.WriteLine(title);
            // Define user input and variables:
            Console.Write("Please Enter a Name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");

            Console.Write("Type an Adjective (A word that describes a noun. Ex: blue, silly, soft.): ");
            string adjOne = Console.ReadLine();
            Console.Write("Type another Adjective: ");
            string adjTwo = Console.ReadLine();
            Console.Write("Type one more Adjective: ");
            string adjThree = Console.ReadLine();

           

            Console.Write("Type a Verb (A word describing an action. Ex: sit, eat, sleep.): ");
            string verbOne = Console.ReadLine();

            Console.Write("Type a Noun (A person, place, or thing): ");
            string nounOne = Console.ReadLine();
            Console.Write("Type another Noun: ");
            string nounTwo = Console.ReadLine();

            Console.Write("Type an Animal: ");
            string animal = Console.ReadLine();
            Console.Write("Type a Food: ");
            string food = Console.ReadLine();
            Console.Write("Type a Fruit: ");
            string fruit = Console.ReadLine();
            Console.Write("Type a Superhero: ");
            string superhero = Console.ReadLine();
            Console.Write("Type a Country: ");
            string country = Console.ReadLine();
            Console.Write("Type a Dessert: ");
            string dessert = Console.ReadLine();
            Console.Write("Type a Year: ");
            string year = Console.ReadLine();


            // The template for the story:

            string story = $"This morning {name} woke up feeling {adjOne}. 'It is going to be a {adjTwo} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verbOne} to the rhythm of the {nounOne}, which made all the {fruit}s very {adjThree}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {nounTwo}s ruled the world.";


            // Print the story:
            Console.WriteLine("Here is your Mad Mad Lib!");
            Console.WriteLine(story);
        }
    }
}

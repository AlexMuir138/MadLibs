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


            // The template for the story:

            string story = "This morning _ woke up feeling _. 'It is going to be a _ day!' Outside, a bunch of _s were protesting to keep _ in stores. They began to _ to the rhythm of the _, which made all the _s very _. Concerned, _ texted _, who flew _ to _ and dropped _ in a puddle of frozen _. _ woke up in the year _, in a world where _s ruled the world.";


            // Print the story:
        }
    }
}

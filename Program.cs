using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program incorporates the use of string interpolation and variables to produce a Mad Libs story.
      Author: Joey Troxclair
      */

      // Let the user know that the program is starting:
      Console.WriteLine("The Mad Libs game has begun!");

      // Give the Mad Lib a title:
      string title = "MAD RANDOM";
      Console.WriteLine(title);

      // Define user input and variables:
      Console.WriteLine("Enter the main character's name: ");
      String name = Console.ReadLine();

      Console.WriteLine("Enter an adjective: ");
      String firstAdjective = Console.ReadLine();

      Console.WriteLine("Enter an adjective: ");
      String secondAdjective = Console.ReadLine();

      Console.WriteLine("Enter an adjective: ");
      String thirdAdjective = Console.ReadLine();

      Console.WriteLine("Enter a verb: ");
      String storyVerb = Console.ReadLine();

      Console.WriteLine("Enter a noun: ");
      String firstNoun = Console.ReadLine();

      Console.WriteLine("Enter a noun: ");
      String secondNoun = Console.ReadLine();

      Console.WriteLine("Enter an animal: ");
      String animal = Console.ReadLine();

      Console.WriteLine("Enter a food: ");
      String food = Console.ReadLine();

      Console.WriteLine("Enter a fruit: ");
      String fruit = Console.ReadLine();

      Console.WriteLine("Enter a superhero: ");
      String superhero = Console.ReadLine();

      Console.WriteLine("Enter a country: ");
      String country = Console.ReadLine();

      Console.WriteLine("Enter a dessert: ");
      String dessert = Console.ReadLine();

      Console.WriteLine("Enter a year: ");
      String year = Console.ReadLine();

      // The template for the story:
      string story = $"This morning {name} woke up feeling {firstAdjective}. 'It is going to be a {secondAdjective} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {storyVerb} to the rhythm of the {firstNoun}, which made all the {fruit}s very {thirdAdjective}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {1990}, in a world where {secondNoun}s ruled the world.";

      // Print the story:
      Console.WriteLine(story);
    }
  }
}

using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        List<string> verses = new List<string>
        {
            "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall."
        };

        Scripture scripture = new Scripture("Helaman 5:12", verses);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nAll words are hidden. Program will end.");
                break;
            }

            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);
        }
    }
}

using System.Text.RegularExpressions;

namespace WordsAndCharactersCounter;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to you very own Words and Character Counter Program");
        Console.WriteLine(
            @"
        Enter 1 to count all the words in your sentence.
        Enter 2 to count all the characters in your sentence.
        Enter 3 to count all the digits in your sentence.
        Enter 4 to count all occurrences of character on your sentence."
        );

        string choice = Console.ReadLine();
        string str;
        char charToCount;
        int i,
            digits;
        i = digits = 0;
        int myWords = 1;

        switch (choice)
        {
            case "1":
                Console.WriteLine("You've chosen to count all the words in your sentence!");
                Console.Write("Enter your sentence: ");
                str = Console.ReadLine();

                // Loops through sentence and increments myWords if there is a space
                while (i <= str.Length - 1)
                {
                    if (str[i] == ' ')
                    {
                        myWords++;
                    }
                    i++;
                }

                Console.WriteLine("Number of words in the sentence = {0}", myWords);
                break;
            case "2":
                Console.WriteLine("You've chosen to count all the characters in your sentence!");
                Console.Write("Enter your sentence: ");
                str = Console.ReadLine();

                // Uses Regex to remove all non-alphanumeric characters from the string
                string flatWord = Regex.Replace(str, "[^a-zA-Z0-9]", "");

                // No Loop here, uses Length method
                Console.WriteLine(
                    "The number of characters in the sentence are = {0}",
                    flatWord.Length
                );
                break;
            case "3":
                Console.WriteLine("You've chosen to count all the digits in the sentence");
                Console.Write("Enter your sentence: ");
                str = Console.ReadLine();

                // Loop though string and increment count if a digit is found
                while (i < str.Length)
                {
                    if (str[i] >= '0' && str[i] <= '9')
                        digits++;

                    i++;
                }
                Console.WriteLine("The number of digits in the sentence is {0}", digits);
                break;
            case "4":
                // Creates char count and increments after looping
                Console.WriteLine(
                    "You've chosen to count all occurrences of character in the sentence."
                );
                Console.Write("Enter your sentence: ");
                str = Console.ReadLine();
                Console.Write("Enter the character to count: ");
                charToCount = Convert.ToChar(Console.ReadLine());

                foreach (char chr in str)
                {
                    if (chr == charToCount)
                    {
                        i++;
                    }
                }
                Console.WriteLine(
                    "The number of occurrences for the character in the sentence is {0}",
                    i
                );
                break;
            default:
                break;
        }
    }
}

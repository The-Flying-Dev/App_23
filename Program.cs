namespace WordsAndCharactersCounter;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to you very own Words and Character Counter Program");
        Console.WriteLine(
            @"Enter 1 to count all the words in your sentence,
        enter 2 to count all the characters in your sentence,
        enter 3 to count all the numbers in your sentence,
        enter 4 to count all occurrences of either a word, character or number in your sentence"
        );

        string choice = Console.ReadLine();
        string userInput;
        int a = 0;

        switch (choice)
        {
            case "1":
                Console.WriteLine("You've chosen to count all the words in your sentence!");
                Console.Write("Enter your sentence.");
                userInput = Console.ReadLine();
                //int a = 0;
                int myWords = 1;

                while (a <= userInput.Length - 1)
                {
                    if (userInput[a] == ' ')
                    {
                        myWords++;
                    }
                    a++;
                }

                Console.WriteLine("Number of words in the sentence = {0}", myWords);
                break;
            case "2":
                Console.WriteLine("You've chosen to count all the characters in your sentence!");
                Console.Write("Enter your sentence.");
                userInput = Console.ReadLine();
                break;
            default:
                break;
        }
    }
}

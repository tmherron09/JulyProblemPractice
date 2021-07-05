using System;

namespace ProblemSetPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            EarlyTest();
            //Run();


        }

        static void EarlyTest()
        {
            // Add temp tests.
        }

        static void FrequencyDictTest()
        {
            var freq = SherlockValidString.FrequencyDictionary("abcabcabca");
            foreach(var l in freq)
            {
                Console.WriteLine($"Key: {l.Key} Value:{l.Value}");
            }
        }

        static void Run()
        {
            bool runAgain = true;
            while (runAgain)
            {
                runAgain = ProblemSelection();
            }

            Console.WriteLine("Press Any Key...");
            Console.ReadKey();
        }

        static bool ProblemSelection()
        {
            Console.WriteLine("Please select a problem:");
            Console.WriteLine("1. Making Anagrams");
            Console.WriteLine("2. Alternating Characters");
            Console.WriteLine("Q. Quit");
            char choice = Console.ReadKey().KeyChar;
            switch (choice)
            {
                case '1':
                    MakingAnagram.Setup();
                    return true;
                case '2':
                    AlternatingCharacters.Setup();
                    return true;
                case 'q':
                case 'Q':
                    return false;
                default:
                    Console.WriteLine("Invalid Choice");
                    return true;
            }
        }

    }
}

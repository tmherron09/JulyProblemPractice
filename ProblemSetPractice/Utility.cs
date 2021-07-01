using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSetPractice
{
    public class Utility
    {

        public static int ConsoleSelection(string prompt, string[] options)
        {
            Console.WriteLine(prompt);
            for(int i = 0; i < options.Length; i++)
            {
            Console.WriteLine($"{i+1}. {options[i]}");
            }
            Console.WriteLine("Q. Quit");
            char choice = Console.ReadKey().KeyChar;
            switch (choice)
            {
                case '1':
                    Console.WriteLine("Running Making Anagrams");

                    return 0;
                case 'q':
                case 'Q':
                    return -1;
                default:
                    Console.WriteLine("Invalid Choice");
                    return -2;
            }
        }


    }
}

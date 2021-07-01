using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSetPractice
{
    public static class AlternatingCharacters
    {

        public static void Setup()
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Use Default");
            Console.WriteLine("2. Enter Both String Values");
            Console.WriteLine("Q. Quit");
            char choice = Console.ReadKey().KeyChar;
            bool repeat = false;
            do
            {
                repeat = false;
                switch (choice)
                {
                    case '1':
                        Solve();
                        break;
                    case '2':
                        Console.Write("Enter A/B string: ");
                        string a = Console.ReadLine();
                        Solve(a);
                        break;
                    case '3':
                        SolveExample();
                        break;
                    case 'q':
                    case 'Q':
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        repeat = true;
                        break;
                }
            } while (repeat);
        }

        public static void SolveExample()
        {
            Console.WriteLine("AAAABBAAAB");
            Solve("AAAABBAAAB");

            Console.WriteLine("BBBB");
            Solve("BBBB");

            Console.WriteLine("ABABABABABA");
            Solve("ABABABABABA");

            Console.WriteLine("AAABBB");
            Solve("AAABBB");
        }

        public static void Solve()
        {
            Solve("AAABAABB");
        }

        public static void Solve(string a)
        {
            int result = 0;
            List<char> aList = new List<char>();
            aList.AddRange(a);

            for (int i = 0; i < aList.Count - 1; i++)
            {

                bool matching = false;
                do
                {
                    matching = false;
                    matching = aList[i] == aList[i + 1];
                    if (matching)
                    {
                        aList.RemoveAt(i + 1);
                        result++;
                    }
                    if (i + 1 == aList.Count) matching = false;
                } while (matching);

            }
            foreach(var c in aList)
            {
                Console.Write(c);
            }
            Console.WriteLine();
            Console.WriteLine($"We made {result} deletions.");
        }


    }
}

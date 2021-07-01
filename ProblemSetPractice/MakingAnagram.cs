using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSetPractice
{
    public static class MakingAnagram
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
                        Console.Write("Enter first string: ");
                        string a = Console.ReadLine();
                        Console.Write("Enter second string: ");
                        string b = Console.ReadLine();
                        Solve(a, b);
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


        public static void Solve()
        {
            string a = "abcd";
            string b = "cdef";
            Solve(a, b);
        }

        public static void SolveExample()
        {
            string a = "fcrxzwscanmligyxyvym";
            string b = "jxwtrhvujlmrpdoqbisbwhmgpmeoke";
            Console.WriteLine($"String a: {a}");
            Console.WriteLine($"String b: {b}");
            Solve(a, b);
        }

        public static void Solve(string a, string b)
        {
            int result = 0;
            List<char> aCharArray = new List<char>();
            aCharArray.AddRange(a);
            List<char> bCharArray = new List<char>();
            bCharArray.AddRange(b);
            List<char> results = aCharArray.FindAll(s => bCharArray.Remove(s));
            result += a.Length - results.Count;
            result += b.Length - results.Count;

            Console.WriteLine($"The minimum deletes is: {result}");
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSetPractice
{
    public static class SherlockValidString
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
                        Console.Write("Enter string: ");
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

        public static void Solve()
        {
            string s = "abcdefabcdef";
            Solve(s);
            s = "abcdeabcdea";
            Solve(s);
            s = "abacabcab";
            Solve(s);
            s = "abcbc";
            Solve(s);
        }




        public static void Solve(string s)
        {
            Dictionary<char, int> frequency = new Dictionary<char, int>();
            foreach(var l in s)
            {
                if(frequency.ContainsKey(l))
                {
                    frequency[l]++;
                } else
                {
                    frequency.Add(l, 1);
                }

            }


        }

        public static Dictionary<char, int> FrequencyDictionary(string s)
        {
            Dictionary<char, int> frequency = new Dictionary<char, int>();
            foreach (var l in s)
            {
                if (frequency.ContainsKey(l))
                {
                    frequency[l]++;
                }
                else
                {
                    frequency.Add(l, 1);
                }

            }
            return frequency;
        }


        public static void SolveExample()
        {


        }


    }
}

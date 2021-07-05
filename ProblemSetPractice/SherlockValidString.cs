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
            s = "abcaabc";
            Solve(s);
            s = "aabcabcbabc";
            Solve(s);
            s = "abcdefghhgfedecba";
            Solve(s);
            s = "aabbccddeefghi";
            Solve(s);
            s = "aabbc";
            Solve(s);
            s = "xxxaabbccrry";
            Solve(s);
        }




        public static void Solve(string s)
        {
            Dictionary<char, int> frequency = FrequencyDictionary(s);
            Dictionary<int, int> occurance = OccuranceDictionary(frequency);

            if (occurance.Count == 1)
            {
                ResultOutput(s, true);
                return;
            }
            else if (occurance.Count > 2 || !occurance.ContainsValue(1))
            {
                ResultOutput(s, false);
                return;
            }

            int singleFreq = 0;
            int commonFreq = 0;
            foreach (var number in occurance)
            {
                if (number.Value == 1)
                {
                    singleFreq = number.Key;
                }
                else
                {
                    commonFreq = number.Key;
                }
            }
            if (singleFreq == commonFreq + 1 || singleFreq == 1)
            {
                ResultOutput(s, true);
            }
            else
            {
                ResultOutput(s, false);
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

        public static Dictionary<int, int> OccuranceDictionary(Dictionary<char, int> frequency)
        {
            Dictionary<int, int> occurance = new Dictionary<int, int>();
            foreach (var freq in frequency)
            {
                if (occurance.ContainsKey(freq.Value))
                {
                    occurance[freq.Value]++;
                }
                else
                {
                    occurance.Add(freq.Value, 1);
                }
            }
            return occurance;
        }


        public static void SolveExample()
        {


        }

        public static void ResultOutput(string s, bool result)
        {
            Console.Write($"String: '{s}' is {(result ? "Valid" : "Invalid")}\n");
        }

    }
}

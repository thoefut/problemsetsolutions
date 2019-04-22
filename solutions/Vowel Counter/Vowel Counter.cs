/*Count Vowels 
 * Enter a string and the program counts the number of vowels in the text. For added complexity have it report a sum of each vowel found.
 * 
 * Input = User enters a line for the program to analyze
 * Output = Statistics on each vowel used. Total number of vowels in the provided string.
 */

using System;
using System.Collections.Generic;

namespace Vowel_Counter
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter line to analyze");
            Vowel_counter.PrintStatisticsToConsole(Console.ReadLine());
        }
    }
    public class Vowel_counter
    {

        static readonly char[] consonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z' };
        static readonly char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
        public static void PrintStatisticsToConsole(string toAnalyze)
        {
            SortedDictionary<char, int> dict = CountVowels(toAnalyze);
            int numberofvowels = 0;
            foreach (char key in dict.Keys)
            {
                Console.WriteLine("{0} = {1}", key, dict[key]);
                numberofvowels += dict[key];
            }
            Console.WriteLine("Total number of vowels = {0}", numberofvowels);
        }
        public static SortedDictionary<char, int> CountVowels(string toCount)
        {
            SortedDictionary<char, int> dict = new SortedDictionary<char, int>();
            foreach (char vow in vowels)
            {
                dict.Add(vow, 0);
            }
            foreach (char character in toCount)
            {
                if (dict.ContainsKey(character)) { dict[character]++; }
            }
            return dict;
        }
    }
}

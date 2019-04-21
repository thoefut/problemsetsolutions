/* 
 * Count Words in a String
 * Counts the number of individual words in a string. For added complexity read these strings in from a text file and generate a summary.  
 * 
 * Example: 
 * Input: "This is a string"
 * Output: 4
 * Input: ""
 * Output: 0
  */

using System;

namespace WordCounter
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a string. Program will calculate number of words contained in it");
            string words = Console.ReadLine();
            Console.WriteLine("Entered string contains {0} words", WordCounter.countWords(words));
        }
    }
    public static class WordCounter
    {
        /// <summary>
        /// Return a number of words in the provided string
        /// </summary>
        /// <param name="words">String containing the text to analyze</param>
        /// <returns> Integer value of words contained in a string of text
        /// </returns>
        public static int countWords(string words)
        {
            int numberOfWords = 0;
            if (words.Length > 0 && words[0] != ' ')
            {
                numberOfWords++;
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i] == ' ' && i + 1 < words.Length) { if (words[i + 1] != ' ') { numberOfWords++; } }
                }
            }
            return numberOfWords;
        }
    }
}

/*Pig Latin 
 * Pig Latin is a game of alterations played on the English language game. To create the Pig Latin form of an English word the initial consonant sound is transposed to the end of the word and an ay is affixed (Ex.: "banana" would yield anana-bay). Read Wikipedia for more information on rules.
 * 
 * Input = Word to PigLatinify (treats whole string as one word)
 * Output = Piglatinified Word
  */

using System;
using System.Collections.Generic;

namespace Pig_Latin
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter String to Pig Latini-ify");
            Console.WriteLine(PigLatinifier.Piglatinify(Console.ReadLine()));
        }
    }
    public static class PigLatinifier
    {
        static readonly char[] consonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z' };
        //static readonly char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
        
        /// <summary>
        /// Pig Latinifies given string. Works on the whole string, make sure to only give it one word to work with.
        /// </summary>
        /// <param name="toPigLatinigfy">
        /// String to be piglatinified. Make sure it only contains one word
        /// </param>
        /// <returns>
        /// Piglatin-ified string. If empty string is provided returns it.
        /// </returns>
        public static string Piglatinify (string toPigLatinigfy)
        {
            if (toPigLatinigfy.Length==0) { return ""; }
            //List<char> vowelslist = new List<char>(vowels);
            List<char> consonantslist = new List<char>(consonants);
            int consonantNumber = 0;
            while (consonantNumber < toPigLatinigfy.Length && consonantslist.Contains(toPigLatinigfy[consonantNumber]))
            {
                consonantNumber++;
            }
            string consonantprefix = toPigLatinigfy.Substring(0, consonantNumber);
            string pigLatinifiedString = toPigLatinigfy.Remove(0, consonantNumber);
            pigLatinifiedString += consonantprefix;
            pigLatinifiedString += "ay";
            return pigLatinifiedString;
        }
    }
}

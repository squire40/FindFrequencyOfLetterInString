using System.Linq;
using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace FindFrequencyOfLetterInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Phrase");
            var phrase = Console.ReadLine();
            Console.WriteLine("Enter Letter");
            var letter = Console.ReadLine();

            int frequency = FindFrequencyOfLetter(phrase, letter);
            Console.WriteLine($"The phrase {phrase} contains the letter {letter} {frequency} times");
            Console.ReadLine();
        }

        private static int FindFrequencyOfLetter(string phrase, string letter)
        {
            return phrase.ToLower().ToCharArray().Where(l => l == Convert.ToChar(letter.ToLower())).Count();
        }
    }
}

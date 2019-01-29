using System.Linq;
using System;

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
            var charLetter = Convert.ToChar(letter.ToLower());

            return phrase.ToLower().ToCharArray().Where(c => c == charLetter).Count();
        }
    }
}

using System;
using System.Text.RegularExpressions;

namespace лаб_5._4
{
    internal class Program
    {
        /// <summary>
        /// Метод main.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите первое предложение:\n");
            string sentence = Console.ReadLine();
            //string[] sentenceArray = sentence.Split(new char[] { ' ' });

            string pattern = @"\w{3}\s\d{2},\s\d{4}";

            Console.WriteLine("\nСтроки, являющиеся датой:\n");

            foreach (Match match in Regex.Matches(sentence, pattern))
            {
                Console.WriteLine(match.Value);
            }
            Console.ReadKey();
        }
    }
}

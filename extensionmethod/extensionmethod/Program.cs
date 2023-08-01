using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtension
{
    public static class StringExtension
    {
        public static string CapitalizerFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;
            return char.ToUpper(input[0]) + input.Substring(1);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Sentence");
            string inputSentence = Console.ReadLine();
            string captializedSentence = inputSentence.CapitalizerFirstLetter();
            Console.WriteLine($"Caplitalized Sentence : {captializedSentence}");
        }
    }
}
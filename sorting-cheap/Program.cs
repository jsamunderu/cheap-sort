using System;
using System.Text;

namespace question_1_excercise_in_sorting_cheap
{
    public class Program
    {
        private static readonly char[] ALPHABET = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h',
            'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
            'u', 'v', 'w', 'x', 'y', 'z'};

        public static string Sort(string str)
        {
            int[] charCounters = new int[ALPHABET.Length];

            foreach (char c in str)
            {
                // ASCII maps to utf-8. If bit 5 of an ASCII character is set
                // and it is a letter of the alphabet, it will be lower case.
                // Setting this bit on any other unicode page code will just
                // be a huge integer which falls outside the required range.
                int lower = ((int)c) | 0x0020;
                if (lower >= 'a' && lower <= 'z')
                {
                    charCounters[lower - 'a']++;
                }
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < charCounters.Length; i++)
            {
                for (int j = 0; j < charCounters[i]; j++)
                {
                    // delete the line below and the ALPHABET constant and
                    // insert the following line
                    // sb.Append(Convert.ToChar('a' + i));
                    // its cheaper to just just pickup the letter than calculate it and convert
                    sb.Append(ALPHABET[i]);
                }
            }

            return sb.ToString();
        }
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: question-1-excercise-in-sorting-cheap.exe <phrase to sort>");
                return;
            }

            StringBuilder sb = new StringBuilder();
            foreach (string str in args)
            {
                sb.Append(str);
            }

            Console.WriteLine(Program.Sort(sb.ToString()));
        }
    }
}
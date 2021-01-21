using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_1_excercise_in_sorting
{
    public class Program
    {
        public static string Sort(string str)
        {
            List<char> list = new List<char>();
            foreach (char c in str)
            {
                if (!(c >= 'a' && c <= 'z') && !(c >= 'A' && c <= 'Z'))
                {
                    continue;
                }
                if (Char.IsUpper(c))
                {
                    list.Add(Char.ToLower(c));
                }
                else
                {
                    list.Add(c);
                }
            }
            char[] characters = list.ToArray();
            Array.Sort(characters);
            return new string(characters);
        }
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: question-1-excercise-in-sorting.exe <phrase to sort>");
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

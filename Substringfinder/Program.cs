using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substringfinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String: ");

            string sentence = Console.ReadLine();
            Console.WriteLine("Enter the substring to find: ");
            string substring = Console.ReadLine();

            int index = FindSubstring(sentence, substring);

            if(index>=0)
            {
                Console.WriteLine($"The substring '{substring}' was found at index '{index}'");

            }
            else
            {
                Console.WriteLine($"The substring '{substring}' was not found.");
            }
        }

        private static int FindSubstring(string sentence, string substring)
        {
            int index =  sentence.IndexOf(substring);
            return index;
        }
    }
    }
}

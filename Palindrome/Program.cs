using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
			EnterWord:
            Console.WriteLine("Please enter a word");
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                if (Char.IsWhiteSpace(word[i]))
                {
                    Console.WriteLine("It should be only one word without spaces");
                    goto EnterWord;
                }
            }

            for (int i = 0; i < word.Length; i++)
            {
                if ( word[i] != word[(word.Length - (i+1))])
                {
                    Console.WriteLine($"The word {word} is NOT a palindrome");
                    return;
                }
            }

            Console.WriteLine($"The word {word} is a palindrome");
        }   
    }
}

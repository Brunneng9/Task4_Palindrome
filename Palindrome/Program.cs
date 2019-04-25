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
            Console.WriteLine("Please enter a word");
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                if (Char.IsWhiteSpace(word[i]))
                {
                    Console.WriteLine("It should be only one word without spaces");
                    return;
                }
            }
            for (int i = 0; i < word.Length; i++)
            {
                if ( word[i] == 32) 
                {
                    Console.WriteLine("It should be only one word");
                    return;
                }
                else if ( word[i] != word[(word.Length - (i+1))])
                {
                    Console.WriteLine($"The word {word} is NOT a palindrome");
                    return;
                }
            }
            Console.WriteLine($"The word {word} is a palindrome");
        }   
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz(20);

            LetterCounter('i', "I love biscuits and gravy. It's the best breakfast ever.");
            LetterCounter('n', "Never gonna give you up. Never gonna let you down.");
            LetterCounter('s', "Sally sells seashells down by the seashore.  She's from Sussex");
            Console.ReadKey();

        }
  
        static void LetterCounter(char letter, string inString)
        {
            int lowercaseLetters = 0;
            int UPPERCASELetters = 0;
            for (int i = 0; i < inString.Length; i++)
            {
                if (inString[i].ToString() == letter.ToString().ToLower())
                {
                    lowercaseLetters++;
                }
                if (inString[i].ToString() == letter.ToString().ToUpper())
                {
                    UPPERCASELetters++;
                }
            }

            Console.WriteLine("Input: {0}", inString);
            Console.WriteLine("Lowercase letters: {0}", lowercaseLetters);
            Console.WriteLine("Uppercase letters: {0}", UPPERCASELetters);
            Console.WriteLine("Total letters found: {0}", (UPPERCASELetters + lowercaseLetters));
        }
        /// <summary>
        /// Enter a number and test every number up to that number for Fizz or Buzz or FizzBuzz 
        /// </summary>
        /// <param name="number"></param>
        static void FizzBuzz(int number)
        {
            for (int i = 0; i <= number; i++)
            {
                //if divisible by 3 and 5 then write FIZZBUZZ
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FIZZBUZZ");
                }
                //else if i is divisible by 3 then write FIZZ
                else if (i % 3 == 0)
                {
                    Console.WriteLine("FIZZ");
                }
                //else if i is divisible by 5 then write BUZZ
                else if (i % 5 == 0)
                {
                    Console.WriteLine("BUZZ");
                }
                //else just write the number
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
        }
}


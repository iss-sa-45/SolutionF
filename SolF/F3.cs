using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolF
{
    class F3
    {
        static void Main()
        {
            Console.Write("Please enter a phrase: ");
            string phrase = Console.ReadLine();

            phrase = phrase.ToLower();
            string newphrase = "";
            string reversephrase = "";
            string listOfPunctuations = ".;!?, ";

            for (int i = 0; i < phrase.Length; i++)
            {
                string ch = phrase.Substring(i, 1);
                if (listOfPunctuations.Contains(ch) == false)
                {
                    newphrase = newphrase + ch;
                    reversephrase = ch + reversephrase;
                }
            }

            if (newphrase == reversephrase)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
    }
}

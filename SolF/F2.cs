using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolF
{
    class F2
    {
        static void Main()
        {
            Console.Write("Please enter a phrase: ");
            string phrase = Console.ReadLine();

            string reversephrase = "";
            
            for (int i = 0; i < phrase.Length; i++)
            {
                string ch = phrase.Substring(i, 1);
                reversephrase =  ch + reversephrase;
            }

            if (phrase == reversephrase)
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

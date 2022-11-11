using System;
using System.Collections.Generic;
using System.Text;

namespace Practise11112022
{
    public class PrintAlphabets
    {
        public void Aplhabets()
        {
            char c;
            Console.WriteLine( "\n");
            for (c = 'A'; c <= 'Z'; c++)
            {
                Console.Write(c);
            }
        }

        public void AplhabetsSmall()
        {
            char c;
            Console.WriteLine("\n");
            for (c = 'a'; c <= 'z'; c++)
            {
                Console.Write(c);
            }
        }
    }
}

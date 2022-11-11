using System;

namespace Practise11112022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practise Set 2");
            Console.WriteLine("Enter the option");
            Console.WriteLine("1. Print Alphabets A to Z"+"\n");
            int options = Convert.ToInt32(Console.ReadLine());
            switch (options)
            {
                case 1:
                    PrintAlphabets printAlphabets = new PrintAlphabets();
                    printAlphabets.Aplhabets();
                    break;
            }
        }
    }
}

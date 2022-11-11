using System;

namespace Practise11112022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practise Set 2");
            Console.WriteLine("Enter the option");
            Console.WriteLine("1. Print Alphabets A to Z"+"\n"+
                              "2. ASCII values of all characters"+"\n"+
                              "3. Multiplication Table"+"\n");
            int options = Convert.ToInt32(Console.ReadLine());
            switch (options)
            {
                case 1:
                    PrintAlphabets printAlphabets = new PrintAlphabets();
                    printAlphabets.Aplhabets();
                    break;
                case 2:
                    ASCIICharacters printASCIICharacters = new ASCIICharacters();
                    printASCIICharacters.ASCII();
                    break;
                case 3:
                    MultiplicationTable multiplicationTable = new MultiplicationTable();
                    multiplicationTable.table();
                    break;
            }
        }
    }
}

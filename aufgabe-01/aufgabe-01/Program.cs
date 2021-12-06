using System;

namespace aufgabe_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo!\r\n");
            Console.Write("Bitte gib ein beliebiges Wort ein und bestätige mit Enter: ");
            string input = Console.ReadLine();
            Console.WriteLine(input);
            Console.ReadKey();
        }
    }
}

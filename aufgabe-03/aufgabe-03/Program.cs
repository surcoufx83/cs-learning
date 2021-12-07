using System;
using System.Linq;

namespace aufgabe_03
{
    internal class Program
    {

        static ConsoleKey[] breakkeys = new ConsoleKey[]
        {
            ConsoleKey.Enter,
            ConsoleKey.Spacebar,
            ConsoleKey.Tab
        };
        static char[] breakchars = new char[]
        {
            '?', '!', '.', ',', ';', ':', '!', '?'
        };

        static string expectedWord = "Welt";

        static void Main(string[] args)
        {
            Console.WriteLine("Hallo!\r\n");
            Console.WriteLine("Bitte gib folgendes Wort ein und bestätige mit Enter: " + expectedWord);
            string word = "";
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            while (!breakkeys.Contains(keyInfo.Key) && !breakchars.Contains(keyInfo.KeyChar))
            {
                if (keyInfo.Key == ConsoleKey.Backspace)
                {
                    Console.Write(" \b");
                    word = word.Substring(0, word.Length - 1);
                }
                else
                    word += keyInfo.KeyChar;
                keyInfo = Console.ReadKey();
            }
            Console.WriteLine();
            Console.Write("Deine Eingabe: " + word + " - ");
            if (word == expectedWord)
            {
                Console.WriteLine("Das ist korrekt!");
            } else
            {
                Console.WriteLine("Das ist falsch!");
            }
            Console.ReadKey();
        }
    }
}

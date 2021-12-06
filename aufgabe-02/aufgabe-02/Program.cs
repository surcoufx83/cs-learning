using System;
using System.Linq;

namespace aufgabe_02
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

        static void Main(string[] args)
        {
            Console.WriteLine("Hallo!\r\n");
            Console.Write("Bitte gib ein beliebiges Wort ein und bestätige mit Enter: ");
            string word = "";
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            while (!breakkeys.Contains(keyInfo.Key) && !breakchars.Contains(keyInfo.KeyChar))
            {
                if (keyInfo.Key == ConsoleKey.Backspace)
                    word = word.Substring(0, word.Length - 1);
                else
                    word += keyInfo.KeyChar;
                keyInfo = Console.ReadKey();
            }
            Console.WriteLine("\r\n" + word);
            Console.ReadKey();
        }
    }
}

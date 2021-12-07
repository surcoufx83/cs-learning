using System;
using System.Linq;

namespace aufgabe_06
{
    internal class Program
    {

        static Random random;
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
        static string[] wordlist = new string[]
        {
            "Eine", "wunderbare", "Heiterkeit", "hat", "meine", "ganze", "Seele", "eingenommen", "gleich", "den",
            "süßen", "Frühlingsmorgen", "die", "ich", "mit", "ganzem", "Herzen", "genieße", "Ich", "bin", "allein",
            "und", "freue", "mich", "meines", "Lebens", "in", "dieser", "Gegend", "die", "für", "solche", "Seelen",
            "geschaffen", "ist", "wie", "die", "meine", "Ich", "bin", "so", "glücklich", "mein", "Bester", "so",
            "ganz", "in", "dem", "Gefühle", "von", "ruhigem", "Dasein", "versunken", "daß", "meine", "Kunst",
            "darunter", "leidet", "Ich", "könnte", "jetzt", "nicht", "zeichnen", "nicht", "einen", "Strich", "und",
            "bin", "nie", "ein", "größerer", "Maler", "gewesen", "als", "in", "diesen", "Augenblicken", "Wenn",
            "das", "liebe", "Tal", "um", "mich", "dampft", "und", "die", "hohe", "Sonne", "an", "der", "Oberfläche",
            "der", "undurchdringlichen", "Finsternis", "meines", "Waldes", "ruht", "und", "nur", "einzelne", "Strahlen"
        };

        static string expectedWord;

        static void Main(string[] args)
        {
            random = new Random();
            Console.WriteLine("Hallo!\r\n");
            while (cycle() == true)
            {

            }
        }

        static bool cycle()
        {
            expectedWord = wordlist[random.Next(wordlist.Length)];
            Console.WriteLine("Bitte gib folgendes Wort ein: " + expectedWord);
            string word = "";
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            DateTime start = DateTime.Now;
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
            DateTime end = DateTime.Now;
            TimeSpan timeSpan = end - start;

            Console.WriteLine();
            Console.Write("Deine Eingabe: " + word + " - ");
            if (word.ToLower() == "quit" || word == "")
            {
                return false;
            }
            else if (word == expectedWord)
            {
                Console.WriteLine("Das ist korrekt!");
            }
            else
            {
                Console.WriteLine("Das ist falsch!");
            }
            Console.WriteLine("Du hast " + Math.Round( timeSpan.TotalSeconds, 2) + " Sekunden benötigt.");
            Console.WriteLine();
            return true;
        }

    }
}

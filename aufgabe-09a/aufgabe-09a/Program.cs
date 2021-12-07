using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace aufgabe_09a
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
        static string savefile;
        static SortedList<int, object[]> highscores = new SortedList<int, object[]>();

        static void Main(string[] args)
        {
            loadFromFile();
            random = new Random();
            Console.WriteLine("Hallo!\r\n");
            while (true)
            {
                Console.WriteLine("Neues Spiel, los geht's ...");
                int wordcount = 0;
                int totalpoints = 0;
                while (wordcount < 10)
                {
                    int points = cycle(wordcount + 1);
                    if (points == -1)
                        return;
                    totalpoints += points;
                    wordcount++;
                }
                Console.WriteLine("Geschafft!");
                Console.WriteLine("Du hast " + totalpoints.ToString() + " Punkte erreicht!");
                Console.WriteLine("Beliebige Taste für nächste Runde...\r\n\r\n");

                Console.ReadKey();
            }
        }

        static int cycle(int counter)
        {
            expectedWord = wordlist[random.Next(wordlist.Length)];
            Console.WriteLine("[" + counter.ToString().PadLeft(2) + "/10] Bitte gib folgendes Wort ein: " + expectedWord);
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

            int falseLetters = 0;
            for (int i = 0; i < Math.Min(word.Length, expectedWord.Length); i++)
            {
                if (word[i] != expectedWord[i])
                    falseLetters++;
            }
            falseLetters += Math.Abs(expectedWord.Length - word.Length);

            int points = Math.Max(0, 100 - (int)((timeSpan.TotalSeconds - (double)expectedWord.Length) * 15) - (falseLetters * 35));

            Console.WriteLine();
            Console.Write("Deine Eingabe: " + word + " - ");
            if (word.ToLower() == "quit" || word == "")
            {
                return -1;
            }
            else if (word == expectedWord)
            {
                Console.WriteLine("Das ist korrekt!");
            }
            else
            {
                Console.WriteLine("Das ist falsch!");
            }
            Console.WriteLine();
            return points;
        }

        static void loadFromFile()
        {
            string[] savecontent;
            savefile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Schnelltippen", "Highscore.txt");
            if (!File.Exists(savefile))
            {
                saveToFile();
            }
            else
            {
                savecontent = File.ReadAllText(savefile).Split("\r\n");
                bool readhighscore = false;
                for (int i = 0; i < savecontent.Length; i++)
                {
                    if (savecontent[i] == "[Highscores]")
                    {
                        readhighscore = true;
                        continue;
                    }
                    if (readhighscore)
                    {
                        string[] line = savecontent[i].Split("\t");
                        highscores.Add(int.Parse(line[0]), new object[] { int.Parse(line[1]) , line[2]});
                        if (highscores.Count == 10)
                            readhighscore = false;
                    }
                }
            }
        }

        static void saveToFile()
        {
            if (highscores.Keys.Count < 10)
            {
                for (int i = highscores.Keys.Count; i < 10; i++)
                    highscores.Add(i, new object[] { 0, "" });
            }
            string savecontent = "";
            savecontent = "[Highscores]\r\n";
            foreach (int i in highscores.Keys)
            {
                savecontent += i.ToString() + "\t" + ((int)(highscores[i][0])).ToString() + "\t" + (string)(highscores[i][1]) + "\r\n";
            }
            FileInfo fileInfo = new FileInfo(savefile);
            if (!fileInfo.Directory.Exists)
                Directory.CreateDirectory(fileInfo.Directory.FullName);
            File.WriteAllText(savefile, savecontent);
        }

    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace aufgabe_12
{
    internal class Program
    {

        static Random random;
        static ConsoleColor defaultColor = Console.ForegroundColor;
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
        static int failcounter = 0;
        static string[] wordsEntered = new string[10];
        static string[] wordsExpected = new string[10];
        static int[] wordsPoints = new int[10];
        static double[] wordsTime = new double[10];
        static string savefile;
        static SortedList<int, object[]> highscores = new SortedList<int, object[]>();
        static int gamesPlayed = 0;
        static int gamesPlayedPointsTotal = 0;
        static int gamesPlayedWordsFailed = 0;

        static void Main(string[] args)
        {
            loadFromFile();
            random = new Random();
            while (true)
            {
                ConsoleKeyInfo keyInfo = mainmenu();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        startGame();
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        showHighscores();
                        break;

                    default:
                        return;
                }

            }
        }

        static int cycle(int counter)
        {
            Console.Clear();
            expectedWord = wordlist[random.Next(wordlist.Length)];
            wordsExpected[counter - 1] = expectedWord;
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
            wordsEntered[counter - 1] = word;
            wordsPoints[counter - 1] = points;
            wordsTime[counter - 1] = timeSpan.TotalSeconds;

            if (word.ToLower() == "quit" || word == "")
            {
                return -1;
            }
            if (falseLetters > 0)
                failcounter++;
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
                bool readstats = false;
                for (int i = 0; i < savecontent.Length; i++)
                {
                    if (savecontent[i] == "[Highscores]")
                    {
                        readhighscore = true;
                        continue;
                    }
                    if (savecontent[i] == "[Statistics]")
                    {
                        readstats = true;
                        continue;
                    }
                    if (readhighscore)
                    {
                        string[] line = savecontent[i].Split("\t");
                        highscores.Add(int.Parse(line[0]), new object[] { int.Parse(line[1]), line[2] });
                        if (highscores.Count == 10)
                            readhighscore = false;
                        continue;
                    }
                    if (readstats)
                    {
                        string[] line = savecontent[i].Split("\t");
                        gamesPlayed = int.Parse(line[0]);
                        gamesPlayedPointsTotal = int.Parse(line[1]);
                        gamesPlayedWordsFailed = int.Parse(line[2]);
                        readstats = false;
                        continue;
                    }
                }
            }
        }

        static ConsoleKeyInfo mainmenu()
        {
            Console.Clear();
            Console.WriteLine("\r\nSchnelltippen v1.0\r\n\r\n\r\n");
            if (gamesPlayed > 0)
            {
                Console.WriteLine("Bisher wurden " + gamesPlayed + " Spiele gespielt.");
                Console.WriteLine("Die durchschnittliche Punktzahl beträgt " + (gamesPlayedPointsTotal / gamesPlayed).ToString() + ".");
                Console.WriteLine(((double)gamesPlayedWordsFailed / (double)(gamesPlayed * 10) * 100.0).ToString("0") + "% der Wörter wurden falsch eingegeben :D\r\n\r\n");
            }
            Console.WriteLine("Du befindest dich im Hauptmenü. Wähle mit den Tasten 1-3 eine der folgenden Optionen:\r\n");
            Console.WriteLine("[1] Spiel starten");
            Console.WriteLine("[2] Bestenliste");
            Console.WriteLine("[3] Beenden\r\n\r\n");
            Console.Write("Deine Auswahl: ");
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            ConsoleKey[] acceptedKeys = new ConsoleKey[] {
                ConsoleKey.D1,
                ConsoleKey.D2,
                ConsoleKey.D3,
                ConsoleKey.NumPad1,
                ConsoleKey.NumPad2,
                ConsoleKey.NumPad3,
                ConsoleKey.Enter,
                ConsoleKey.Escape
            };
            while (!acceptedKeys.Contains(keyInfo.Key))
            {
                keyInfo = Console.ReadKey(true);
            }
            return keyInfo;
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
            savecontent += "[Statistics]\r\n";
            savecontent += gamesPlayed + "\t";
            savecontent += gamesPlayedPointsTotal + "\t";
            savecontent += gamesPlayedWordsFailed + "\r\n";
            FileInfo fileInfo = new FileInfo(savefile);
            if (!fileInfo.Directory.Exists)
                Directory.CreateDirectory(fileInfo.Directory.FullName);
            File.WriteAllText(savefile, savecontent);
        }

        static void showHighscores()
        {
            Console.Clear();
            Console.WriteLine("\r\nSchnelltippen v1.0\r\n\r\n\r\n");
            Console.WriteLine("Bestenliste");
            Console.WriteLine("============================================================");
            foreach (int key in highscores.Keys)
            {
                Console.WriteLine((key + 1).ToString().PadLeft(3) + ".   " + (highscores[key][0].ToString() + " Punkte").PadRight(14) + highscores[key][1]);
            }
            Console.WriteLine("\r\n\r\n" +
                "Beliebige Taste für Hauptmenü...\r\n\r\n");
            Console.ReadKey();
        }

        static void startGame()
        {
            Console.Clear();
            Console.WriteLine("Neues Spiel, los geht's ...");
            int wordcount = 0;
            int totalpoints = 0;
            failcounter = 0;
            for (int i = 0; i < 10; i++)
            {
                wordsEntered[i] = "";
                wordsExpected[i] = "";
                wordsPoints[i] = 0;
                wordsTime[i] = 0.0;
            }
            while (wordcount < 10)
            {
                int points = cycle(wordcount + 1);
                if (points == -1)
                    return;
                totalpoints += points;
                wordcount++;
            }
            Console.WriteLine("Geschafft!");
            Console.WriteLine("Du hast " + totalpoints.ToString() + " Punkte erreicht!\r\n\r\n");
            Console.WriteLine("So setzt sich die Punktzahl zusammen:");
            Console.WriteLine("    Wort                   Zeit         Fehler      Punkte");
            for (int i = 0; i < 10;i++)
            {
                Console.Write(" " + (i + 1).ToString().PadRight(3));
                int fc = 0;
                for (int j = 0; j < Math.Max(wordsEntered[i].Length, wordsExpected[i].Length); j++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                    if (j >= wordsEntered[i].Length || j >= wordsExpected[i].Length || wordsExpected[i][j] != wordsEntered[i][j])
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        fc++;
                    }
                    else
                        Console.ForegroundColor = ConsoleColor.Green;

                    if (j < wordsExpected[i].Length)
                        Console.Write(wordsExpected[i][j]);
                    else
                        Console.Write(wordsEntered[i][j]);

                }
                Console.ForegroundColor = defaultColor;
                Console.Write("".PadRight(20 - Math.Max(wordsEntered[i].Length, wordsExpected[i].Length)));
                Console.Write(wordsTime[i].ToString("0.0").PadLeft(6) + "s");
                Console.Write(fc.ToString().PadLeft(14));
                Console.Write(wordsPoints[i].ToString().PadLeft(10) + "\r\n");

            }

            int position = 10;
            foreach (int key in highscores.Keys)
            {
                if (totalpoints > (int)highscores[key][0])
                {
                    position = key;
                    break;
                }
            }
            if (position < 10)
            {
                Console.WriteLine("\r\nGratulation! Die Punktzahl reicht für Platz " + (position + 1).ToString());
                Console.WriteLine("Möchtest du dich in die Bestenliste eintragen? [j/N]");
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.J)
                {
                    Console.Write("Bitte gib Deinen Namen ein: ");
                    string name = Console.ReadLine();
                    highscores.Remove(9);
                    for (int i = 8; i >= position; i--)
                    {
                        highscores.Add(i + 1, highscores[i]);
                        highscores.Remove(i);
                    }
                    highscores.Add(position, new object[] { totalpoints, name });
                    Console.WriteLine("Klasse. " + name + " ist jetzt " + (position + 1).ToString() + ". in der Bestenliste!\r\n\r\n");
                }
                else
                    Console.WriteLine("\r\n\r\n");
            }
            else
            {
                Console.WriteLine("\r\nDas reicht leider nicht für die Bestenliste. Viel Glück beim nächsten Mal!\r\n\r\n");
            }
            gamesPlayed += 1;
            gamesPlayedPointsTotal += totalpoints;
            gamesPlayedWordsFailed += failcounter;
            saveToFile();
            Console.WriteLine("Beliebige Taste für Hauptmenü...\r\n\r\n");

            Console.ReadKey();
        }

    }
}

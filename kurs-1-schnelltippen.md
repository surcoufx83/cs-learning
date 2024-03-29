# Kurs #1 - Schnelltipp-Spiel
In diesem ersten Kurs programmierst du ein Spiel in welchem es darum geht, so schnell wie möglich 
zehn Wörter korrekt einzugeben. Dafür erhält der Spieler Punkte abhängig von Genauigkeit und 
Geschwindigkeit. Der Kurs ist so aufgebaut, dass in vielen Schritten das Spiel entsteht und nicht
alles auf einmal programmiert werden muss. 
Damit entsteht dieses Programm so wie im Programmieralltag: Es gibt eine Basisanforderung (hier
Aufgabe 1) und darauf aufsetzende Erweiterungen.

Für Programmieranfänger empfehle ich folgenden Ablauf: Lies dir die jeweilige Aufgabe durch (Start
mit Aufgabe 1) und gib die Aufgabenstellung mit eigenen Worten wieder. Anschließend überlegst du:
1. Was müsste nach und nach passieren, damit die Aufgabenstellung erfüllt ist?
2. Wie wird das umgesetzt? Welche Funktionen müssen aufgerufen werden?

Tipp: Übernimm dich nicht. Beachte ausschließlich die jeweilige Aufgabe und noch nicht die
nachfolgenden. Wenn du ein Profi bist, ist der Kurs sowieso nicht das Richtige für dich ;).

Anschließend setzt du die Aufgabe im Code um. Es gibt nie genau eine Lösung, wichtig ist
zuerst einmal, dass die Aufgabe erfüllt ist. Wenn dein Programm funktioniert und macht, was die 
Aufgabenstellung vorgibt, dann hast du sie erfolgreich umgesetzt.
Am Ende des Kurses findest du Links zu Beispiellösungen.

## Aufgabe 1
Es soll ein Konsolenprogramm programmiert werden, welches den Anwender begrüßt und um die Eingabe 
eines Wortes bittet. Das Wort soll per Enter-Taste bestätigt werden. Nach der Eingabe wird dieses 
Wort nochmal in der Konsole ausgegeben. Nach der nächsten durch den Anwender gedrückten Taste 
beendet sich das Programm von allein.

Hilfreiche Methoden:
- Methode Console.WriteLine()
- Methode Console.ReadLine()
- Methode Console.ReadKey()

### Bearbeiten der Aufgabe
1. Mach dir Gedanken, welche Schritte für die Aufgabenstellung erforderlich sind. Hast du
noch Fragen dazu, ist etwas unklar?
2. Schreibe dir die einzelnen Schritte auf ein Blatt Papier oder in ein Word-Dokument. 
3. Sobald das erledigt ist, bespreche den Ablauf mit einem Coach oder anderen. Fehlt noch etwas?
Wird das Ziel der Aufgabe damit erfüllt?
4. Danach wird die Aufgabe entsprechend umgesetzt, bis die Aufgabe tatsächlich erfüllt ist.
5. Nach einer Funktionsprüfung kann die nächste Aufgabe begonnen werden.

## Aufgabe 2
Das bestehende Konsolenprogramm soll so verändert werden, dass der Benutzer nicht mehr 
unbedingt die Entertaste drücken muss, sondern zum Beispiel auch die Leer- oder 
Tabulatortaste verwenden kann. Ein Wort ist also durch Enter-, Tabulator-, Leerzeichen, 
aber auch die Zeichen ,.;:!? begrenzt. Ein ' oder andere Sonderzeichen gelten hingegen 
nicht als Wortende.

(Ab hier gilt: Sollte in einer der folgenden Aufgaben von der Enter-Taste gesprochen werden,
so sind auch die anderen Tasten bzw. Zeichen (Tab, Leertaste, ,.;:!?) gemeint.)

Hilfreiche Methoden, Klassen, Objekte:
- Klasse ConsoleKeyInfo
- Arrays
- while-Schleifen, if-Bedingungen

### Bearbeiten der Aufgabe
Für alle Aufgaben gilt: Mach dir zuerst Gedanken. Was ist die Aufgabenstellung, habe ich 
Fragen dazu? Nimm dir auch wieder die Zeit, den Ablauf auf Papier zu skizieren. Wenn
alles klar ist, leg los, setze die Aufgabe um und nach der Funktionsprüfung gehts zur 
nächsten Aufgabe.

## Aufgabe 3
Das bestehende Konsolenprogramm soll nun so abgeändert werden, dass das Programm ein 
Wort vorgibt, welches der Anwender einzugeben hat. Das Wort lautet "Welt". Nach 
der Eingabe wird nicht nur das eingegebene Wort ausgegeben, sondern auch eine 
Information, ob der Anwender es richtig geschrieben hat.

## Aufgabe 4
Das bestehende Konsolenprogramm soll so abgeändert werden, dass es nicht mehr ein 
starres Wort vorgibt, sondern aus einer [Liste von 100 Wörtern](aufgabe-4-wortliste) 
eines zufällig auswählt.

## Aufgabe 5
Das Programm soll so verändert werden: Das Programm wird nun immer ein neues Wort 
in die Konsole ausgegeben, welches der Anwender dann eingeben soll. Auch das wird 
wieder auf Richtigkeit geprüft (wie zuvor beim ersten Wort auch). Das Programm 
beendet sich nun erst, wenn der Benutzer das Wort "quit" oder nichts eingegeben 
und mit der Enter-Taste bestätigt hat.

Hilfreiche Methoden, Klassen, Objekte:
- Klasse Random

## Aufgabe 6
Das Programm soll so verändert werden: Das Programm stoppt nun die Zeit zwischen Eingabe 
des ersten Zeichen des Wortes durch das Programm und dem Abschließen des Wortes. 
Die benötigte Zeit in Sekunden und Millisekunden wird ebenfalls dem Benutzer angezeigt.

Hilfreiche Methoden, Klassen, Objekte:
- Klasse DateTime
- Klasse TimeSpan
- Methode Math.Round

## Aufgabe 7
Das Programm soll so verändert werden: Nachdem der Benutzer ein Wort eingegeben hat, 
wird ein Punktewert errechnet. Er erhält 100 Punkte, wenn er es ohne Fehler in einer vorgegebenen Zeit
eingegeben hat. Die vorgegebene Zeit entspricht 1s pro Zeichen des erwarteten Wortes
("Welt" = 4s, "in" = 2s). Er erhält mehr Punkte wenn er schneller war, bzw. weniger, 
wenn er langsamer war entsprechend: (sekunden - wortlänge) * 15; wobei sekunden bedeutet sekunden 
inkl. Nachkommastellen. Pro falsch eingegebenem Buchstaben werden 35 Punkte abgezogen. 
Die Punktzahl darf 0 nicht unterschreiten. Die Punkte werden zusätzlich am Ende ausgegeben.

Hilfreiche Methoden, Klassen, Objekte:
- Methoden Math.Abs, Math.Min, Math.Max

## Aufgabe 8
Das Programm soll so verändert werden: Zeit und Punkte pro Wort werden nicht 
mehr angezeigt. Nach dem zehnten eingegebenen Wort wird die Summe der Punkte aller 10 
Versuche ausgegeben. Nachdem eine beliebige Taste gedrückt wurde, beginnt ein neuer Durchlauf 
mit wieder 10 Worten (endlos, bis Spieler abbricht (quit/leere Eingabe) gem. Aufgabe 5).

Zusätzlich soll ein Zähler vor dem einzugebenen Wort angezeigt werden, damit der Spieler
weiß, wie viele Worte noch kommen, zum. Beispiel "[ 1/10] Bitte gib folgendes Wort ein: ...".

## Aufgabe 9a
Es soll nun einen Highscore-Liste eingeführt werden. Diese soll in einer Datei im 
Benutzerverzeichnis abgelegt werden (z.B. %localappdata%\Schnelltippen\Highscore.txt).
Ist die Datei beim Programmstart nicht vorhanden, soll sie erstellt werden. Die 
Datei soll dann die Möglichkeit bereitstellen, 10 Einträge bestehend aus Punktzahl und
Namen zu speichern. Das Datenformat bleibt dir überlassen. Es kann purer Text sein, 
könnte aber auch json oder csv sein.
Todos für diese Aufgabe:
1. Beim Start des Programms wird eine Datei `Highscore.txt` im Ordner `%localappdata%\Schnelltippen`
   erstellt, sofern sie noch nicht existiert.
2. Beim Neuerstellen der Datei werden 10 Einträge mit 0 Punkten und ohne Namen
   angelegt.
3. Existiert die Datei bereits, oder wurde sie neu erstellt, wird die Datei eingelesen
   und die 10 Platzierungen werden in ein Array oder eine Liste geladen.

Hilfreiche Methoden, Klassen, Objekte:
- Methoden Path.Combine, Environment.GetFolderPath
- Enum/Aufzählung Environment.SpecialFolder
- Klasse FileInfo
- Methoden File.Exists, Directory.CreateDirectory, File.WriteAllText, File.ReadAllText
- Klasse SortedList oder Arrays

## Aufgabe 9b
Beendet der Spieler nun alle zehn Worte bekommt er (wie in Aufgabe 8 vorgebeben), seine
Gesamtpunktzahl angezeigt. Zusätzlich soll nun angezeigt werden, welchen Platz er damit in 
der Highscore-Liste erreicht. Er kann nun mit "j" oder "ja" sich in die Highscore eintragen
oder mit allem anderen ein neues Spiel beginnen. Soll er eingetragen werden, so muss er noch
einen Namen angeben, der zusammen mit der Punktzahl gespeichert wird. Eintragen in die 
Highscores darf nicht möglich sein, wenn er nicht unter den ersten zehn gelandet ist. 
Es werden immer nur die zehn Besten gespeichert.

## Aufgabe 10
Das Programm soll nun zu allererst ein Menü ausgeben. Als Optionen sollen dem Anwender 
die Optionen "Neues Spiel", "Highscores", "Beenden" zur Auswahl stehen. Bei Auswahl von 
"Neues Spiel" beginnt das Spiel, bei Auswahl von "Highscores" wird die Liste der besten 
Ergebnisse ausgegeben und "Beenden" beendet das Programm. Nach einem Spiel (10 Wörter) 
wird anschließend wieder das Hauptmenü ausgegeben.
Wie die Auswahl stattfindet bleibt dir überlassen. Eine einfache Möglichkeit ist jedem der
Menüpunkte eine Zahl zuzuweisen (1-3) und wenn der Benutzer die entsprechende Taste drückt,
wird die Aktion ausgeführt. Eine komplizierte Variante ist, dass der Anwender die Pfeiltasten 
hoch und runter verwendet und damit einen Menüpunkt auswählt.

Zusätzlich soll nun immer der Inhalt des Konsolenfensters gelöscht werden, wenn:
1. das Hauptmenü aufgerufen wird,
2. oder die Bestenliste angezeigt wird,
3. oder im Spiel ein neues Wort angezeigt wird.

Die Bestätigung ob ein Wort korrekt eingegeben wurde oder nicht kann damit entfallen.


## Aufgabe 11
Das Programm soll nun mitzählen:
- wie viele Spiele bereits gespielt wurden ,
- was die durchschnittliche Punktzahl aller Spiele (nicht nur der letzten 10) ist
- wieviel % der Wörter bisher korrekt eingegeben wurden.

Die Werte werden im Hauptmenü angezeigt. Es werden nur Spiele berücksichtigt, die vollständig 
sind, also alle 10 Wörter eingegeben wurden und es ist irrelevant, ob etwas in die 
Highscore-Liste eingetragen wurde oder nicht. Wie die Werte gespeichert werden, bleibt dir
überlassen. Du kannst dafür die `Highscore.txt` verwenden, eine andere Datei oder einen 
ganz anderen Weg.

## Aufgabe 12
Nach Abschluss des zehnten Wortes, bevor die Punktzahl angezeigt wird, werden die zehn eingegebenen
Wörter aufgelistet und darin werden farblich die richtigen und falschen Buchstaben markiert: 
grüne Buchstaben für richtige und rote für falsch eingegebene. Jeweils hinter den Wörtern wird
die benötigte Zeit, die Anzahl der Fehler und die errechnete Punktzahl angezeigt.

## Aufgabe 13
Gruppiere die Beispielwörter nach Länge (<5 Buchstaben, <9 Buchstaben, <12 Buchstaben, >= 12Buchstaben).
Bei der zufälligen Auswahl ist nun zu bedenken: Pro Spiel (10 Worte) nur noch: 3x <5, 3x <9, 2x <12, 1x >=12
um eine bessere Vergleichbarkeit zu gewährleisten. Kein Wort darf doppelt abgefragt werden.

## Aufgabe 14
Erzeuge basierend auf der Unterscheidung von Aufgabe 13 eine Datenbankdatei (in einem beliebigen Format). Befülle die Datei mit beliebig vielen Wörtern (zum Beispiel die 100 Beispielwörter). Es sollen nun keine Duplikate von Wörtern mehr in der Datenbank vorkommen. Statt aus dem bisherigen Array soll die Datenbank (eigene Klasse) ein Wort zurückliefern welches den Kriterien (wieder gem. Aufgabe 13) entspricht. Es sollen insgesamt genau 5 Worte mit Großbuchstabe am Anfang gewählt werden, 5 die mit Kleinbuchstaben beginnen.

## Aufgabe 15
Erzeuge einen neuen Hauptmenü-Eintrag: "Neues Wort in Datenbank". Wählt der Anwender diesen, so wird er aufgefordert ein Wort einzugeben. Sofern das Wort nicht in der Datenbank steht: Die Eingabe wird nochmal als Text in die Konsole ausgegeben und der Anwender soll bestätigen, dass dieses Wort in die Datenbank aufgenommen wird. Sofern er es bestätigt, wird die Datenbank um dieses neue Wort ergänzt und die entsprechende Datei im Dateisystem aktualisiert.

## Aufgabe 16
Erzeuge einen neuen Hauptmenü-Eintrag "Modus Blinde Kuh". Der Eintrag startet auch ein neues Spiel. Pro 3 Buchstaben ist ein Buchstabe durch ein ? maskiert, das heißt der User sieht nicht, welcher Buchstabe erwartet wird, er muss diesen korrekt erraten. Für jedes korrekt erratene ? gibt es 25 extra Punkte, Fehler führen zu Punktabzug von 35 Punkten. Die Ergebnistabelle soll nun zusätzlich das erwartete Wort (ohne ?) anzeigen. Spiele in diesem Modus erhalten eine Markierung (deiner Wahl) in der Highscore-Tabelle, sodass klar ist, dass es sich um diesen Spielmodus handelt.

## Aufgabe x
Was fällt dir noch so ein? Was gehört hier noch mit rein?

# Beispiellösungen
Sei ehrlich zu Dir! Nutze die folgenden Beispiele nur, um einen Vergleich zu deiner eigenen Lösung zu 
erhalten. Schau nicht in die Beispiele, wenn du noch nicht fertig bist. 

- [Aufgabe 1](https://github.com/surcoufx83/cs-learning/blob/stefan/aufgabe-01/aufgabe-01/Program.cs)
- [Aufgabe 2](https://github.com/surcoufx83/cs-learning/blob/stefan/aufgabe-02/aufgabe-02/Program.cs)
- [Aufgabe 3](https://github.com/surcoufx83/cs-learning/blob/stefan/aufgabe-03/aufgabe-03/Program.cs)
- [Aufgabe 4](https://github.com/surcoufx83/cs-learning/blob/stefan/aufgabe-04/aufgabe-04/Program.cs)
- [Aufgabe 5](https://github.com/surcoufx83/cs-learning/blob/stefan/aufgabe-05/aufgabe-05/Program.cs)
- [Aufgabe 6](https://github.com/surcoufx83/cs-learning/blob/stefan/aufgabe-06/aufgabe-06/Program.cs)
- [Aufgabe 7](https://github.com/surcoufx83/cs-learning/blob/stefan/aufgabe-07/aufgabe-07/Program.cs)
- [Aufgabe 8](https://github.com/surcoufx83/cs-learning/blob/stefan/aufgabe-08/aufgabe-08/Program.cs)
- [Aufgabe 9a](https://github.com/surcoufx83/cs-learning/blob/stefan/aufgabe-09a/aufgabe-09a/Program.cs)
- [Aufgabe 9b](https://github.com/surcoufx83/cs-learning/blob/stefan/aufgabe-09b/aufgabe-09b/Program.cs)
- [Aufgabe 10](https://github.com/surcoufx83/cs-learning/blob/stefan/aufgabe-10/aufgabe-10/Program.cs)
- [Aufgabe 11](https://github.com/surcoufx83/cs-learning/blob/stefan/aufgabe-11/aufgabe-11/Program.cs)
- [Aufgabe 12](https://github.com/surcoufx83/cs-learning/blob/stefan/aufgabe-12/aufgabe-12/Program.cs)

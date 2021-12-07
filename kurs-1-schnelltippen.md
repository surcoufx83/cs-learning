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

### Bearbeiten der Aufgabe
1. Mach dir Gedanken, welche Schritte für die Aufgabenstellung erforderlich sind.
2. Schreibe dir die einzelnen Schritte auf ein Blatt Papier oder in ein Word-Dokument. 
3. Sobald das erledigt ist, bespreche den Ablauf mit einem Coach oder anderen. Fehlt noch etwas?
Wird das Ziel der Aufgabe damit erfüllt?
5. Danach wird die Aufgabe entsprechend umgesetzt, bis die Aufgabe tatsächlich erfüllt ist.
6. Nach einer Funktionsprüfung kann die nächste Aufgabe begonnen werden.

## Aufgabe 2
Das bestehende Konsolenprogramm soll so verändert werden, dass der Benutzer nicht mehr 
unbedingt die Entertaste drücken muss, sondern zum Beispiel auch die Leer- oder 
Tabulatortaste verwenden kann. Ein Wort ist also durch Enter-, Tabulator-, Leerzeichen, 
aber auch die Zeichen ,.;:!? begrenzt. Ein ' oder andere Sonderzeichen gelten hingegen 
nicht als Wortende.

(Ab hier gilt: Sollte in einer der folgenden Aufgaben von der Enter-Taste gesprochen werden,
so sind auch die anderen Tasten bzw. Zeichen (Tab, Leertaste, ,.;:!?) gemeint.)

### Bearbeiten der Aufgabe
Ergänze die vorherige von dir geschriebene Ablaufliste um die notwendigen Änderungen, 
bzw. ersetze nicht mehr benötigte Funktionen. Nach einer Diskussion dazu wird auch diese 
Aufgabe im Quellcode umgesetzt und anschließend getestet. Danach kann die dritte 
Aufgabe erledigt werden.

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

## Aufgabe 6
Das Programm soll so verändert werden: Das Programm stoppt nun die Zeit zwischen Eingabe 
des ersten Zeichen des Wortes durch das Programm und dem Abschließen des Wortes. 
Die benötigte Zeit in Sekunden und Millisekunden wird ebenfalls dem Benutzer angezeigt.

## Aufgabe 7
Das Programm soll so verändert werden: Nachdem der Benutzer ein Wort eingegeben hat, 
wird ein Punktewert errechnet. Er erhält 100 Punkte, wenn er es ohne Fehler in genau 
10 Sekunden eingegeben hat. Er erhält mehr Punkte wenn er schneller war, bzw. weniger, 
wenn er langsamer war entsprechend: (sekunden - 3) * 15; wobei sekunden bedeutet sekunden 
inkl. millisekunden als Nachkommastellen. Pro falsch eingegebenem Buchstaben werden 
20 Punkte abgezogen. Die Punktzahl darf 0 nicht unterschreiten. Die Punkte werden 
zusätzlich am Ende ausgegeben.

## Aufgabe 8
Das Programm soll so verändert werden: Nach dem zehnten eingegebenen Wort wird die Summe 
der Punkte aller 10 Versuche ausgegeben. Diese Punkte werden mit einer Highscore-Liste 
abgeglichen, welche in einer Datei im Benutzer-Verzeichnis abgelegt wird. Dabei wird 
direkt geprüft, an welcher Stelle er gelandet ist. Er erhält nun auch die Möglichkeit, 
sich in diese Highscore-Liste mit selbst gewähltem Namen einzutragen. Die Highscore-Liste 
enthält immer nur die besten zehn Ergebnisse. Existiert die Datei noch nicht, enthält 
sie ausschließlich 0-Punkte-Ergebnisse.

## Aufgabe 9
Das Programm soll nun zu allererste ein Menü ausgeben. Als Optionen sollen dem Anwender 
die Optionen "Neues Spiel", "Highscores", "Beenden" zur Auswahl stehen. Bei Auswahl von 
Neues Spiel beginnt das Spiel, bei Auswahl von Highscore wird die Liste der besten 
Ergebnisse ausgegeben werden und beenden beendet das Programm. Nach einem Spiel (10 Wörter) 
wird anschließend wieder das Hauptmenü ausgegeben.

## Aufgabe 10
Das Programm soll nun mitzählen, wie viele Spiele bereits gespielt wurden. Der Zähler 
wird im Hauptmenü angezeigt. Der Zähler wird nur für vollständige Spiele (10 Worte) erhöht. 


# Beispiellösungen
- [Aufgabe 1](https://github.com/surcoufx83/cs-learning/blob/stefan/aufgabe-01/aufgabe-01/Program.cs)
- [Aufgabe 2](https://github.com/surcoufx83/cs-learning/blob/stefan/aufgabe-02/aufgabe-02/Program.cs)
- [Aufgabe 3](https://github.com/surcoufx83/cs-learning/blob/stefan/aufgabe-03/aufgabe-03/Program.cs)
- [Aufgabe 4](https://github.com/surcoufx83/cs-learning/blob/stefan/aufgabe-04/aufgabe-04/Program.cs)
- [Aufgabe 5](https://github.com/surcoufx83/cs-learning/blob/stefan/aufgabe-05/aufgabe-05/Program.cs)
- [Aufgabe 6](https://github.com/surcoufx83/cs-learning/blob/stefan/aufgabe-06/aufgabe-06/Program.cs)



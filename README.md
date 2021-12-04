# C# Kurs
Dieser Kurs ist eine Einführungsaufgabe für die Programmierung mit C# Basiswissen. Der Kurs ist so aufgebaut, dass er Aufgaben stellt, die zu erst im Kopf bearbeitet und durchgespielt werden, bevor die eigentliche Umsetzung in der Programmierumgebung stattfindet. 

In diesem Kurs wirst du mit einer Aufgabenstellung konfrontiert. Der Ablauf, wie das programmiertechnisch zu realisieren ist wird dann zuerst beschrieben (Papier, Word, etc) und diskutiert. Erst danach wird die Aufgabe auch mit dem Visual Studio absolviert. Nachdem die Aufgabe gelöst ist, gibt es mehrere Erweiterungsaufgaben, die jeweils auf die vorherige ausbauen. Besonders im Berufsalltag als Programmierer muss man immer wieder bereits bestehenden Code verstehen und verändern um neue Ziele zu erreichen.

## Aufgabe I
Es soll ein Konsolenprogramm programmiert werden, welches den Anwender begrüßt und um die Eingabe eines Wortes bittet. Das Wort soll per Enter-Taste bestätigt werden. Nach der Eingabe wird dieses Wort nochmal in der Konsole ausgegeben. Nach der nächsten durch den Anwender gedrückten Taste beendet sich das Programm von allein.

### Bearbeiten der Aufgabe
1. Mach dir Gedanken, welche Schritte für die Aufgabenstellung erforderlich sind.
2. Schreibe dir die einzelnen Schritte auf ein Blatt Papier oder in ein Word-Dokument. Erforderlich sind: Nummerierung (in welcher Reihenfolge was zu tun ist), Kurzbeschreibung des Schrittes und Stichpunktartig wie das erledigt werden kann. 
   - So könnte das aussehen:
   - 1 Konsolenprogramm erstellen: im Visual Studio wird ein neues Konsolenprogramm C# .net framework erstellt.
   - 2 Ausgabe Begrüßung: mittels Console.WriteLine() wird in der main Methode der Text "Hallo! Bitte geben Sie ein Wort ein und drücken Sie anschließend die Enter-Taste" ausgegeben.
   - 3 ...
3. Sobald das erledigt ist, wird das gemeinsam besprochen und ggf. Ergänzungen oder Änderungen beschrieben.
4. Danach wird die Aufgabe entsprechend umgesetzt, bis die Aufgabe tatsächlich erfüllt ist.
5. Nach einer Funktionsprüfung kann die nächste Aufgabe begonnen werden.

## Aufgabe II
Das bestehende Konsolenprogramm soll so verändert werden, dass der Benutzer nicht mehr unbedingt die Entertaste drücken muss, sondern zum Beispiel auch die Leer- oder Tabulatortaste verwenden kann. Ein Wort ist also durch Enter-, Tabulator-, Leerzeichen, aber auch die Zeichen ,.;:!? begrenzt. Ein ' oder andere Sonderzeichen gelten hingegen nicht als Wortende.

### Bearbeiten der Aufgabe
Ergänze die vorherige von dir geschriebene Ablaufliste um die notwendigen Änderungen, bzw. ersetze nicht mehr benötigte Funktionen. Nach einer Diskussion dazu wird auch diese Aufgabe im Quellcode umgesetzt und anschließend getestet. Danach kann die dritte Aufgabe erledigt werden.

## Aufgabe III
Das bestehende Konsolenprogramm soll nun so abgeändert werden, dass das Programm ein Wort vorgibt, welches der Anwender einzugeben hat. Das Wort lautet "Welt". Nach der Eingabe wird nicht nur das eingegebene Wort ausgegeben, sondern auch eine Information, ob der Anwender es richtig geschrieben hat.

## Aufgabe IV
Das bestehende Konsolenprogramm soll so abgeändert werden, dass es nicht mehr ein starres Wort vorgibt, sondern aus einer [Liste von 100 Wörtern](aufgabe-4-wortliste) eines zufällig auswählt.

## Aufgabe V
Das Programm soll so verändert werden: Das Programm wird nun immer ein neues Wort in die Konsole ausgegeben, welches der Anwender dann eingeben soll. Auch das wird wieder auf Richtigkeit geprüft (wie zuvor beim ersten Wort auch). Das Programm beendet sich nun erst, wenn der Benutzer das Wort "quit" eingegeben und mit der Enter-Taste bestätigt hat.

## Aufgabe VI
Das Programm soll so verändert werden: Das Programm stoppt nun die Zeit zwischen Ausgabe des Wortes durch das Programm und dem Drücken der Entertaste, nachdem der Anwender das Wort eingegeben hat. Die benötigte Zeit in Sekunden und Millisekunden wird ebenfalls dem Benutzer angezeigt.

## Aufgabe VII
Das Programm soll so verändert werden: Nachdem der Benutzer ein Wort eingegeben hat, wird ein Punktewert errechnet. Er erhält 100 Punkte, wenn er es ohne Fehler in genau 1 Sekunde eingegeben hat. Er erhält mehr Punkte wenn er schneller war, bzw. weniger, wenn er langsamer war entsprechend: (sekunden-1) * 5; wobei sekunden bedeutet sekunden inkl. millisekunden als Nachkommastellen. Pro falsch eingegebenem Buchstaben werden 20 Punkte abgezogen. Die Punktzahl kann 0 nicht unterschreiten. Die Punkte werden zusätzlich am Ende ausgegeben.

## Aufgabe VII
Das Programm soll so verändert werden: Nach dem zehnten eingegebenen Wort wird die Summe der Punkte errechnet. Diese Punkte werden mit einer Highscore-Liste abgeglichen, welche in einer Datei im %localappdata%-Verzeichnis abgelegt wird. Dabei wird direkt geprüft, an welcher Stelle er gelandet ist. Er erhält nun auch die Möglichkeit, sich in diese Highscore-Liste mit selbst gewähltem Namen einzutragen. Die Highscore-Liste enthält immer nur die besten zehn Ergebnisse. Existiert die Datei noch nicht, enthält sie ausschließlich 0-Punkte-Ergebnisse.

## Aufgabe VIII 
Das Programm soll nun zu allererste ein Menü ausgeben. Als Optionen sollen dem Anwender die Optionen "Neues Spiel", "Hoghscores", "Beenden" zur Auswahl stehen. Bei Auswahl von Neues Spiel beginnt das Spiel, bei Auswahl von Highscore wird die Liste der besten Ergebnisse ausgegeben werden und beenden beendet das Programm. Nach einem Spiel (10 Wörter) wird anschließend wieder das Hauptmenü ausgegeben.

## Aufgabe IX
Das Programm soll nun mitzählen, wie viele Spiele bereits gespielt wurden. Der Zähler wird im Hauptmenü angezeigt. Der Zähler wird nur für vollständige Spiele (10 Worte) erhöht. 



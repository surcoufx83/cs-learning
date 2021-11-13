# C# Kurs
Dieser Kurs soll eine Einleitung in C# bereitstellen und im Besonderen Abläufe des Programms zu erdenken, bevor es umgesetzt wird. Das ermöglicht eine Vorabschätzung des Aufwandes und erforderlicher Resourcen und eine effiziente Programmierung.

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
Das bestehende Konsolenprogramm soll nun so abgeändert werden, dass es nicht mehr ein starres Wort vorgibt, sondern aus einer [Liste von 100 Wörtern](aufgabe-4-wortliste) eines zufällig auswählt.

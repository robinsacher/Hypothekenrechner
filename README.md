 # Projekt-Dokumentation


Sacher, Warnebold, Müller, Hitz

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   | ✍️ Jedes Mal, wenn Sie an dem Projekt arbeiten, fügen Sie hier eine neue Zeile ein und beschreiben in *einem* Satz, was Sie erreicht haben. |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

Ein Hypothekenrechner der die Laufzeit und kosten berechnen kann, sowie mieten und kaufen vergleichen.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1   |  muss          |  Funktional     | Als user möchte ich den Betrag für die Hypothek eingeben können
|   2 |    muss        |  Funktional     | Als user möchte ich den aktuellen Zinssatz eingeben können
|  3  |    muss        |  Funktional     | Als user möchte ich die jährliche Zinsbelastung berechnen können
|  4  |   muss         |  Funktional     | Als user möchte ich den Hypothekbetrag und Zinsbetrag berechnen können
|  5  |  muss          |  Funktional     | Als user möchte ich die benötigten finanziellen Mitteln für den Kauf der Liegenschaft sowie der Hypothekarzinsbelastung angeben können
| 6   |   muss         | Funktional      | Als user möchte ich berechnen können nach wie vielen Jahren der kauf einer Liegenschaft günstiger im Vergleich zur Miete ist(Jährliche Mietkosten)
| 7   |  muss          |  Funktional     | Als user möchte ich berechnen können, welchen Betrag ich monatlich amortisieren muss, um diese rechtzeitig zu amortisieren
| 8   |  muss          |  Funktional     | Als user darf ich nicht länger als 15 Jahre oder bis zur Pensionierung haben bis max. 2/3 des Kaufpreises reduziert worden ist
| 9   |  muss          | Funktional      | Als user möchte ich mein alter eingeben können
| 10  |  kann          |  Funktional     | Als user möchte ich das Fehleingaben abgefangen werden
| 11  |  kann          |  Funktional     | Als user möchte ich am Ende eine Zusammenfassung erhalten





### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |   Programm gestartet          |  500   |   500            |
| 2.1  |   Programm gestartet          |   2    |    2             |
| 3.1  |            |        |                  |
| 4.1  |   Hypothek und Zinssatz eingegeben |        |                  |
| 5.1  |                               |        |                  |
| 6.1  |   Programm gestartet          |        |                  |
| 7.1  |   Eingabe der Dauer in Monaten| 24     | 1000             |
| 8.1  |   Eingabe Alter und Kaufpreis | 30 und 100 000| Geht      |
| 9.1  |   Programm gestartet          | 30     | 30               |
| 10.1 |   Programm gestartet          | fehleingabe | Bitte geben sie etwas gültiges ein |
| 11.1 |   Alle Eingaben getätigt      | Die Verlangten Angaben| Zahlen in einer Tabelle  |










### 1.4 Diagramme
[Hypothek.zip](https://github.com/robinsacher/Hypothekenrechner/files/9682772/Hypothek.zip)

 
## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |  08.12.2022     |           |   Eingabe           |    10min           |
| 2.A  |  08.12.2022      |           |   Eingabe           |     10min          |
| 3.A  |  08.12.2022      |           |   Eingabe           |     10min          |
| 4.A  |   08.12.2022     |           |    Berechnung          |     60min          |
| 5.A  |   08.12.2022     |           |     Eingabe         |     10min          |
| 6.A  |   08.12.2022    |           |     Berechnung         |     60min          |
| 7.A  |    08.12.2022    |           |     Berechnung         |      120min         |
| 8.A  |    08.12.2022    |           |     Berechnug         |       120min        |
| 9.A  |    08.12.2022    |           |     Eingabe         |       10min        |
| 10.A  |   08.12.2022     |           |    Sicherheitskontrolle          |      30min         |
| 11.A  |   08.12.2022     |           |    Ausgabe          |      10min         |




Total: 450min

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.


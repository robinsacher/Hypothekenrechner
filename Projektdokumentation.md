 # Projekt-Dokumentation

Sacher, Warnebold, Müller, Hitz

# Projektleiter

Sacher

# Kontaktdaten

Tel: 077 466 85 88
#
E-Mail: robin.sacher@students.ksba.ch


| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 29.09.2022      | 0.0.1   | Planung des Projektes, mit pap                               |
| 29.09.2022      | 0.0.2   | User Stories geschrieben                                     |
| 29.09.2022      | 0.0.3   | Testfälle geschrieben                                        |
| 30.09.2022      | 0.0.4   | E-Mail geschrieben an Auftraggeber                           |
| 30.09.2022      | 0.0.5   | Infos gesammelt und fertig geplant                           |

## 1 Informieren

### 1.1 Ihr Projekt

Ein Hypothekenrechner der die Laufzeit und kosten berechnen kann, sowie mieten und kaufen vergleichen.

### 1.4 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1   |  muss          |  Funktional     | Als user möchte ich den Betrag für die Hypothek eingeben können
|   2 |    muss        |  Funktional     | Als user möchte ich den aktuellen Zinssatz eingeben können
|  3  |    muss        |  Funktional     | Als user möchte ich die jährliche Zinsbelastung berechnen können
|  4  |   muss         |  Funktional     | Als user möchte ich den Hypothekbetrag und Zinsbetrag berechnen können
|  5  |  muss          |  Funktional     | Als user möchte ich die benötigten finanziellen Mitteln für den Kauf der Liegenschaft sowie der Hypothekarzinsbelastung angeben können
| 6   |   muss         | Funktional      | Als user möchte ich berechnen können nach wie vielen Jahren der kauf einer Liegenschaft günstiger im Vergleich zur Miete ist(Jährliche Mietkosten)
| 7   |  muss          |  Funktional     | Als user möchte ich berechnen können, welchen Betrag ich jährlich amortisieren muss, um diese rechtzeitig zu amortisieren
| 8   |  muss          |  Funktional     | Als user darf ich nicht länger als 15 Jahre oder bis zur Pensionierung haben bis max. 2/3 des Kaufpreises reduziert worden ist
| 9   |  muss          | Funktional      | Als user möchte ich mein alter eingeben können
| 10  |  kann          |  Funktional     | Als user möchte ich das Fehleingaben abgefangen werden
| 11  |  kann          |  Funktional     | Als user möchte ich am Ende eine Zusammenfassung erhalten
|12   |  kann          |  funktional     | Als user möchte ich, dass das Programm nicht gleich endet wenn man eine Funktion gemacht hat, damit man auch die anderen Funktionen machen kann
|13   |                |                 | 


### 1.5 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |   Programm gestartet          |  500   |   500                               |
| 2.1  |   Programm gestartet          |   2    |    2                                |
| 3.1  |   Zinssatz und Hypothekbetrag eingetragen  |    0.05 / 1000000    | 5000     |
| 4.1  |   Hypothek und Zinssatz eingegeben | 1000000 / 5000       | 100000 / 5000    |
| 5.1  |   Programm gestartet          |   12   |      12                             |
| 6.1  |   Betrag Haus / Betrag  Mieten  Jahre eingetragen| 1000000 / 1001000 | 10    |
| 7.1  |   Eingabe der Dauer in Monaten| 24     | 1000             |
| 8.1  |   Eingabe Alter und Kaufpreis | 30 und 100 000| Geht      |
| 9.1  |   Programm gestartet          | 30     | 30               |
| 10.1 |   Programm gestartet          | fehleingabe | Bitte geben sie etwas gültiges ein |
| 11.1 |   Alle Eingaben getätigt      | Die Verlangten Angaben| Zahlen in einer Tabelle  |


### 1.6 Diagramme
[Hypothek.zip](https://github.com/robinsacher/Hypothekenrechner/files/9682772/Hypothek.zip)

 
## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |  08.12.2022     |  Hitz         |   Eingabe           |    10min           |
| 2.A  |  08.12.2022      |   Sacher        |   Eingabe           |     10min          |
| 3.A  |  08.12.2022      |    Warnebold      |   Eingabe           |     10min          |
| 4.A  |   08.12.2022     |   Sacher        |    Berechnung          |     60min          |
| 5.A  |   08.12.2022     |    Hitz       |     Eingabe         |     10min          |
| 6.A  |   08.12.2022    |      Warnebold     |     Berechnung         |     60min          |
| 7.A  |    08.12.2022    |    Müller       |     Berechnung         |      120min         |
| 8.A  |    08.12.2022    |      Hitz     |     Berechnug         |       120min        |
| 9.A  |    08.12.2022    |      Sacher     |     Eingabe         |       10min        |
| 10.A  |   08.12.2022     |   Warnebold        |    Sicherheitskontrolle          |      30min         |
| 11.A  |   08.12.2022     |   Müller        |    Ausgabe          |      10min         |




Total: 450min


## 3 Entscheiden

Wir haben uns entschieden noch einige Sachen bei unserem Auftraggeber nachzufragen.

## 4 Realisieren

| AP-№  | Datum             | Zuständig | geplante Zeit | tatsächliche Zeit |
| ----  | -----             | --------- | ------------- | ----------------- |
| 1.A   |   27.10.2022      |     Sacher    |      90min        |  40min        |
| 2.A   |  08.12.2022       |   Sacher      |      10min        |  20min        |
| 3.A   |  08.12.2022       |    Warnebold  |      10min        |  15min        |
| 4.A   |   08.12.2022      |   Sacher      |      60min        |  70min        |
| 5.A   |   08.12.2022      |    Hitz       |      10min        |  20min        |
| 6.A   |   08.12.2022      |   Warnebold   |      60min        |  100min       |
| 7.A   |    08.12.2022     |    Müller     |      120min       |  130min       |
| 8.A   |    08.12.2022     |      Hitz     |      120min       |  100min       |
| 9.A   |    08.12.2022     |      Sacher   |      10min        |  10min        |
| 10.A  |   08.12.2022      |   Warnebold   |      30min        |  40min        |
| 11.A  |   08.12.2022      |   Müller      |      10min        |  20min        |



## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№  | Datum | Resultat | Tester |
| ----  | ----- | -------- | ------ |
| 1.1   |08.12.2022| Funktioniert |Warnebold, Hitz|
| 2.1   |08.12.2022| Funktioniert |Warnebold, Hitz|
| 3.1   |08.12.2022| Funktioniert |Warnebold, Hitz|
| 4.1   |08.12.2022| Funktioniert |Warnebold, Hitz|
| 5.1   |08.12.2022| Funktioniert |Warnebold, Hitz|
| 6.1   |08.12.2022| Funktioniert |Warnebold, Hitz|
| 7.1   |08.12.2022| Funktioniert |Warnebold, Hitz|
| 8.1   |08.12.2022| Funktioniert |Warnebold, Hitz|
| 9.1   |08.12.2022| Funktioniert |Warnebold, Hitz|
| 10.1  |08.12.2022| Funktioniert |Warnebold, Hitz|
| 11.1  |08.12.2022| Funktioniert |Warnebold, Hitz|


✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| II   |              |         |                   |                      |
| III  |              |         |                   |                      |
| IV   |              |         |                   |                      |
| V    |              |         |                   |                      |
| VI   |              |         |                   |                      |
| VII  |              |         |                   |                      |
| VIII |              |         |                   |                      |
| IX   |              |         |                   |                      |
| X    |              |         |                   |                      |



## 6 Auswerten

Das Projekt ist gut, es funktioniert fast alles nur noch 1 bis 2 kleine Logikfehler. Das Projekt ist gut gelaufen. 


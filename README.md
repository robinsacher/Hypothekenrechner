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


### 1.2 Fragen an den Auftraggeber
1. Was genau verstehen sie unter der jährlichen Zinsbelastung?
2. Was genau meinen sie damit, dass man den Zinssatz berechnen kann?
3. Was genau ist mit dem Teilauftrag der Armortisation gemeint?


### 1.3 Antworten zu den Fragen
1.
2.
3.
...


### 1.4 User Stories

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


## 3 Entscheiden

Wir haben uns entschieden noch einige Sachen bei unserem Auftraggeber nachzufragen.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |   27.10.2022    |     Sacher      |       90min        |          40min         |
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


# Projekt-Dokumentation

Gian-Marco Mileti

| Datum | Version  | Zusammenfassung                    |
| -------- | ------------ | --------------------------- |
| 16.08.23  |  1.0.0    |   Planung       |
| 23.08.23  |  1.0.0    |   Erweiterungen hinzugefügt         |
| 06.09.23  |  1.0.0    |   Programm ist fertig         |

### 1.1 Ihr Projekt

Ich habe einen RandomNumberGenerator im Lernatelier programmiert.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
|   ------- | ---------- | -------- | ---------------|
| 1 | Muss | Funktional| Als Benutzer möchte ich, dass eine Zahl vom computer gespeichert wird.|
| 2 | Muss | Funktional| Als Benutzer möchte ich eine Zahl raten können.|
| 3 |    Muss      |  Qualität    | Als Benutzer möchte ich sehen, wie viele Versuche ich gebraucht habe. |
| 4  |      Muss           |  Qualität   | Als Benutzer möchte ich wissen, ob meine Zahl höher oder niedriger ist als die getippte. |
| 5  |      kann           |  Qualität    |  Als Benutzer möchte ich einen Titel haben.       |
| 6  |      Muss           |  Funktional    |  Als Benutzer möchte ich, dass das Spiel Fehler abfängt.      |
| 7  |      kann          |  Qualität   |  Als Benutzer möchte ich noch einmal spielen können.  |

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1 | Zahl speichern  |  "Programm Start"| Keine |
| 2.1  |    Zahl raten          |   "Programm Start"      |      Dein Tipp:          |
| 3.1  |     Versuche anzeigen         |   80, 70, 55      |      3 versuche             |
| 4.1  |    Zahl niedriger oder höher          |   70      |      die Zahl ist niedriger/ die Zahl ist höher             |
| 5.1  |     Titel            |   "Programm starten"      |       RandomNumberGenerator            |
| 6.1  |     Fehler abfangen          |   kgj      |     Ungültige Eingabe              |
| 7.1  |    noch einmal spielen können          |  77     |    Möchtest Du noch einmal spielen? (ja/nein):                |

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ------------ | ------- | ----------------- |  ----- |
| 1 | 23.08.23      | Gian-Marco          | Zahl speichern | 60min |
| 2 | 23.08.23      | Gian-Marco          | Zahl raten können | 120min |
| 3 |  23.08.23     |    Gian-Marco       |   Versuche anzeigen lassen   |     30min          |
| 4 |  30.08.23     |    Gian-Marco       |   Zahl niedriger oder höher           |     90min          |
| 5 |  30.08.23     |    Gian-Marco       |   Titel           |     30min          |
| 6 |  06.08.23     |    Gian-Marco       |      Fehler abfangen        |      90min         |
| 7 |  06.08.23     |    Gian-Marco       |    noch einmal spielen können          |     60min          |

## 3 Entscheiden

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ------------ | ------- | ----------------- |   -------- |
| 1.A | 23.08.23        | Gian-Marco      | 45min |        45min         |
| 2.A | 23.08.23        | Gian-Marco     | 45min |        45min         |
| 3.A  |  23.08.23     |   Gian-Marco        |    30min        |        30min   |
| 4.A  |  30.08.23     |    Gian-Marco       |   90min           |      90min             |
| 5.A  |  30.09.23     |    Gian-Marco       |     30min          |     30min              |
| 6.A  |  06.09.23      |    Gian-Marco      |     90min          |     90min              |
| 7.A  |  06.09.23      |    Gian-Marco      |      60min         |     60min              |

### 5 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |  23.08.23     |  funktioniert        |  Gian-Marco      |
| 2.1  |  23.08.23     |  funktioniert        |  Gian-Marco      |
| 3.1  | 23.08.23      | funktioniert          | Gian-Marco        |
| 4.1  | 30.08.23      |  funktioniert         |  Gian-Marco       |
| 5.1  |  30.08.23     |  funktioniert         |  Gian-Marco       |
| 6.1  |  06.09.23     |  funktioniert         |  Gian-Marco       |
| 7.1  |  06.09.23     |  funktioniert         |  Gian-Marco       |

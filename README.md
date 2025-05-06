# Übersicht: Persistente Datenspeicherung in C#

## Grundlegende Konzepte

* **Persistenz:** Bezeichnet die Fähigkeit, Daten über die Laufzeit einer Anwendung hinaus zu speichern und bei Bedarf wieder abzurufen.
* **Datenbanken:** Strukturierte Systeme zur Verwaltung und Speicherung großer Datenmengen.
* **Dateisystem:** Hierarchische Struktur zur Organisation von Dateien und Ordnern auf einem Speichermedium.
* **Serialisierung:** Der Prozess, Objekte in ein Format zu konvertieren, das gespeichert oder übertragen werden kann, und umgekehrt (Deserialisierung).

## Wichtige Technologien und Ansätze in C#

### 1. Dateibasierte Speicherung

* **Textdateien (.txt, .csv, .json, .xml):** Einfache Möglichkeit, Daten in lesbarem Format zu speichern. Gut für Konfigurationen, Protokolle oder einfache Datensätze.
    * **Vorteile:** Einfach zu implementieren, leicht verständlich.
    * **Nachteile:** Nicht ideal für komplexe Datenstrukturen oder häufige Suchvorgänge, keine integrierte Datenintegritätsprüfung.
    * **C#-Klassen:** `System.IO.File`, `System.IO.StreamReader`, `System.IO.StreamWriter`, `System.Text.Json.JsonSerializer`, `System.Xml.Serialization.XmlSerializer`.

* **Binärdateien (.dat):** Speichern von Daten im Binärformat, oft effizienter für komplexe Objekte.
    * **Vorteile:** Kann speichereffizienter sein als Textformate.
    * **Nachteile:** Schwer lesbar und manuell zu bearbeiten, erfordert genaue Kenntnisse der Datenstruktur beim Lesen.
    * **C#-Klassen:** `System.IO.FileStream`, `System.IO.BinaryReader`, `System.IO.BinaryWriter`.

### 2. Datenbanken

* **Relationale Datenbanken (RDBMS):** Speichern Daten in Tabellen mit Beziehungen zueinander. Verwenden SQL (Structured Query Language) für die Datenmanipulation.
    * **SQL Server:** Leistungsstarke und weit verbreitete Datenbank von Microsoft.
        * **C#-Zugriff:** ADO.NET (`System.Data.SqlClient`), Entity Framework (EF Core, EF 6).
    * **PostgreSQL:** Open-Source, robust und erweiterbar.
        * **C#-Zugriff:** Npgsql (ADO.NET Provider), Entity Framework (mit Npgsql Provider).
    * **MySQL:** Beliebte Open-Source-Datenbank.
        * **C#-Zugriff:** MySqlConnector (ADO.NET Provider), Entity Framework (mit MySQL Provider).
    * **SQLite:** Eingebettete, dateibasierte Datenbank. Ideal für lokale Speicherung in Anwendungen.
        * **C#-Zugriff:** `System.Data.SQLite`, Entity Framework (mit SQLite Provider).

* **NoSQL-Datenbanken:** Nicht-relationale Datenbanken, die für verschiedene Datenmodelle optimiert sind (z.B. Dokumente, Schlüssel-Wert-Paare, Graphen).
    * **MongoDB:** Dokumentenorientierte Datenbank.
        * **C#-Zugriff:** MongoDB C# Driver.
    * **Redis:** In-Memory-Datenspeicher (kann auch persistent sein) für Caching und schnelle Datenzugriffe.
        * **C#-Zugriff:** StackExchange.Redis.
    * **Cassandra:** Hochverfügbare, verteilte NoSQL-Datenbank.
        * **C#-Zugriff:** Cassandra C# Driver.

### 3. Objektrelationale Mapper (ORM)

* **Entity Framework (EF Core, EF 6):** Ein ORM von Microsoft, das die Interaktion mit relationalen Datenbanken vereinfacht, indem es .NET-Objekte auf Datenbanktabellen abbildet.
    * **Vorteile:** Reduziert Boilerplate-Code für Datenbankzugriff, unterstützt LINQ-Abfragen, Change Tracking, Migrationen.
    * **Nachteile:** Kann bei komplexen Szenarien Lernaufwand erfordern, potenzieller Performance-Overhead bei unsachgemäßer Verwendung.

* **NHibernate:** Ein weiteres beliebtes Open-Source-ORM für .NET.
    * **Vorteile:** Sehr flexibel und konfigurierbar, unterstützt fortgeschrittene Mapping-Szenarien.
    * **Nachteile:** Steilere Lernkurve als Entity Framework.

### 4. Andere Persistenzmechanismen

* **Einstellungen und Konfigurationen:** `.config`-Dateien (veraltet), `appsettings.json` (modern), Benutzer- oder Anwendungseinstellungen (`Properties.Settings.Default`).
    * **C#-Klassen:** `System.Configuration.ConfigurationManager`, `Microsoft.Extensions.Configuration`.
* **Lokaler Speicher (Browser):** Für Webanwendungen mit Blazor kann der Browser-Speicher (`LocalStorage`, `SessionStorage`) für einfache persistente Daten genutzt werden.
    * **C#-Zugriff (Blazor):** Interop mit JavaScript (`IJSRuntime`).

## Auswahl des richtigen Ansatzes

Die Wahl der geeigneten Persistenzmethode hängt von verschiedenen Faktoren ab:

* Art und Struktur der Daten
* Datenmenge
* Anforderungen an Performance und Skalierbarkeit
* Transaktionssicherheit und Datenintegrität
* Komplexität der Abfragen
* Entwicklungsaufwand und Team-Expertise
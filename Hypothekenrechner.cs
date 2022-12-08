namespace Hypothekenrechner_fertig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool y = true;
            double monatslohn = 0;
            double jahresLohn = 0;
            double imobilie = 0;
            double eigenAnteil = 0;
            double hypothekBetrag = 0;
            string anpassen = null;
            double zinsSatz = 0;
            int laufzeit = 0;
            double amortisation = 0;
            double Jahreszinsbelastung = 0;
            string menuPunkt = null;
            double Mietbetrag = 0;
            double laufzeitwohnung = 0;
            double gesamtMiete = 0;
            double gesamtHaus = 0;
            string fortfahren = null;
            string beenden = null;
            string neueBerechnung = null;

            Console.WriteLine("Willkommen im Hypothekenrechner.");
            Console.WriteLine("");
            Console.WriteLine("Bitte geben sie in dem ganzen Programm nur Zahlen ein, da sonst Fehleingaben enstehen. Bitte verwenden sie auch keine Sonderzeichen, wie % rtc. ausser sie werden darum gebeten.");

            while (true)
            {

                try
                {
                    Console.WriteLine("_____________________________________________________________________________________________________________________");
                    Console.WriteLine("Geben sie bitte Ihren Monatslohn ein:");
                    double monatsLohn = Convert.ToDouble(Console.ReadLine());
                    jahresLohn = monatsLohn * 12;
                    Console.WriteLine("_____________________________________________________________________________________________________________________");

                    if (monatsLohn >= 10000000000000)
                    {
                        throw new Exception();
                    }

                    break;
                }

                catch
                {
                    Console.WriteLine("");
                    Console.WriteLine("Fehlerhafte Eingabe!");
                    Console.WriteLine("Sonderzeichen?");
                    Console.WriteLine("Geben sie bitte nur Zahlen ohne Buchstaben ein und Sonderzeichen ein.");
                    Console.WriteLine("_____________________________________________________________________________________________________________________");
                }

            }

            while (true)
            {

                try
                {
                    Console.WriteLine("Geben sie den Kaufpreis der Imobilie ein");
                    imobilie = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("_____________________________________________________________________________________________________________________");

                    Console.WriteLine("Geben sie den Eigenanteil des Kaufpreises von ihrem Haus/Wohnung ein:");
                    eigenAnteil = Convert.ToDouble(Console.ReadLine());

                    if (eigenAnteil < imobilie / 5)
                    {
                        throw new Exception();
                    }

                    break;
                }

                catch
                {
                    Console.WriteLine("");
                    Console.WriteLine("Fehlerhafte Eingabe!");
                    Console.WriteLine("Geben sie bitte nur Zahlen ohne Buchstaben ein");
                    Console.WriteLine("_____________________________________________________________________________________________________________________");
                }

            }

            while (true)
            {

                try
                {
                    Console.WriteLine("_____________________________________________________________________________________________________________________");
                    hypothekBetrag = imobilie - eigenAnteil;
                    Console.WriteLine("Der Betrag ihrer Hypothek:" + hypothekBetrag);
                    Console.WriteLine("Stimmt diese Hypothek, oder möchten sie die Hypothek anpassen? Wenn ja,^anpassen^ schreiben");
                    anpassen = Console.ReadLine();

                    if (hypothekBetrag >= imobilie)
                    {
                        throw new Exception();
                    }

                    if (anpassen == "anpassen")
                    {
                        Console.WriteLine("Geben sie den Betrag der Hypothek ein:");
                        hypothekBetrag = Convert.ToDouble(Console.ReadLine());
                    }

                    break;
                }

                catch
                {
                    Console.WriteLine("");
                    Console.WriteLine("Fehlerhafte Eingabe!");
                    Console.WriteLine("Geben sie bitte nur Zahlen ohne Buchstaben ein");
                    Console.WriteLine("_____________________________________________________________________________________________________________________");
                }
            }

            while (true)
            {

                try
                {
                    Console.WriteLine("_____________________________________________________________________________________________________________________");

                    Console.WriteLine("geben sie den aktuellen Zinssatz ein (Als Fliesskommazahl z.B. 0.05 etc. und nicht als Prozent):");
                    zinsSatz = Convert.ToDouble(Console.ReadLine());

                    if (zinsSatz > 5)
                    {
                        throw new Exception();
                    }
                    Console.WriteLine("_____________________________________________________________________________________________________________________");

                    break;

                }

                catch
                {
                    Console.WriteLine("");
                    Console.WriteLine("Fehlerhafte Eingabe!");
                    Console.WriteLine("Geben sie bitte nur Zahlen ohne Buchstaben ein");
                    Console.WriteLine("_____________________________________________________________________________________________________________________");
                }

            }

            while (true)
            {

                try
                {
                    Console.WriteLine("Geben sie die Laufzeit der Hypothek in Jahre ein:");
                    laufzeit = Convert.ToInt32(Console.ReadLine());

                    if (laufzeit == 0)
                    {
                        throw new Exception();
                    }

                    else if (laufzeit == 31)
                    {
                        throw new Exception();
                    }

                    break;
                }

                catch
                {
                    Console.WriteLine("");
                    Console.WriteLine("Fehlerhafte Eingabe!");
                    Console.WriteLine("Geben sie bitte nur Zahlen ohne Buchstaben ein");
                    Console.WriteLine("_____________________________________________________________________________________________________________________");
                }

            }

            while (true)
            {

                try
                {
                    Console.WriteLine("_____________________________________________________________________________________________________________________");

                    Console.WriteLine("Welche Funktion möchten sie verwenden?");
                    Console.WriteLine("_____________________________________________________________________________________________________________________");

                    Console.WriteLine("Funktion 1: Berechnen von jährlichen Zinsbelastung");
                    Console.WriteLine("Funktion 2: Was ist teurer, Ihr Haus oder ihre Wohnung?");
                    Console.WriteLine("Funktion 3: Amortisation");
                    Console.WriteLine("_____________________________________________________________________________________________________________________");

                    amortisation = (hypothekBetrag / 3) * 2;

                    while (y == true)
                    {
                        Console.WriteLine("_____________________________________________________________________________________________________________________");
                        Console.WriteLine("Für den Menüpunkt 1 die Zahl 1");
                        Console.WriteLine("Für den Menüpunkt 2 die Zahl 2");
                        Console.WriteLine("Für den Menüpunkt 3 die Zahl 3");
                        Console.WriteLine("_____________________________________________________________________________________________________________________");

                        Jahreszinsbelastung = hypothekBetrag * zinsSatz;
                        menuPunkt = Console.ReadLine();

                        while (true)
                        {

                            try
                            {

                                if (menuPunkt == "4")
                                {
                                    throw new Exception();
                                }

                                break;
                            }

                            catch
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Fehlerhafte Eingabe!");
                                Console.WriteLine("Geben sie bitte nur Zahlen ohne Buchstaben ein");
                                Console.WriteLine("_____________________________________________________________________________________________________________________");
                            }

                        }

                        if (menuPunkt == "1")
                        {
                            Console.WriteLine("Ihre Zinsbelastung pro jahr:" + Jahreszinsbelastung);
                            Console.WriteLine("Die Zinsen machen" + "" + 100 / jahresLohn * Jahreszinsbelastung + "% von ihrem Jahresgehalt aus");
                            Console.WriteLine("");
                            Console.WriteLine("Möchten sie eine weitere Funktion verwenden?");
                            Console.WriteLine("Wenn nicht geben sie ^nein^ ein.");
                            neueBerechnung = Console.ReadLine();

                            if (neueBerechnung == "nein")
                            {
                                break;
                            }

                        }

                        else if (menuPunkt == "2")
                        {
                            Console.WriteLine("geben sie die Miete ihrer Wohnung pro Monat ein:");
                            Mietbetrag = Convert.ToDouble(Console.ReadLine());

                            while (true)
                            {

                                try
                                {

                                    if (Mietbetrag > 200000000)
                                    {
                                        throw new Exception();
                                    }

                                    break;
                                }

                                catch
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Fehlerhafte Eingabe!");
                                    Console.WriteLine("Geben sie bitte nur Zahlen ohne Buchstaben ein");
                                    Console.WriteLine("_____________________________________________________________________________________________________________________");
                                }

                            }

                            Console.WriteLine("geben sie die Laufzeit ein,also wie viele Jahre sie dort wohnen wollen (in Jahren):");
                            laufzeitwohnung = Convert.ToDouble(Console.ReadLine());

                            while (true)
                            {

                                try
                                {

                                    if (laufzeitwohnung > 150)
                                    {
                                        throw new Exception();
                                    }

                                    break;
                                }

                                catch
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Fehlerhafte Eingabe!");
                                    Console.WriteLine("Geben sie bitte nur Zahlen ohne Buchstaben ein");
                                    Console.WriteLine("_____________________________________________________________________________________________________________________");
                                }

                            }

                            Console.WriteLine("Die kosten für die Miete der Wohnung beträgt:" + Mietbetrag * laufzeitwohnung * 12);
                            Console.WriteLine("Die kosten für einen Kauf eines Hauses beträgt:" + (Jahreszinsbelastung * laufzeit) + eigenAnteil);

                            gesamtMiete = Mietbetrag * laufzeitwohnung * 12;
                            gesamtHaus = Jahreszinsbelastung * laufzeit + amortisation;

                            if (gesamtMiete > gesamtHaus)
                            {
                                Console.WriteLine(" Ihre Miete ist um " + (gesamtMiete - gesamtHaus) + "grösser als der Kauf eines Hauses.");
                            }

                            else if (gesamtHaus > gesamtMiete)
                            {
                                Console.WriteLine(" Der Kauf des Hauses ist um" + (gesamtHaus - gesamtMiete) + "grösser als die Miete");
                            }

                        }

                        else if (menuPunkt == "3")
                        {
                            Console.WriteLine("sie müssen bis sie pensioniert sind oder während 15 Jahren diesen Betrag armortisieren:" + amortisation);
                        }

                    }

                    break;
                }

                catch
                {
                    Console.WriteLine("");
                    Console.WriteLine("Fehlerhafte Eingabe!");
                    Console.WriteLine("Geben sie bitte nur Zahlen ohne Buchstaben ein");
                    Console.WriteLine("_____________________________________________________________________________________________________________________");
                }

            }

            while (true)
            {

                try
                {
                    Console.WriteLine("Wollen sie das Programm beenden?");
                    Console.WriteLine("Wenn ja, dann schreiben sie ^ja^.");
                    Console.WriteLine("Wenn nein, dann schreiben sie ^nein^.");

                    beenden = Console.ReadLine();

                    if (beenden == "ja")
                    {
                        break;
                    }

                    if (beenden == "nein")
                    {

                    }

                    if (beenden == "fdgs")
                    {
                        throw new Exception();
                    }

                    if (beenden == "1")
                    {
                        throw new Exception();
                    }

                }

                catch
                {
                    Console.WriteLine("");
                    Console.WriteLine("Fehlerhafte Eingabe!");
                    Console.WriteLine("Geben sie bitte nur Zahlen ohne Buchstaben und Sonderzeichen ein");
                    Console.WriteLine("");
                }

            }

            Environment.Exit(0);

        }

    }

}
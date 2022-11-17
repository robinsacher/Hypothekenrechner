using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace Test_hypothekenrechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                bool y = true;

                Console.WriteLine("Willkommen im Hypothekenrechner");
                Console.WriteLine("_____________________________________________________________________________________________________________________");

                Console.WriteLine("Geben sie bitte Ihren Monatslohn ein:");
                double monatsLohn = Convert.ToDouble(Console.ReadLine());
                double jahresLohn = monatsLohn * 12;
                Console.WriteLine("___________________________________________________________ __________________________________________________________");

                if (monatsLohn >= 1000000)
                {
                    throw new Exception();
                }

                Console.WriteLine("Geben sie den Kaufpreis der Imobilie ein");
                double imobilie = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("_____________________________________________________________________________________________________________________");

                Console.WriteLine("Geben sie den Eigenanteil des Kaufpreises von ihrem Haus/Wohnung ein:");
                double eigenAnteil = Convert.ToDouble(Console.ReadLine());
                if (eigenAnteil < imobilie / 5)
                {
                    throw new Exception();
                }
                Console.WriteLine("_____________________________________________________________________________________________________________________");

                double hypothekBetrag = imobilie - eigenAnteil;
                Console.WriteLine("Der Betrag ihrer Hypothek:" + hypothekBetrag);
                Console.WriteLine("Stimmt diese Hypothek, oder möchten sie die Hypothek anpassen? Wenn ja,^anpassen^ schreiben");
                string anpassen = Convert.ToString(Console.ReadLine());
                if(hypothekBetrag >= imobilie)
                {
                    throw new Exception();
                }

                if (anpassen == "anpassen")
                {
                    hypothekBetrag = Convert.ToDouble(Console.ReadLine());
                }

                Console.WriteLine("_____________________________________________________________________________________________________________________");

                Console.WriteLine("geben sie den aktuellen Zinssatz ein (Als Fliesskommazahl z.B. 0.05 etc. und nicht als Prozent):");
                double zinsSatz = Convert.ToDouble(Console.ReadLine());
                if (zinsSatz > 5)
                {
                    throw new Exception();
                }
                Console.WriteLine("_____________________________________________________________________________________________________________________");

                Console.WriteLine("Geben sie die Laufzeit der Hypothek in Jahre ein:");
                int laufzeit = Convert.ToInt32(Console.ReadLine());
                if (laufzeit == 0)
                {
                    throw new Exception();  
                }   

                else if (laufzeit == 31)
                {
                    throw new Exception();
                }
                Console.WriteLine("_____________________________________________________________________________________________________________________");

                Console.WriteLine("Welche Funktion möchten sie verwenden?");
                Console.WriteLine("_____________________________________________________________________________________________________________________");

                Console.WriteLine("Funktion 1: Berechnen von jährlichen Zinsbelastung");
                Console.WriteLine("Funktion 2: Was ist teurer, Ihr Haus oder ihre Wohnung?");
                Console.WriteLine("Funktion 3: Amortisation");
                Console.WriteLine("_____________________________________________________________________________________________________________________");

                double amortisation = (hypothekBetrag / 3) * 2;

                while (y == true)
                {

                    Console.WriteLine("_____________________________________________________________________________________________________________________");
                    Console.WriteLine("Für den Menüpunkt 1 die Zahl 1");
                    Console.WriteLine("Für den Menüpunkt 2 die Zahl 2");
                    Console.WriteLine("Für den Menüpunkt 3 die Zahl 3");
                    Console.WriteLine("_____________________________________________________________________________________________________________________");

                    double Jahreszinsbelastung = hypothekBetrag * zinsSatz;
                    string menuPunkt = Console.ReadLine();
                    if (menuPunkt == "4")
                    {
                        throw new Exception();
                    }

                    if (menuPunkt == "1")
                    {
                        Console.WriteLine("Ihre Zinsbelastung pro jahr:" + Jahreszinsbelastung);
                        Console.WriteLine("Die Zinsen machen" + "" + 100 / jahresLohn * Jahreszinsbelastung + "% von ihrem Jahresgehalt aus");
                    }

                    else if (menuPunkt == "2")
                    {

                        Console.WriteLine("geben sie die Miete ihrer Wohnung pro Monat ein:");
                        double Mietbetrag = Convert.ToDouble(Console.ReadLine());
                        if (Mietbetrag > 20000)
                        {
                            throw new Exception();
                        }

                        Console.WriteLine("geben sie die Laufzeit ein,also wie vieleJahre sie dort wohnen wollen (in Jahren):");
                        double laufzeitwohnung = Convert.ToDouble(Console.ReadLine());
                        if (laufzeitwohnung > 120)
                        {
                            throw new Exception();
                        }

                        Console.WriteLine("Die kosten für die Miete der Wohnung beträgt:" + Mietbetrag * laufzeitwohnung * 12);
                        Console.WriteLine("Die kosten für einen Kauf eines Hauses beträgt:" + Jahreszinsbelastung * laufzeit + eigenAnteil);

                        double gesamtMiete = Mietbetrag * laufzeitwohnung * 12;
                        double gesamtHaus = Jahreszinsbelastung * laufzeit + amortisation;

                        if (gesamtMiete > gesamtHaus)
                        {
                            Console.WriteLine(" Ihre Miete ist um " + (gesamtMiete - gesamtHaus) + "grösser als der Kauf eines Hauses.");
                        }

                        else if (gesamtHaus < gesamtMiete)
                        {
                            Console.WriteLine(" Der Kauf des Hauses ist um" + (gesamtHaus - gesamtMiete) + "grösser als die Miete");
                        }

                    }

                    else if (menuPunkt == "3")
                    {
                        Console.WriteLine("sie müssen bis sie pensioniert sind oder während 15 Jahren diesen Betrag armortisieren:" + amortisation);
                    }

                }

            }
            
            catch
            {
                
                Console.WriteLine("Fehlerhafte Eingabe!");
                Console.WriteLine("Geben sie bitte nur Zahlen ohne Buchstaben ein");
                Console.WriteLine("_____________________________________________________________________________________________________________________");
                Console.WriteLine("Wollen sie das Programm beenden, oder dort fortfahren wo sie aufgehört haben?");
                Console.WriteLine("_____________________________________________________________________________________________________________________");
                Console.WriteLine("Wenn Neustart tippen sie ^ja^");
                Console.WriteLine("_____________________________________________________________________________________________________________________");
                Console.WriteLine("Wenn fortfahren tippen sie ^nein^");

                string fortfahren = Console.ReadLine();
                if (fortfahren != "ja")
                {
                    throw new Exception();
                }

                if (fortfahren != "nein")
                {
                    throw new Exception();
                } 
                    

                if (fortfahren == "nein")
                {
                    Console.WriteLine("An dieser Funktion wird noch gearbeitet"); //Noch nicht fertig
                } 

                else if(fortfahren == "ja")
                {
                    Console.WriteLine("Sie haben das Programm Beendet");
                }

            }

        }

    } 

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            int kraj_przesylki, rodzaj_przesylki, stala = 5;
            string a = "przesyłka krajowa ", b = "przesyłka europejska ", c = "niestandardowa ", imie, adres;
            ConsoleKeyInfo odp;
            double x, y, z, cena;
                
            Console.WriteLine("Witamy w ASN - Automatycznym Systemie Nadawania");

            do
            {
                Console.WriteLine("\nDokąd chcesz nadać przesyłkę?");
                Console.WriteLine("1 - przesyłka krajowa\n2 - przesyłka europejska\n3 - pozostałe kraje");
                kraj_przesylki = int.Parse(Console.ReadLine());
                if (kraj_przesylki != 1 & kraj_przesylki != 2 & kraj_przesylki != 3)
                    do
                    {
                        Console.WriteLine("Podałeś nieprawidłowy kod. Wybierz 1,2 lub 3");
                        kraj_przesylki = int.Parse(Console.ReadLine());
                    } while (kraj_przesylki != 1 & kraj_przesylki != 2 & kraj_przesylki != 3);

                Console.WriteLine("Podaj rodzaj przesyłki:");
                Console.WriteLine("1 - list zwykły\n2 - list polecony\n3 - paczka");
                rodzaj_przesylki = int.Parse(Console.ReadLine());
                if (rodzaj_przesylki != 1 & rodzaj_przesylki != 2 & rodzaj_przesylki != 3)
                    do
                    {
                        Console.WriteLine("Podałeś nieprawidłowy kod. Wybierz 1,2 lub 3");
                        rodzaj_przesylki = int.Parse(Console.ReadLine());
                    } while (rodzaj_przesylki != 1 & rodzaj_przesylki != 2 & rodzaj_przesylki != 3);

                if (kraj_przesylki == 1)
                {
                    a = "przesyłka krajowa";
                    //m1 = 5;
                }
                else if (kraj_przesylki == 2)
                    a = "przesyłka europejska";
                else if (kraj_przesylki == 3)
                    a = "przesyłka niestandardowa";

                if (rodzaj_przesylki == 1)
                    b = "list zwykły";
                else if (rodzaj_przesylki == 2)
                    b = "list polecony";
                else if (rodzaj_przesylki == 3)
                    b = "paczka";

                Console.WriteLine("Twój wybór to " + a + " - " + b + "\nCzy chcesz zmienić swój wybór T\\N ? ");
                odp = Console.ReadKey(true);
                if ((odp.Key != ConsoleKey.T) && (odp.Key != ConsoleKey.N))
                    do
                    {
                        Console.WriteLine("Wściśnij prawidłowy przycisk (T\\N)");
                        odp = Console.ReadKey(true);
                    } while ((odp.Key != ConsoleKey.T) && (odp.Key != ConsoleKey.N));
                if (odp.Key == ConsoleKey.T)
                    Console.Clear();

            } while (odp.Key == ConsoleKey.T);
            

            switch (rodzaj_przesylki)
            {

                case 1:

                    do
                    {

                        Console.WriteLine("\nPodaj dane odbiorcy...\nImię i Nazwisko:");
                        imie = Console.ReadLine();
                        Console.WriteLine("Podaj adres...\nUlica, nr domu, miasto, kod pocztowy:");
                        adres = Console.ReadLine();
                        Console.WriteLine("Czy podane dane są prawidłowe?(T\\N)");
                        Console.WriteLine(imie + "\n" + adres);
                        odp = Console.ReadKey(true);

                        if ((odp.Key != ConsoleKey.T) && (odp.Key != ConsoleKey.N))
                            do
                            {
                                Console.WriteLine("Wściśnij prawidłowy przycisk (T\\N)");
                                odp = Console.ReadKey(true);
                            } while ((odp.Key != ConsoleKey.T) && (odp.Key != ConsoleKey.N));
                        if (odp.Key == ConsoleKey.N)
                            Console.Clear();
                        if (odp.Key == ConsoleKey.N)
                            Console.WriteLine("Twój wybór to " + a + " - " + b);
                    } while (odp.Key == ConsoleKey.N);


                    cena = stala * kraj_przesylki * rodzaj_przesylki;
                    Console.WriteLine("Cena Twojej przesyłki to " + cena + " zł");

                    break;

                case 2:

                    do
                    {
                        
                        Console.WriteLine("\nPodaj dane odbiorcy...\nImię i Nazwisko:");
                        imie = Console.ReadLine();
                        Console.WriteLine("Podaj adres...\nUlica, nr domu, miasto, kod pocztowy:");
                        adres = Console.ReadLine();
                        Console.WriteLine("\nCzy podane dane są prawidłowe?(T\\N)");
                        Console.WriteLine(imie + "\n" + adres);
                        odp = Console.ReadKey(true);

                        if ((odp.Key != ConsoleKey.T) && (odp.Key != ConsoleKey.N))
                            do
                            {
                                Console.WriteLine("Wściśnij prawidłowy przycisk (T\\N)");
                                odp = Console.ReadKey(true);
                            } while ((odp.Key != ConsoleKey.T) && (odp.Key != ConsoleKey.N));
                        if (odp.Key == ConsoleKey.N)
                            Console.Clear();
                        if (odp.Key == ConsoleKey.N)
                            Console.WriteLine("\nTwój wybór to " + a + " - " + b);
                    } while (odp.Key == ConsoleKey.N);

                    
                    cena = stala * kraj_przesylki * rodzaj_przesylki;
                    Console.WriteLine("Cena Twojej przesyłki to " + cena + " zł");

                    break;
                ////////////////////////////////////////////////////////////////////////////
                case 3:
                    Console.WriteLine("\nPodaj wymiary paczki");
                    Console.WriteLine("Długość:");
                    x = double.Parse(Console.ReadLine());
                    Console.WriteLine("Szerokość:");
                    y = double.Parse(Console.ReadLine());
                    Console.WriteLine("Wysokość:");
                    z = double.Parse(Console.ReadLine());

                    double suma = x + y + z;

                    double mnoznik_ceny = 1;
                    if (suma <= 60)
                        mnoznik_ceny = 1;
                    else if (suma > 60 && suma <= 120)
                        mnoznik_ceny = 1.5;
                    else if (suma > 120)
                        mnoznik_ceny = 2;

                    if (((x>120 || (y>60 && z>60)) || (y>120 || (z>60 && x>60)) || (z>120 || (x>60 && y>60))))
                       
                    {
                        Console.WriteLine("Twoja paczka jest za duża! -> Maksymalny rozmiar paczki do nadania przez ASN to 120cm x 60cm x 60cm\nProsimy nadać paczkę w okienku PACZKI GABARYTOWE");
                        Console.WriteLine("Naciśnij dowolny klawisz aby zakończyć");
                        Console.ReadKey();
                        System.Diagnostics.Process.GetCurrentProcess().Kill();
                    }
                        
                        Console.WriteLine("Ustaw paczkę na wadze");
                        
                        string odpowiedz;
                        do
                        {
                            Console.WriteLine("Potwierdź umieszczenie paczki na wadze.\nInformujemy że paczek powyżej 15 kg NIE MOŻNA nadać automatycznie.");
                            Console.WriteLine("Paczka umieszczona? T/N");
                            odpowiedz = Console.ReadLine();
                        } while (odpowiedz == "n");

                        Console.WriteLine("Proszę czekać, trwa ważenie...");
                        Random ww = new Random();
                        int waga = ww.Next(0, 30);
                        
                        if (waga > 15)
                        {
                            Console.WriteLine("Twoja paczka waży " + waga + " kg ...i jest za ciężka!\nProsimy nadać paczkę w okienku PACZKI GABARYTOWE");
                            Console.WriteLine("Naciśnij dowolny klawisz aby zakończyć");
                            Console.ReadKey();
                            System.Diagnostics.Process.GetCurrentProcess().Kill();
                        }
                        else
                        {
                        Console.WriteLine("Twoja paczka waży " + waga + " kg");
                            cena = waga * kraj_przesylki * rodzaj_przesylki * mnoznik_ceny;
                            Console.WriteLine("Cena Twojej przesyłki to " + cena + " zł");
                        }

                        break;

                }
                string koniec;
                Console.WriteLine("Nacisnij T aby zatwierdzić zlecenie, inny aby anulować");
                koniec = Console.ReadLine();
                if (koniec == "t")
                    Console.WriteLine("Dziękujęmy za skorzystanie z ASN. Trwa drukowanie listu przewozowego...\nWydrukowany list przewozowy umieść na przesyłce.\nNaciśnij dowolny klawisz aby zakończyc");
                else
                {
                    Console.WriteLine("Anulowano. Naciśnij dowolny klawisz aby zakończyć");
                }
                Console.ReadKey();
                
        }
    }
}

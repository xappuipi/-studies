using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Projekt1;

namespace Projekt1
{
    internal class Projekt1
    {
        public static void Main(string[] args)
        {
            //var tmKI = new tmKalkulatorIndywidualny();
            //Console.WriteLine(tmKI.tmSGeometryczna());

            //Deklaracje zmiennych
            ConsoleKeyInfo wybranaFunkcjonalnosc;   



            //wypisanie etryki projektu
            Console.WriteLine("\n\n\n\t\t\tProjekt Nr 1 jest kalkulatorem umozliwiajacym "+
                "oblicznie wybranych wielkosci matematycznych");

            //zapisanie wielokrotnego powtarzania wyboru kalkulatora
            do
            {
                //wypisanie tytulu karty menu
                Console.WriteLine("\n\n\n\t\tMENU KALKULATORA");
                //wypisanie pozycji w karcie menu
                Console.WriteLine("\n\n\t\tA: Kalkulaor Laboratoryjny");
                Console.WriteLine("\n\n\t\tB: Kalkulaor Indywidualny");
                Console.WriteLine("\n\n\t\tX: Zakoncz");

                //podpowiedz dla uzytkownika
                Console.Write("\n\n\t\tNacisniecie dowzwolonego klawisza (A, B lub X)" +
                                    " wybierz wymagana funkcjonalnosc");
                //wczytanie kodu nacisnietego klawisza
                wybranaFunkcjonalnosc = Console.ReadKey();

                //rozpoznanie kodu nacisnietego klawisza

                if (wybranaFunkcjonalnosc.Key == ConsoleKey.A)
                {
                    //wywolanie metody ktora obsluguje ten kalkulator
                    KalkulatorLaboraturyjny();

                }

                else if( wybranaFunkcjonalnosc.Key == ConsoleKey.B)
                {
                    KalkulatorIndywidualny();
                }

                else if (wybranaFunkcjonalnosc.Key != ConsoleKey.X)
                {//jest blad to go sygnalizujemy
                    Console.WriteLine("\n\n\t\tERROR: nacisnales niedozwolony klawisz");
                    //chwilowe zatrzymanie programu
                    Console.WriteLine("\n\n\tDla zakonczenia dzialania programu nacisnij dowolny klawisz . . . ");
                    Console.ReadKey(true);
                }
                //wyczyszczenie okna konsoli
                Console.Clear();


            } while(wybranaFunkcjonalnosc.Key != ConsoleKey.X);
            //zakonczenie programu
            Console.WriteLine("\n\n\n\t\tAutor programu: Tymon Mickiewicz, numer albumu: 71500");

            //wypisanie daty i godziny wykonania programu
            Console.WriteLine("\n\t\tProgram zostal wykonany: {0}", DateTime.Now);

            //chwilowe zatrzymanie dzialania programu
            Console.WriteLine("\n\n\tDla zakonczenia dzialania programu nacisnij dowolny klawisz . . . ");

            //oczekiwanie na naciesniecie klawisza
            Console.ReadKey(true);
        }
        #region Deklaracja metod kalkulaora laboratoryjnego
        static void KalkulatorLaboraturyjny()
        {
            //wyczyszczenie okna konsoli
            Console.Clear();

            //wypisanie potwierdzenia o wybraniu kalkulatora
            Console.WriteLine("\n\n\t\tKalkulator Laboratoryjny");
            //Console.WriteLine("\n\n\n\n\tPrzepraszam ale jestem w trakcie realizacji projektu");

            ConsoleKeyInfo wybranaFunkcjonalnosc;

            //wypisanie etryki projektu
            Console.WriteLine("\n\n\n\t\t\tProjekt Nr 1 jest kalkulatorem umozliwiajacym " +
                "oblicznie wybranych wielkosci matematycznych");

            //zapisanie wielokrotnego powtarzania wyboru kalkulatora
            do
            {
                //wypisanie tytulu karty menu
                Console.WriteLine("\n\n\n\t\tMENU KALKULATORA LABORATURYJNEGO");
                //wypisanie pozycji w karcie menu
                Console.WriteLine("\n\t\tA: Obliczanie sredniej arytmetycznej wyrazow ciagu liczbowego");
                Console.WriteLine("\n\t\tB: Obliczanie wartosci wielomianu n-tego stopnia");
                Console.WriteLine("\n\t\tC: Konwersja znakowego zapisu liczby na jej wartosc");
                Console.WriteLine("\n\t\tD: Obliczanie wartosci symbolu newtona");
                Console.WriteLine("\n\n\t\tX: Wyjscie z kalkulatora");

                //podpowiedz dla uzytkownika
                Console.Write("\n\n\t\tNacisniecie dowzwolonego klawisza (A, B, C, D lub X)" +
                                    " wybierz wymagana funkcjonalnosc");
                //wczytanie kodu nacisnietego klawisza
                wybranaFunkcjonalnosc = Console.ReadKey();


                //wyczyszczenie okna konsoli
                Console.Clear();
                //rozpoznanie kodu nacisnietego klawisza

                switch (wybranaFunkcjonalnosc.Key)
                {

                    case ConsoleKey.A:
                        //wypisanie potwierdzenia wybranej funkcjonalnosci
                        Console.WriteLine("\n\n\t\tWybrana zostala funkcjonalnosc: " +
                            "A: Obliczanie sredniej arytmetycznej wyrazow ciagu liczbowego");

                        //wywolanie funkcji do obliczania sredniej arytmetycznej
                        /*Zalozenia projektowe:
                         * 1) Dane wyjsciow, kolejnosc ich wczytywania i ich typy danych
                         * n - licznosc wyrazow ciagu liczbowego, typu ushort (liczby naturalne >= 0)
                         * a1, a2, ... , an - wyrazy ciagu liczbowego, typu float
                         * 2) warunek wejsciuwy nakladany na dane wejsciowe N> 0
                         * 3) wynik obliczben wedlug znanego wzoru, typu
                         */

                        //deklaracja zmiennych dla przechowania wcytanych danych wejsciowych
                        ushort n;
                        float a;
                        //deklaracje zmiennych dla posrednich i koncowych wynikow obliczen
                        float suma, sredniaArytmetyczna;
                        //wczytanie licznosci wyrazow ciagu liczbowego
                        do
                        {
                            //wypisanie zaproszenia dla podania licznosci 'n' wyrazow ciagu liczbowego
                            n = wczytajLiczbeNaturalna("licznosc wyrazow ciagu liczbowego");

                            //sprawdzanie warunku wejsciowego
                            if (n == 0)
                                //jest blad
                                Console.WriteLine("\n\n\t\tERROR: podana wartosc licznosci ciagu liczbowego" +
                                    "nie spelnia warnku wejciowego (n > 0)");

                        } while (n == 0); //warunek n <= 0 jest z nadmiarem
                        //obliczanie sumy wyrazow ciagu liczbowego
                        //ustalenie poczatkowego stanu obliczen
                        suma = 0.0F;
                        //wyznaczenie sumy wyrazow wedlug zaleznosci iteracyjnych
                        for(int i = 1; i <= n; i++)
                        {
                            //wczytanie wartosci i-tego wyrazu
                            wczytajLiczbeRzeczywista($"Podaj wartosc {i}-ego wyrazu ciagu liczbowego: ", out a);

                            //iteracyjne sumowanie
                            suma += a;
                        }
                        //tutaj suma jest OK
                        //obliczanie sredniej arytmetyczniej
                        sredniaArytmetyczna = suma / n;
                        //wypisanie wyniku obliczen w formacie fixed point
                        Console.WriteLine($"\n\n\t\tWYNIKI OBLICZE: obliczona srednia arytmetyczna {n} wczytanych wyrazow ciagu liczbowego" +
                            $"jest rowna: {sredniaArytmetyczna,6:F2}");
                        //wypisanie wyniku obliczen w formacie wykladniczym
                        Console.WriteLine($"\n\n\t\tWYNIKI OBLICZE: obliczona srednia arytmetyczna {n} wczytanych wyrazow ciagu liczbowego" +
                            $"jest rowna: {sredniaArytmetyczna,6:E2}");
                        //wypisanie wyniku obliczen w formacie ustalanym automatycznie, najlepszym dla wypisywanej wartosci
                        Console.WriteLine($"\n\n\t\tWYNIKI OBLICZE: obliczona srednia arytmetyczna {n} wczytanych wyrazow ciagu liczbowego" +
                            $"jest rowna: {sredniaArytmetyczna,6:G}");


                        break;

                    case ConsoleKey.B:
                        //wypisanie potwierdzenia wybranej funkcjonalnosci
                        Console.WriteLine("\n\n\t\tWybrana zostala funkcjonalnosc: " +
                            "B: Obliczanie wartosci wielomianu n-tego stopnia");

                        /*zalozenia projektowe:
                         * 1. dane wejsciowe: (ich kolejnosc wczytywania i typ danych)
                         *  - n stopien wielomianu: liczba natualna (typ ushort)
                         *  - x wartosc zmiennej niezaleznej: liczba rzeczywista (typ float)
                         *  - a0 a1 a2 . . . an - wspolczynnii wielomianu: liczby rzeczywiste (typ float)
                         * 2. waruek wejsciowy: n >= 0
                         * 3. wynik obliczen: w(x) = wartosc (typ float)  
                         */

                        //deklaracje zmiennych dla przechowania danych wejsciowych
                        //ushort n;

                        float x; //zmienna niezalezna
                        //float a; //wspolczynnik wielomianu
                        float wx; //watosc wielomianu

                        //wczytanie danych wejsciowych
                        n = wczytajLiczbeNaturalna("stopien wielomianu");
                        //wczytanie wartosci zmiennej niezaleznej x
                        wczytajLiczbeRzeczywista("wartosc zmiennej niezaleznej x", out x);

                        //iteracyjne obliczanie wartosci wielomianu wg 'schematu hornera'
                        wx = 0.0F; //poczatkowy stan obliczen
                        string textZaproszenia; //dla zredagowania zaproszenia do poadania a
                        //iteracyjne obliczanie wartosci wielomianu
                        for (int i = 0; i <= n; i++)
                        {
                            textZaproszenia = string.Format("wartosc {0}-tego wspolczynnika wielomianu", i);
                            //wczytanie wartosci i-tego wspolczynnika
                            wczytajLiczbeRzeczywista($"wartosc {i}-tego wspolczynnika wielomianu", out a); //uzywanie formated sring za pomoca znaku $
                                                                                                           //poniewaz jest bardziej czytelne
                                                                                                           //i nie zajmuje miajsca w pamieci na niepotrzebne zmienne
                            //iteracyje obliczanie wielomianu
                            wx = wx * x + a;
                        }
                        //wypisywanie wyniku obliczen
                        //w formacie fixed-point 
                        Console.WriteLine($"\n\n\t\tWyniki obliczen: obliczona wartosc wielomianu" +
                            $"{n}-tego stopnia dla odanych wartosci \n\t\t\twspolczynnikow" +
                            $"jest rowna W(x) = {wx, 6:F3}");

                        //w formacie wykladniczym
                        Console.WriteLine($"\n\n\t\tWyniki obliczen: obliczona wartosc wielomianu" +
                            $"{n}-tego stopnia dla odanych wartosci \n\t\t\twspolczynnikow" +
                            $"jest rowna W(x) = {wx,6:E2}");

                        //w formacie domyslnym
                        Console.WriteLine($"\n\n\t\tWyniki obliczen: obliczona wartosc wielomianu" +
                            $"{n}-tego stopnia dla odanych wartosci \n\t\t\twspolczynnikow" +
                            $"jest rowna W(x) = {wx,6:G}");

                        break;

                    case ConsoleKey.C:
                        //wypisanie potwierdzenia wybranej funkcjonalnosci
                        Console.WriteLine("\n\n\t\tWybrana zostala funkcjonalnosc: " +
                            "C: Konwersja znakowego zapisu liczby na jej wartosc");

                        //123 = 10^2 * 1 + 10^1 * 2 + 10^0 * 3

                        //deklaracje zmiennych
                        ushort wczytanaWartoscLiczby;

                        //znakowe wczytanie liczby dziesietnej i jej konwersja na wartosc
                        znakoweWczytanieLiczbyNaturalnej("liczba naturalna (od 0 do 65535)", out wczytanaWartoscLiczby);

                        //deklaracja pomocnicza
                        string znakowyZapisLiczbyPoKonwersji;
                        //konwersja liczby naturalnej na zapis znakowy
                        KonwersjaLiczbyNaturalnejNaZapisZnakowy(wczytanaWartoscLiczby, out znakowyZapisLiczbyPoKonwersji);

                        //wypisanie wyniku konwersji
                        Console.WriteLine($"\n\n\t\tWynik Konwersji: wczytana liczba naturalna: {wczytanaWartoscLiczby} jest rownowazna" +
                            $"liczbie w systemie dwojkowym: {znakowyZapisLiczbyPoKonwersji}");


                        break;

                    case ConsoleKey.D:
                        //wypisanie potwierdzenia wybranej funkcjonalnosci
                        Console.WriteLine("\n\n\t\tWybrana zostala funkcjonalnosc: " +
                            "A: Obliczanie wartosci symbolu newtona");

                        obliczanieSymboluNewtona();

                        break;

                    case ConsoleKey.X:
                        //wypisanie potwierdzenia wybranej funkcjonalnosci
                        Console.WriteLine("\n\n\t\tWybrana zostala funkcjonalnosc: " +
                            "X: Wyjscie z kalkulatora");

                        break;

                    default:
                        Console.WriteLine("\n\n\n\tERROR nacisnales niedozwolony przycisk");
                        break;

                }
                //chwilowe zatrzymanie programu
                Console.WriteLine("\n\n\tDla zakonczenia dzialania programu nacisnij dowolny klawisz . . . ");

                //oczekiwanie na naciesniecie klawisza
                Console.ReadKey(true);

                //wyczyszczenie okna konsoli
                Console.Clear();


            } while (wybranaFunkcjonalnosc.Key != ConsoleKey.X);

            //chwilowe zatrzymanie dzialania programu
            Console.WriteLine("\n\n\tDla kontynuacji dzialania programu nacisnij dowolny klawisz . . . ");

            //oczekiwanie na naciesniecie klawisza
            Console.ReadKey(true);
        }


        //deklaracja nowego regionu
        #region Deklaracje matod na poczet kalkulatora leboratoryjnego

        static ushort wczytajLiczbeNaturalna(string textZaproszenia)
        {
            //deklaracja zmiennej
            ushort n;
            //wypisanie zaproszenia dla podania liczby naturalnej
            Console.Write("\n\t\tPodaj "+textZaproszenia+": ");
            //wczytanie wartosci liczby naturalnej
            while(!ushort.TryParse(Console.ReadLine(), out n))
            {// byl blad to go wypisujemy
                Console.WriteLine("\n\n\t\tERROR: w podanej wartosci wystapil niedozwolony znak");
                //ponowne zaproszenie do podania wartosci
                Console.WriteLine("\n\n\tPodaj ponownie" + textZaproszenia + ": ");
            }
            //tutaj n jest OK
            //zwrotne przekazanie wczytanej liczby naturalnej
            return n;
        }

        static void wczytajLiczbeRzeczywista(string textZaproszenia, out float wczytanaLiczba) 
        {
            //wypisanie zaproszenia
            Console.Write("\n\t\tPodaj " + textZaproszenia + ": ");
            //wczytanie liczby rzeczywistej
            while(!float.TryParse(Console.ReadLine(), out wczytanaLiczba))
            {
                Console.WriteLine("\n\n\t\tERROR: w zapisie podanej liczby rzeczywistej wystapil niedozwolony znak");

                //wypisanie ponownego zaproszenia
                Console.Write("\n\t\tPodaj ponownie " + textZaproszenia + ": ");

            }
        }

        //metody instrukcyjne i funkcyjne

        static void znakoweWczytanieLiczbyNaturalnej(string textZaproszenia, out ushort l)
        {
            //deklaracje
            int N; //licznik cyfr
            byte p = 10; //podstawa systemu liczbowego
            string ZZL; //ZZL-(znakowy zapis liczby)
            char cyfra; //pomocnicza zmienna dla pojedynczej cyfry

            //wypisanie zaproszenia do podania liczby
            Console.WriteLine("\n\t\tPodaj "+ textZaproszenia + ": ");
            //znakowe wczytanie liczby
            ZZL = Console.ReadLine();
            //usuniecie ewentualnych tzw. bialych znakow
            ZZL = ZZL.Trim();
            //teraz moge odczytac liczbe znakow w ZZL
            N = ZZL.Length;

            //konwersja znakowego zapisu liczby na wartosc wg schamatu hornera
            l = 0;
            //iteracyjne obliczanie wartosci wartosci liczby z ZZL
            for (int i = 0; i < N; i++)
            {
                //pobranie i-tej cyfry
                cyfra = ZZL[i];
                //sprawdzenie czy jest to cyfra w dziesietnym systemie liczbowym
                if(cyfra >= '0' && cyfra <= '9')
                    l =(ushort)( l * p + ((byte)cyfra - (byte)'0')); 
                else
                {
                    Console.WriteLine($"\n\n\t\tERROR: w podanym zapisie liczby do konwersji" +
                        $"wystapil niedozwolony znak {cyfra}, nie jest to cyfra" +
                        $"w dziesietnym systemie liczbowym");
                    //przerwanie konwersji bo nie ma ona sensu
                    l = 0; //wyslanie domyslnej wartosci liczby w przypadku bledu
                    return; //lub break;
                }

            }
        }

        static void KonwersjaLiczbyNaturalnejNaZapisZnakowy(ushort liczba, out string ZZLPoKonw)
        {
            //deklaracje
            const ushort q = 2;
            ushort licznik = 0; //licznik reszt
            string schowekReszt = "";
            byte reszta;

            //iteracyjne wyznaczanie reszt z dzielenia % q
            while (liczba > 0)
            {
                //obliczanie reszty
                reszta = (byte)(liczba % q);
                //dodanie reszty do schowka reszt
                schowekReszt += (char)(reszta + (byte)'0');
                //dzielenie calkowite
                liczba = (ushort)(liczba / q);
                //zwiekszanie licznika reszt
                licznik++;

            }

            //ustalenie poczatkowego stanu dla odwrocenia cyfr reszt ze schowka
            ZZLPoKonw = "";
            //odwrocenie reszt
            for (int i = licznik - 1; i >= 0; i--)
            {
                ZZLPoKonw += schowekReszt[i];
            }
        }

        static long silnia(int i)
        {
            if (i == 0)
                return 1;
            else
                return i * silnia(i - 1);
        }


        #endregion
    }
    
}
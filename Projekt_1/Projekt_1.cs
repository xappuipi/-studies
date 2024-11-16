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

                        obliczanieWielomianuN();

                        break;

                    case ConsoleKey.C:
                        //wypisanie potwierdzenia wybranej funkcjonalnosci
                        Console.WriteLine("\n\n\t\tWybrana zostala funkcjonalnosc: " +
                            "C: Konwersja znakowego zapisu liczby na jej wartosc");

                        konwersjaLiczby();


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


        static long silnia(int i)
        {
            if (i == 0)
                return 1;
            else
                return i * silnia(i - 1);
        }


        #endregion
        
        static void obliczanieWielomianuN()
        {
            Console.WriteLine("\n\n\t\tObliczanie wartości wielomianu");
            int stopien;

            stopien = wczytajLiczbeNaturalna("stopień wielomianu");

            float[] wspolczynniki = new float[stopien + 1];

            for (int i = 0; i <= stopien; i++)
            {
                wczytajLiczbeRzeczywista($"wspolczynnik przy potedze {i}", out wspolczynniki[i]);
            }
            float x;

            wczytajLiczbeRzeczywista("wartość x", out x);
            double wynik = 0;

            for (int i = 0; i <= stopien; i++)
            {
                wynik += wspolczynniki[i] * Math.Pow(x, i);
            }

            Console.WriteLine("\n\t\tWartość wielomianu wynosi: {0}", wynik);
        }

        static void konwersjaLiczby()
        {
            //tworzenie slownika w ktorym przechowywane sa odpowiadajace znakom cyfry

            var asciiChars = new Dictionary<char, int>();

            for(int i = (int)'0'; i <= (int)'9'; i++)
            {
                asciiChars.Add((char)i, i - (int)'0');
            }

            //pobeiranie liczby w formacie string
            Console.Write("\n\n\t\tPodaj liczbe w formacie string");
            Console.Write("\n\t\t\t"); var liczbaString = Console.ReadLine();

            //konwersja znakowego zapisu na liczbowy
            //mozna to zrobic za pomoca int.Parse() 
            //ale tutaj jest sposob jak to zrobic recznie

            //zmienna ponizej bedzie mnozona przez 10 zeby uzyskac kolejne cyfry a nie dodawac do cyfr jednosci
            int stopien = 1;

            //petla w ktorej kolejne cyfry od prawej beda mnozone przez powyzsza zmienna i dodawane do zmiennej wynik
            int wynik = 0;
            for (int i = liczbaString.Length - 1; i >= 0; i--)
            {
                wynik += asciiChars[liczbaString[i]] * stopien;
                stopien *= 10;
            }

            //wypiwywanie wyniku operacji razem z typem zmiennej
            Console.WriteLine($"\n\n\t\tWynik operacji to: {wynik}, wynik jest typu {wynik.GetType()}");

        }


        static void obliczanieSymboluNewtona()
        {
            int k;
            int n;

            do
            {
                n = wczytajLiczbeNaturalna("Podaj wartosc n (n>= 0) dla wyznaczenia wartosci symbolu newtona");
                k = wczytajLiczbeNaturalna("Podaj wartosc k (k>= 0) dla wyznaczenia wartosci symbolu newtona");

            } while (!(0 <= k) && (k <= n));

            var symbolNewtona = (int)((silnia(n)) / (silnia(k) * silnia(n - k)));

            Console.WriteLine($"\n\n\t\tWYNIKI OBLICZEN: obliczona wartosc symbolu newtona dla podanego n: {n} oraz k: {k}" +
                $"jest rowna: \n\t\t\t\twartosc symbolu newtona: {symbolNewtona}");
        }

        #endregion
    };
}

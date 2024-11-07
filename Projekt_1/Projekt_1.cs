using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Projekt1_Mickiewicz71500;


/*
 * na koncu czas i autor
 */

namespace Projekt1_Kumszczynski71523
{
    internal class TUTAJ_NAZWA_TWOJEGO_PROGRAMU
    {
        public static void Main(string[] args)
        {
            //var tmKI = new tmKalkulatorIndywidualny();
            //Console.WriteLine(tmKI.tmSGeometryczna());

            //Deklaracje zmiennych
            ConsoleKeyInfo wybranaFunkcjonalnosc;



            //wypisanie etryki projektu
            Console.WriteLine("\n\n\n\t\t\tProjekt Nr 1 jest kalkulatorem umozliwiajacym " +
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

                else if (wybranaFunkcjonalnosc.Key == ConsoleKey.B)
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


            } while (wybranaFunkcjonalnosc.Key != ConsoleKey.X);
            //zakonczenie programu
            Console.WriteLine("\n\n\n\t\tAutor programu: Tymon Mickiewicz, numer albumu: 71500");

            //wypisanie daty i godziny wykonania programu
            Console.WriteLine("\n\t\tProgram zostal wykonany: {0}", DateTime.Now);

            //chwilowe zatrzymanie dzialania programu
            Console.WriteLine("\n\n\tDla zakonczenia dzialania programu nacisnij dowolny klawisz . . . ");

            //oczekiwanie na naciesniecie klawisza
            Console.ReadKey(true);
        }
        #region deklaracja matod kalkulatorow
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
                Console.WriteLine("\n\t\tC: Konwersja znakowego zapisu loczby na jej wartosc");
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

                        //wypisanie przeproszenia
                        Console.WriteLine("\n\n\n\tPrzepraszam ale jestem w trakcie implementacji");

                        break;

                    case ConsoleKey.B:
                        //wypisanie potwierdzenia wybranej funkcjonalnosci
                        Console.WriteLine("\n\n\t\tWybrana zostala funkcjonalnosc: " +
                            "B: Obliczanie wartosci wielomianu n-tego stopnia");
                        //wypisanie przeproszenia
                        Console.WriteLine("\n\n\n\tPrzepraszam ale jestem w trakcie implementacji");

                        break;

                    case ConsoleKey.C:
                        //wypisanie potwierdzenia wybranej funkcjonalnosci
                        Console.WriteLine("\n\n\t\tWybrana zostala funkcjonalnosc: " +
                            "C: Konwersja znakowego zapisu liczby na jej wartosc");
                        //wypisanie przeproszenia
                        Console.WriteLine("\n\n\n\tPrzepraszam ale jestem w trakcie implementacji");


                        break;

                    case ConsoleKey.D:
                        //wypisanie potwierdzenia wybranej funkcjonalnosci
                        Console.WriteLine("\n\n\t\tWybrana zostala funkcjonalnosc: " +
                            "A: Obliczanie wartosci symbolu newtona");
                        //wypisanie przeproszenia
                        Console.WriteLine("\n\n\n\tPrzepraszam ale jestem w trakcie implementacji");

                        break;

                    case ConsoleKey.X:
                        //wypisanie potwierdzenia wybranej funkcjonalnosci
                        Console.WriteLine("\n\n\t\tWybrana zostala funkcjonalnosc: " +
                            "X: Wyjscie z kalkulatora");
                        //wypisanie przeproszenia
                        Console.WriteLine("\n\n\n\tPrzepraszam ale jestem w trakcie implementacji");

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

        static void KalkulatorIndywidualny()
        {
            /*
             * TUTAJ OGOLEM BYLO COS NA WZOR TEGO NA GORZE ALE NW JA MAM JAKIES ZJEBANE U SIEBIE TEZ MUSZE ZMIENIC ALE TERAZ MI SIE NIE CHCE, XD
             * */
            return;
        }

        #endregion
    }
}


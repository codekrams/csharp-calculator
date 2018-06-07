using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Taschenrechner
    {
        private static int zaehler = 1;

        static void Main(string[] args)
        {

            int zahleins = eingabeZahl();
            int zahlzwei = eingabeZahl();
            string op = eingabeOperator();
            double ergebnis = rechner(zahleins, zahlzwei, op);

            Console.WriteLine("Das Ergebnis lautet: " + ergebnis.ToString());

            Console.ReadKey();


        }

        private static double rechner(int a, int b, string eingabe) {
            double ergebnis = 0.0;
            if (eingabe == "+")
            {
               ergebnis=addiere(a,b);
            }
            else if (eingabe == "-") {
                ergebnis =subtrahiere(a,b);
            }
            else if (eingabe == "/")
            {
                if (b != 0)
                {
                    ergebnis = dividiere(a, b);
                }
                else {
                    Console.WriteLine("Division durch 0 ist nicht erlaubt");
                }
            }
            else if (eingabe == "*")
            {
                ergebnis = multipliziere(a,b);
            }

            return ergebnis;
            }

        private static int addiere(int x, int y)
        {
            int summe = 0;
            summe = x + y;
            return summe;
        }
        private static int subtrahiere(int x, int y)
        {
            int summe = 0;
            summe = x - y;
            return summe;
        }
        private static int multipliziere(int x, int y)
        {
            int summe = 0;
            summe = x * y;
            return summe;
        }
        private static double dividiere(int x, int y)
        {
            double summe = 0;
            summe = (double)x / (double)y;
            return summe;
        }
        private static int eingabeZahl() {
            int eingabe;
            Console.WriteLine("Bitte geben Sie die {0}. Zahl ein:", zaehler);
            eingabe = Convert.ToInt32(Console.ReadLine());
            zaehler++;
            return eingabe;
        }
        private static string eingabeOperator() {
            string eingabe;
            Console.WriteLine("Bitte geben Sie den Rechenoperator ein:");
            eingabe = Console.ReadLine();
            return eingabe;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_14
{
    /// <summary>
    /// Scrieţi un program care să citească mai multe numere întregi, până la întâlnirea lui zero, 
    /// şi să determine cel mai mic număr şi cel mai mare număr citit.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int numar, min = int.MaxValue, max = int.MinValue, f = 1;
            Console.WriteLine("Introduceti numerele dorite: ");
            while (f != 0)
            {
                numar = int.Parse(Console.ReadLine());
                if (numar > max && numar != 0)
                {
                    max = numar;
                }
                if (numar < min && numar != 0)
                {
                    min = numar;
                }
                if (numar == 0)
                {
                    f = 0;
                }
            }
            Console.WriteLine($"Valoarea maxima este: {max} si cea minima este: {min}");
        }
    }
}
///Am declarat numar, min, max si f, cu instructiunea while f trebuie sa fie diferit de 0
///iar cu instructiunea "if"  numarul fie e mai mare decat valaorea maxima atunci si numarul e maximul , numarul fiind diferit de 0, desigur
///In mod analog, daca e mai mic de cat minimul numarul este minimul, desigur, tot fiderit de 0
///iar daca numarul este 0 => f nu mai e 1 ci e 0.
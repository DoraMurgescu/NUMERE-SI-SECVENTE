using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
   /// <summary>
   /// Să se scrie un program care efectuează mai multe operații la cererea utilizatorului, adică: 
   ///adunare, scădere, înmulțire, împărțire, radical, modulul. (Ulilizați operatorul switch pentru
   ///selectarea funcției calculatorului.). După selectarea opțiunii dorite, programul trebuie să
  ///ceară utilizatorului introducerea datelor necesare, respectiv, în cazul adunării, scăderii, 
  ///înmulțirii și împărțirii, două numere, iar în cazul radicalului și modulului, un singur număr.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int cases;
            double m, n;
            Console.WriteLine("Pentru adunare introduceti 1.  Pentru scadere introduceti 2. " +
                "Pentru inmultire introduceti 3.   Pentru impartire introduceti 4.   " +
                "Pentru radical introduceti 5.   Pentru modul introduceti 6.");
            cases = int.Parse(Console.ReadLine());
            switch (cases)
            {
                case 1:
                    Console.WriteLine("Introduceti doua numere: ");
                    m = double.Parse(Console.ReadLine());
                    n = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Adunarea celor doua numere alese este: {m + n}");
                    break;

                case 2:
                    Console.WriteLine("Introduceti doua numere: ");
                    m = double.Parse(Console.ReadLine());
                    n = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Scaderea celor doua numere alese este: {m - n}");
                    break;

                case 3:
                    Console.WriteLine("Introduceti doua numere: ");
                    m = double.Parse(Console.ReadLine());
                    n = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Inmultirea celor doua numere alese este: {m * n}");
                    break;

                case 4:
                    Console.WriteLine("Introduceti două numere: ");
                    m = double.Parse(Console.ReadLine());
                    n = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Impartirea celor doua numere alese este: {m / n}");
                    break;

                case 5:
                    Console.WriteLine("Introduceti un numar: ");
                    m = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Radicalul numarului ales este: {Math.Sqrt(m)}");
                    break;

                case 6:
                    Console.WriteLine("Introduceti un numar: ");
                    m = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Modulul numarului ales este: {Math.Abs(m)}");
                    break;
            }
        }     
        //Am declarat doua variabile cu instructiunea double, precum am declarat si un "cases" pentru instructiunea switch.
        //Pentru a alege sa efectueze pperatia dorita utilizatorul am scris instructiunea
        //prpriu-zisa, adica "Console.WriteLine" unde am stabilit cate un numar care corespunde cu adunarea, scaderea etc.
        //Am luat fiecare caz in parte pentru toate operatiile.
    }
}
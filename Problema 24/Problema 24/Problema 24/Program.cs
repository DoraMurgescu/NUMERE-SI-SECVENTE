using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_24
{
    /// <summary>
    /// Se citeşte un număr natural. Câte cifre conţine ?
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            
            ulong a;
            Console.WriteLine("Introduceti numarul a dorit: ");
            a = ulong.Parse(Console.ReadLine());
            ulong count = 0;

            if (a < 10)
            {
                Console.WriteLine("1");
            }
            else
            {
                while (a != 0)
                {
                    count++;
                    a /= 10;
                }
                Console.WriteLine($"Numarul a are: {count} cifre");
            }
            Console.ReadLine();
        }
    }
}
//Am declarat variabila a de tip ulog (in caz ca de doreste sa se stie numarul de cifre a unul numar mai lung).
//prima conditie a instructiunii "if" verifica daca a < 10 si afiseaza "1", deoarece numerele sub 10 contin desigur, o singura cifra.
// a doua conditie a instructiunii verifica cate cifre contine numarul a si le numara, desig, a trebuie sa fie diferit de 10 si mia maire 
//se mai adauga un contor pentru numarare, contorul = 0 la inceput, se citesc cate cifre contine numarul a.
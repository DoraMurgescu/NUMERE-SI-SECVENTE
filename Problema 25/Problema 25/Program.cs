using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_25
{
    /// <summary>
    /// Un număr se numeşte “palindrom” dacă citit invers este acelaşi număr. Să se verifice dacă un număr este sau nu palindrom.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int z;
            Console.WriteLine("Introduceti numarul n:  ");
            z = int.Parse(Console.ReadLine());

            if (z == oglindit(z))
            {
                Console.WriteLine($"Numarul {z} este palindrom");

            }
            else
                Console.WriteLine($"Numarul {z} nu este palindrom");
        }

        static int oglindit(int n)
        {
            int og = 0;
            while (n != 0)
            {
                og = og * 10 + n % 10;
                n = n / 10;
            }
            return og;
        }

    }
}
///Am declarat variabila z. Instruectiunea "if" am folosit-o pentru a stabili conditia ca nuamrul z sa fie oglindit astfel el va fi un palindrom.
///Am generat un program pentru "oglindit" care schimba ordinea numerelor "de la coada la cap" si apoi sunt verificate-n "main".
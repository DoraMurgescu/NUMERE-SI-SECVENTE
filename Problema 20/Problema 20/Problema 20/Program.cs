using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_20
{
    /// <summary>
    /// Se citeşte un şir de numere întregi pâna la întâlnirea numărului 0. Să se calculeze media aritmetică a numerelor din şir.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int x, suma = 0, c = 0, fal = 1;
            Console.WriteLine("Introduceti numerele dorite: ");
            while (fal == 1)
            {
                x = int.Parse(Console.ReadLine());
                if (x != 0)
                {
                    suma += x;
                    c++;
                }
                else
                {
                    fal = 0;
                }
            }
            Console.WriteLine($"Media aritmetica a numerelor din sir este: {(float)suma / c}");
            Console.ReadLine();
        }
    }
}
///Se declara variabilele x, suma, c si fal de tip int, se introduc numere de la tastatura pana la intalnirea nuamrului 0,
///Se numara aceste numere si se face media aritmetica a acestora dupa aceea se afiseaza numerele din sir.
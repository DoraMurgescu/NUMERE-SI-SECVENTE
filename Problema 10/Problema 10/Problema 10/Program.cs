using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_10
{
    class Program
    {
        static bool isPrime(int n)
        {
            if (n == 1 || n == 0) return false;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static void Main(String[] args)
        {
            int N;
            Console.Write("N= ");
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if (isPrime(i))
                {
                    Console.WriteLine($"Numerele prime sunt: {i}");
                }
            }
        }
    }
}
//am declarat variabila N, am scris-o si am afisat-o pe consola.
//Programul principal parcurge si verifica cu ajutorul instructiunii "for"
//pornind de la 1 pana la N care numere sunt prime si le afiseaza.
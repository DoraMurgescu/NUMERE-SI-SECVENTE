using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_15
{
    /// <summary>
    /// Scrieţi un program care să calculeze factorialul unui număr întreg n.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            
            int i;
            int a = 1;
            int n;
            Console.Write("Introduceti numarul n: ");
            n = int.Parse(Console.ReadLine());
            
            for (i = 1; i <= n; i++)
            {
                a = a * i;
            }
            
            Console.WriteLine($"Factorialul numarului n este: {a}");
            Console.ReadLine();
        }
    }
}
//Se introduc 2 variabile si 1 constanta.
//Se introduce si valoarea lui n.
//Se realizeaza un loop pentru calcularea factorialului lui n.
//Se prezinta rezultatul adica factorial de n.
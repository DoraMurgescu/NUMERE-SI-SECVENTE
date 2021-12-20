using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3
{
    /// <summary>
    /// Fie i,j,k. Să se determine restul împărţirii numărului natural (i^j) / k.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
           
            Console.Write("baza=");
            i = int.Parse(Console.ReadLine());

            Console.Write("exponent=");
            j = int.Parse(Console.ReadLine());
         
            Console.Write( "k= ");
            k = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Restul impartirii este: {(Math.Pow(i,j)) % k}");
        }
    }
}
//am declarat variabilele i, j si k de tip "int", le-am citit pe consola, am scris: i fiind "baza",
// j fiind "exponent" iar pentru k fiind valoare la care se imparte numarul i^j. La final am scris formula.
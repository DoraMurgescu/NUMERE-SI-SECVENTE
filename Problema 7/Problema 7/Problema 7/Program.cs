using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_7
{
    /// <summary>
    /// Fie n,k. Să se scrie un algoritm pentru calculul numărului combinărilor de n elemente luate câte k.
    /// </summary>
    class Program
    {
        public float factorial(int n1)
        {
            int i;
            float f;
            f = 1;
            for (i = 1; i <= n1; i++)
                f = f * i;
            return f;
        }
        static void Main(string[] args)
        {
            int n, k;
            float cnk;

            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            Console.Write("k=");
            k = int.Parse(Console.ReadLine());

            Program t = new Program();

            cnk = t.factorial(n) / (t.factorial(k) * t.factorial(n - k)); //formula combinarii

            Console.WriteLine("Combinari de {0} luate cate {1} = {2}", n, k, cnk);
        }
    }
}
//Am declarat variabilele i si f pentru calcularea factorialului, introdus intr-un subprogram care va fi apelat in "main".
//Am declarat variabilele de tip "int" : n si k. float cnk (combinari de n luate cate k) apoi le-am scris si citit pe consola
//ca mai apoi sa fie folosite in apelarea subprogramului "factorial" pentru calcularea combinarilor.
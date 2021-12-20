using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
 ///Sa se scrie un program care converteste temperatura din grade celsius in grade fahrenheit si invers utilizand instructiunea switch.
    class Program
    {
        static void Main(string[] args)
        {
            int cases;
            float celsius, fahrenheit;
            
            Console.WriteLine("Pentru grade fahrenheit apasati 1. Pentru grade celsius apasati 2.");

            cases = int.Parse(Console.ReadLine());

            switch (cases)
            {
                case 1:
                    Console.Write("Introduceti temperatura în grade fahrenheit: ");
                    fahrenheit = float.Parse(Console.ReadLine());
                    Console.WriteLine($"Convertirea temperaturii în grade celsius este: {(fahrenheit - 32) * 5 / 9}");
                    break;

                case 2:
                    Console.Write("introduceti temperatura în grade celsius: ");
                    celsius = float.Parse(Console.ReadLine());
                    Console.WriteLine($"Conveertirea temperaturii în grade fahrenheit este: {(celsius * 9 / 5) + 32}");
                    break;
            }
        }
    }
}
//Am declarat "celsius" si "fahrenheit" ca variabile de tip float, precum si "cases" ca variabila "int" pentru instructiunea "switch".
//Am adaugat la alegre proprie si instructiunea "Console.WriteLine cu textul :"Pentru grade fahrenheit apasati 1. Pentru grade celsius apasati 2."
//pentru a oferi posibilitatea de a alege covertirea dorita, apoi am facut pentru fiecare caz in parte convertirea urmata de formula corespunzatoare.



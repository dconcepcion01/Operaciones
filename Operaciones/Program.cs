using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Este programa te calcula 2 numeros

            double n1, n2, suma, resta, multi, div;

            Console.WriteLine("ESTE PROGRAMA TE CALCULA DOS NUMEROS");

            Console.WriteLine("Digite un numero   :");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite un numero  :");
            n2 = double.Parse(Console.ReadLine());

            suma = n1 + n2;
            resta = n1 - n2;
            multi = n1 * n2;
            div = n1 / n2;

            Console.WriteLine("El Resultado de la Suma :"      + suma );
            Console.WriteLine("El Resultado de la Resta es :" + resta);
            Console.WriteLine("El Resultado de la Multipliccacion es :" + multi);
            Console.WriteLine("El Resultado de la Division es :" + div);

            Console.ReadKey();








        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo10_12
{
    class Depuracion
    {
        public void factorial()
        {
            int contador = 0;
            int factorial = 1;

            Console.Write("Ingrese un numero: ");
            int numero = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= numero; i++)
            {
                contador = contador + 1;
                factorial = factorial + contador;
            }
            Console.WriteLine($"El factorial de {numero} es {factorial}");
        }
    }
}

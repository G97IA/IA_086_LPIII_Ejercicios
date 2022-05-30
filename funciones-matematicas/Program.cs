using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace funciones_matematicas
{
    class Program
    {
        static void Main(string[] args)
        {
            //SQRT: Calcular la raíz cuadrada se usa la función Math.Sqrt(valor_a_calcular);
            double raizCuadrada;
            raizCuadrada = Math.Sqrt(9);

            Console.WriteLine($"La raíz cuadrada es : {raizCuadrada}");

            //ABS: Calcular el valor absoluto de un número, use la función Math.Abs(valor_a_calcular);
            double valorAbsoluto;
            valorAbsoluto = Math.Abs(-19);

            Console.WriteLine($"El valor absoluto es : {valorAbsoluto}");

            Console.Read();
        }
    }
}

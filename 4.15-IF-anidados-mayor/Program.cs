using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4._15_IF_anidados_mayor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para calcular, el mayor de tres números.");

            const string TituloIngreso = "Favor ingrese el valor del";
            float Numero1;
            float Numero2;
            float Numero3;
            float NumeroMayor;

            Console.WriteLine($"{TituloIngreso} primer número");
            Numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine($"{TituloIngreso} segundo número");
            Numero2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"{TituloIngreso} tercer número");
            Numero3 = float.Parse(Console.ReadLine());

            if (Numero1 > Numero2)
            {

                if (Numero1 > Numero3)
                {
                    NumeroMayor = Numero1;
                }
                else
                {
                    NumeroMayor = Numero3;
                }

            }
            else
            {

                if (Numero2 > Numero3)
                {
                    NumeroMayor = Numero2;
                }
                else
                {
                    NumeroMayor = Numero3;
                }

            }

            Console.WriteLine($"El número mayor es: {NumeroMayor}");

            Console.Read();
        }
    }
}

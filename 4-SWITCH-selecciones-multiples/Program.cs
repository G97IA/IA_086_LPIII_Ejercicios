using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4_SWITCH_selecciones_multiples
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;

            Console.WriteLine("Favor ingrese un valor a evaluar");
            valor = int.Parse(Console.ReadLine());

            //Varios casos a evaluar para una acción

            switch (valor)
            {
                case 1:
                case 7:
                case 9:
                    Console.WriteLine("Ud ingreso un valor 1 ó 7 ó 9.");
                    break;
                case 10:
                    Console.WriteLine("Ud ingreso el valor de diez.");
                    break;
                case 20:
                case 50:
                case 80:
                    Console.WriteLine("Ud ingreso un valor 20 ó 50 ó 80");
                    break;
                default:
                    Console.WriteLine("Valor no encontrado");
                    break;
            }

            Console.Read();

        }
    }
}

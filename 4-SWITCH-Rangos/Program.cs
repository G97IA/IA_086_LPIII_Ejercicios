using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4_SWITCH_Rangos
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Rango de calificaciones
             * 0-30 Malo
             * 31-60 Regular
             * 61-80 Bueno
             * 81-100 Excelente
             */

            int calificacion;

            Console.WriteLine("Favor ingrese la calificación");
            calificacion = int.Parse(Console.ReadLine());

            Console.WriteLine("switch");
            switch (calificacion)
            {
                case int n when (n >= 0 && n <= 30):
                    Console.WriteLine("Malo");
                    break;
                case int n when (n > 30 && n <= 60):
                    Console.WriteLine("Regular");
                    break;
                case int n when (n > 60 && n <= 80):
                    Console.WriteLine("Bueno");
                    break;
                case int n when (n > 80 && n <= 100):
                    Console.WriteLine("Excelente");
                    break;
                default:
                    Console.WriteLine("Ingreso una calificación no valida.");
                    break;
            }

            //Alternativa utilizando IF: Se nota la complejidad y la legibilidad es menor.
            Console.WriteLine("Utilizando IF.");
            if (calificacion >= 0 && calificacion <= 100)
            {
                if (calificacion >= 0 && calificacion <= 30)
                {
                    Console.WriteLine("Malo");
                }
                else
                {
                    if (calificacion > 30 && calificacion <= 60)
                    {
                        Console.WriteLine("Regular");
                    }
                    else
                    {
                        if (calificacion > 60 && calificacion <= 80)
                        {
                            Console.WriteLine("Bueno");
                        }
                        else
                        {
                            if (calificacion > 80 && calificacion <= 100)
                            {
                                Console.WriteLine("Excelente");
                            }
                        }
                    }
                }
            }

            Console.Read();
        }
    }
}

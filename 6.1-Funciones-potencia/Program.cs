using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6._1_Funciones_potencia
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Programa de calculo de potencias");

            float y;
            float x;
            int n;

            string opcionSalirPrograma;            

            do
            {
                x = leerDesdeConsolaX();
                n = leerDesdeConsolaN();
                y = potencia(x, n);

                Console.WriteLine($"El valor de y es:  { y }");

                Console.WriteLine("¿ Desea continuar el programa (Y/N)?");
                opcionSalirPrograma = Console.ReadLine();
            }
            while (opcionSalirPrograma.ToUpper() == "Y");

            Console.Read();
        }

        public static float leerDesdeConsolaX()
        {
            Console.WriteLine("Favor ingrese X");
            return float.Parse(Console.ReadLine());
        }

        public static int leerDesdeConsolaN()
        {
            Console.WriteLine("Favor ingrese n");
            return int.Parse(Console.ReadLine());
        }

        public static float potencia(float x, int n)
        {
            float y = 1;

            for (int i = 0; i < Math.Abs(n); i++)
            {
                y = y * x;
            }

            if (n < 0)
            {
                y = 1 / y;
            }

            return y;
        }

    }
}

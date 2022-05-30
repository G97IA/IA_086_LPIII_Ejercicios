using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5_Estructuras_repetiticas_FOR_WHILE_DO_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {            
            int numeroRepeticionesFor = 10;
            //Estructura de un FOR
            for (int i = 0; i < numeroRepeticionesFor; i++)
            {
                Console.WriteLine($"Repetición No. i:{i}");
            }

            int opcion = 1;
            Console.WriteLine("Favor seleccione una opción");
            Console.WriteLine("1. Seguir ejecutando el while");           
            Console.WriteLine("2. Salir");

            //Estructura de un WHILE
            while (opcion == 1) 
            {
                Console.WriteLine("Ejecutando, favor ingrese de nuevo la opción");
                opcion = int.Parse(Console.ReadLine());  
            }
          
            int opcionDoWhile;
            //Estructura de un DO-WHILE
            do
            {
                Console.WriteLine("Favor seleccion una opción");
                Console.WriteLine("1. Seguir ejecutando el DO-While");
                Console.WriteLine("2. Salir");
                opcionDoWhile = int.Parse(Console.ReadLine());

            } while (opcionDoWhile == 1);

            Console.WriteLine("Finalizando, favor presione enter.");
            Console.Read();

        }
    }
}

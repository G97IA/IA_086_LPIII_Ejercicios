using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6_Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal miCostoTotal;
            miCostoTotal = CostoTotal(200m, 300m);
            Console.WriteLine($"El costo total es: { miCostoTotal }");

            Console.WriteLine("Favor ingrese la tasa porcentual");
            decimal tasaPorcentual = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Favor ingrese el monto");
            decimal Monto = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Favor ingrese el tiempo ");
            int tiempo = int.Parse(Console.ReadLine());

            decimal interesSimple = InteresSimple(Monto, tasaPorcentual, tiempo);

            Console.WriteLine($"El interes simple es: { interesSimple }");


            Console.Read();
        }

        public static decimal CostoTotal(decimal CostoFijo, decimal CostoVariable)
        {
            decimal costoTotal = CostoFijo + CostoVariable;
            return costoTotal;
        }

        public static decimal InteresSimple(decimal Monto, decimal TasaPorcentual,int Tiempo) {
            decimal interesSimple;
            interesSimple = ((TasaPorcentual / 100) / Tiempo) * Monto;
            return interesSimple;        
        }

    }
}

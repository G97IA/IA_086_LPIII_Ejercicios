using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4._5_nomina
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            int Horas;
            int Tarifa;
            decimal Impuesto;
            decimal SalarioBruto;
            decimal SalarioNeto;
            
            Console.WriteLine("Favor ingrese su nombre:");
            Nombre = Console.ReadLine();

            Console.WriteLine("Favor ingrese las horas trabajadas:");
            Horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Favor ingrese su tarifa");
            Tarifa = int.Parse(Console.ReadLine());

            if (Horas <= 35) {
                SalarioBruto = Horas * Tarifa;
            }
            else
            {
                SalarioBruto = (35 * Tarifa + (Horas - 35) * 1.5m * Tarifa);
            }

            if (SalarioBruto <= 2000) {
                Impuesto = 0;
            }
            else {
                if (SalarioBruto > 2000 && SalarioBruto <= 2200) {
                    Impuesto = (SalarioBruto - 2200) * 0.20m;
                } 
                else {
                    Impuesto = (220 * 0.20m) + (SalarioBruto - 2200);
                }
            }

            SalarioNeto = SalarioBruto - Impuesto;
            Console.WriteLine($"Estimado {Nombre} su salario bruto es {SalarioBruto}" +
                $" sus impuestos son {Impuesto} su salario neto es {SalarioNeto}");

            Console.ReadLine();

        }
    }
}

using System;

namespace ecuacion_primer_grado
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int x;

            Console.WriteLine("Favor ingrese el valor de a:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Favor ingrese el valor de b:");
            b = int.Parse(Console.ReadLine());

            if (a != 0)
            {
                x = -b / a;        
                Console.WriteLine($"El resultado de los valores de a: {a} b: {b} es x: {x}");
            }
            else
            {
                if (b != 0)
                {
                    Console.WriteLine("Solución imposible.");
                }
                else
                {
                    Console.WriteLine("Solución indeterminada.");
                }
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1_While_suma_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int total;
            float numero;
            float suma;

            Console.WriteLine("Favor ingrese el valos de N:");
            n = int.Parse(Console.ReadLine());
            total = n;
            suma = 0;


            while (total > 0) {
                Console.WriteLine("Favor ingrese el valor de número");
                numero = int.Parse(Console.ReadLine());

                suma = suma + numero;
                total -= 1; //total = total - 1

            }

            Console.WriteLine($"La suma de los {n} números es {suma}");

            Console.Read();
        }
    }
}

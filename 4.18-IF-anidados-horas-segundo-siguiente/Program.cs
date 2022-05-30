using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4._18_IF_anidados_horas_segundo_siguiente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula la hora dentro de un segundo");

            const string TituloLecturaDatos = "Favor ingrese";
            int Hora;
            int Minuto;
            int Segundo;

            Console.WriteLine($"{TituloLecturaDatos} la hora");
            Hora = int.Parse(Console.ReadLine());

            Console.WriteLine($"{TituloLecturaDatos} el minuto");
            Minuto = int.Parse(Console.ReadLine());

            Console.WriteLine($"{TituloLecturaDatos} el segundo");
            Segundo = int.Parse(Console.ReadLine());

            if ((Hora < 24) && (Minuto < 60 && Segundo < 60))
            {
                Segundo += 1;

                if (Segundo == 60)
                {
                    Segundo = 0;
                    Minuto += 1;

                    if (Minuto == 60)
                    {
                        Minuto = 0;
                        Hora += 1;

                        if (Hora == 24)
                        {
                            Hora = 0;
                        }
                    }
                }
            }

            Console.WriteLine($"El resultado es hh:{Hora} mm:{Minuto} ss:{Segundo}");

            Console.Read();


        }
    }
}

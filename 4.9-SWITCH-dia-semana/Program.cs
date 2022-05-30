using System;

namespace _4._9_SWITCH_dia_semana
{
    class Program
    {
        static void Main(string[] args)
        {
            int CodigoDia;

            Console.WriteLine("Favor introduzca el número de día de 1-7");
            CodigoDia = int.Parse(Console.ReadLine());

            switch (CodigoDia)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miércoles");
                        break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("¡Es día de descanso!");
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("No se encontro el día con el código indicado.");
                    break;
            }

            Console.WriteLine("Fin del programa.");

            Console.Read();
        }
    }
}

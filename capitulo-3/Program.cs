using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capitulo_3
{
    class Program
    {
        /*
         * La funcion Main, es el punto de entrada de ejecución del programa.
         */
        static void Main(string[] args)
        { //Inicio de metodo Main

            //double numeroElevadoAlcuadrado = Math.Pow(10, 2);

            ////Declaracion de variables y asignacion
            //int Numero1 = 10;
            //int Numero2 = 20;
            //int Resultado; 

            ////operación aritmetica
            //Resultado = Numero1 + Numero2;

            ////A continuacion se muestra la forma en mostrar mensajes en consola.
            //Console.Write("El resultado es: {0}", Resultado);
            //Console.Write("Utilizando Write");
            //Console.WriteLine("Utilizando Writeline");          

            ////Declaracion de variables
            //int Numero;
            //int Horas;
            //int Tasa;

            //Console.WriteLine("Ingrese un numero:");
            //Numero = int.Parse(Console.ReadLine()); //Lee la entrada del usuario

            //Console.WriteLine("Ingrese las horas:");
            //Horas =  int.Parse(Console.ReadLine());

            //Console.WriteLine("Ingrese la tasa");
            //Tasa = int.Parse(Console.ReadLine());

            //Console.WriteLine("Numero: {0} Horas: {1} Tasa: {2}", Numero, Horas, Tasa); //imprime en pantalla, forma 1
            //Console.WriteLine($"Numero: {Numero} Horas: {Horas} Tasa: {Tasa}"); // imprime en pantalla forma 2

            //Declaracion de constante.
            /*
              Este comentario es de multiple
             linea.
             */
            const int MI_CONSTANTE = 3;

            //INICIO algoritmo para evaluar Rango
            //Evaluaciones logicas
            int valor = 30;
            int rangoInicial = 20;
            int rangoFinal = 40;

            //El AND se representa con && el OR con ||
            /* > Mayor que
             * < Menor que
             * >= Mayor o igual
             * <= Menor o igual
             * != Distinto
             * == Igual
             * ! Negacion
             */

            bool estaEnRango = rangoInicial < valor && valor < rangoFinal;
            Console.WriteLine("Esta en el rango: {0}", !estaEnRango);
            //FIN algoritmo para evaluar Rango

            Console.Read();
        }// fin de metodo main
    }
}

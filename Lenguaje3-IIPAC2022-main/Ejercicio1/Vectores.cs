using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Vectores : Form
    {
        public Vectores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Vectores
            int[] vector1 = new int[5];

            vector1[0] = 20;
            vector1[1] = 60;
            vector1[2] = 10;
            vector1[3] = 30;
            vector1[4] = 90;

            int[] vector2 = new int[5] { 80, 60, 41, 56, 87 };
            int[] vector3 = new int[] { 3, 6, 4, 7, 4 };
            int[] vector4 = { 5, 3, 5, 8, 8 };

            string[] vector5 = { "Juan", "Maria", "Carlos", "Sandra" };


            //for (int i = 0; i < vector5.Length; i++)
            //{
            //    listBox1.Items.Add(vector5[i]);
            //}

            foreach (string item in vector5)
            {
                listBox1.Items.Add(item);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Declarar una matriz
            int[,] matrizDeEjemplo = new int[2, 3]
                                                    {
                                                        { 5,9,4 },
                                                        { 1,6,2 }
                                                    };
            //matrizDeEjemplo[0, 0] = 5;
            //matrizDeEjemplo[0, 1] = 9;
            //matrizDeEjemplo[0, 2] = 4;

            //matrizDeEjemplo[1, 0] = 1;
            //matrizDeEjemplo[1, 1] = 6;
            //matrizDeEjemplo[1, 2] = 2;

            int[,] matrizDeEjemplo2 = new int[2, 3];

            //Llenar una matriz

            for (int fila = 0; fila < matrizDeEjemplo2.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matrizDeEjemplo2.GetLength(1); columna++)
                {
                    matrizDeEjemplo2[fila, columna] = 1 + (fila +3) * (columna + 1);
                }
            }

            //Mostrar matriz

            for (int fila = 0; fila < matrizDeEjemplo2.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matrizDeEjemplo2.GetLength(1); columna++)
                {
                    listBox2.Items.Add("La posición: [" + fila + "," + columna + "] = " + matrizDeEjemplo2[fila,columna]);
                }
            }
        }
    }
}

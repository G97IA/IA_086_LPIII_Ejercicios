using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1_CalculoPromedio
{
    public partial class Form1 : Form
    {
        public Form1() { 
        
            InitializeComponent();
        }

        private void textBox3_TextChanged (object sender, EventArgs e) {}
        private void label5_Click (object sender, EventArgs e) {}

        private void buttonCalcular_Click (object sender, EventArgs e) { 

            double nota1, nota2, nota3, nota4, promedio;

            nota1 = double.Parse(textNota1.Text);
            nota2 = double.Parse(textNota2.Text);
            nota3 = double.Parse(textNota3.Text);
            nota4 = double.Parse(textNota4.Text);

            promedio = Promedio (nota1, nota2, nota3, nota4); 

            MessageBox.Show ("El promedio de los 4 Parciales es: " + promedio);

        }

        // Funcion

        private double Promedio (double n1, double n2, double n3, double n4) { 
            
            return (n1 + n2 + n3 + n4) / 4;
       
        }

        private void label5_Click_1(object sender, EventArgs e) {}
        private void pictureBox1_Click(object sender, EventArgs e) {}
        private void label5_Click_2(object sender, EventArgs e) {}
    }
}

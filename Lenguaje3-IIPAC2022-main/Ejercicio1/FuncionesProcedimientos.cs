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
    public partial class FuncionesProcedimientos : Form
    {
        public FuncionesProcedimientos()
        {
            InitializeComponent();
        }
        
        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            int valor1;
            int valor2;

            valor1 = Convert.ToInt32(Valor1TextBox.Text);
            valor2 = Convert.ToInt32(Valor2TextBox.Text);

            Sumar(valor1, valor2);
        }

        //Procedimiento
        private void Sumar(int numero1, int numero2)
        {
            int suma = numero1 + numero2;

            MessageBox.Show("La suma es: " + suma);
        }

        //Función
        private int Restar(int a, int b)
        {
            return a - b;
        }

        private void RestarButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La resta es: " + Restar(Convert.ToInt32(Valor1TextBox.Text), Convert.ToInt32(Valor2TextBox.Text)));
        }
    }
}

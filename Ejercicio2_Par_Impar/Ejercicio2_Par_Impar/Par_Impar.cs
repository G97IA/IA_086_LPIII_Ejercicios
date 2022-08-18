using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2_Par_Impar
{
    public partial class Par_Impar : Form
    {
        public Par_Impar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var numero = int.Parse(textBox1.Text);
            bool salida = EsPar(numero);
            if (salida == true)
            {
                MessageBox.Show("Numero es par.");
            } else {
                MessageBox.Show("Numero es impar.");
            }

        }

        bool EsPar(int numero) {

            if (numero % 2 == 0) {
                return true;
            }
            return false;

        }

        private void label2_Click(object sender, EventArgs e) {}
        private void Par_Impar_Load(object sender, EventArgs e) {}
        private void pictureBox1_Click(object sender, EventArgs e){}
    }
}

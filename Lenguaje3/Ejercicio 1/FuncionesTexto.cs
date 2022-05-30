using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class FuncionesTexto : Form
    {
        public FuncionesTexto()
        {
            InitializeComponent();
        }

        private void GenerarButton_Click(object sender, EventArgs e)
        {
            String cadena = CadenaTextBox.Text;

            if (cadena.Length == 0) {
                MessageBox.Show("Debe ingresar una cadena.");
                CadenaTextBox.Focus();
                return;
            }

            LongitudLabel.Text = cadena.Length.ToString();
            //LongitudLabel.Text = Convert.ToString(cadena.Length);
            PrimerCaracterLabel.Text = cadena.Substring(0, 1);
            UltimoCaracterLabel.Text = cadena.Substring(cadena.Length - 1, 1);
            MayusculasLabel.Text = cadena.ToUpper();
            MinisculasLabel.Text = cadena.ToLower();
            ReemplazarLabel.Text = cadena.Replace("K", "*");
        }   

        private void label1_Click(object sender, EventArgs e) {}
    }
}

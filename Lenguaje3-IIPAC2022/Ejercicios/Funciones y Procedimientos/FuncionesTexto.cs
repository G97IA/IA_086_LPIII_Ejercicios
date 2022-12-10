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
    public partial class FuncionesTexto : Form
    {
        public FuncionesTexto()
        {
            InitializeComponent();
        }

        private void GenerarButton_Click(object sender, EventArgs e)
        {
            string cadena = CadenaTextBox.Text;

            //if (cadena.Length == 0)
            //{
            //    MessageBox.Show("Debe ingresar una cadena");
            //    CadenaTextBox.Focus();
            //    return;
            //}

            if (string.IsNullOrEmpty(cadena))
            {
                MessageBox.Show("Debe ingresar una cadena");
                CadenaTextBox.Focus();
                return;
            }

            LongitudLabel.Text = cadena.Length.ToString();
            PrimerCaracterLabel.Text = cadena.Substring(0, 1);
            UltimoCaracterLabel.Text = cadena.Substring(cadena.Length - 1, 1);
            MayusculasLabel.Text = cadena.ToUpper();
            MinusculasLabel.Text = cadena.ToLower();
            ReemplazarLabel.Text = cadena.Replace("n","*");

        }

        private void CadenaTextBox_TextChanged(object sender, EventArgs e)
        {
            CadenaTextBox.Text = CadenaTextBox.Text.Replace("Nahum", "*****");
        }
    }
}

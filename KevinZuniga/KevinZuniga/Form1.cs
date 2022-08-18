using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KevinZuniga
{
    public partial class Form1 : Form
    {
        public Form1() {InitializeComponent();}

        string[] Meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

        private void CalcularInteresButton_Click(object sender, EventArgs e) {double Tasa = 0.015; double Monto = 0; CalculoInteres(Tasa, Monto);}

        public void CalculoInteres(double Tasa, double Monto) {

            double Tasa1 = Tasa; double Monto1 = Monto;
            Monto1 = 200000;
            double[,] MontoInteresMensual = new double[12, 2];

            for (int i = 0; i < MontoInteresMensual.GetLength(0); i++) {

                MontoInteresMensual[i, 0] = Monto1 * Tasa1 * 1;
                MontoInteresMensual[i, 1] = MontoInteresMensual[i, 0] + Monto1;
                Monto1 += MontoInteresMensual[i, 0];
            }

            for (int j = 0; j < MontoInteresMensual.GetLength(0); j++) {

                CalculoInteresListBox.Items.Add("En el mes de:  " + Meses[j] + " el interes es de: " + MontoInteresMensual[j, 0] + " Con un Subtotal de: " + MontoInteresMensual[j, 1]);
            }
        }
    }
}

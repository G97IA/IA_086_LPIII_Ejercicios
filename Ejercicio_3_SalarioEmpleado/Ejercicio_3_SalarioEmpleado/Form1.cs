using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3_SalarioEmpleado {

    public partial class Form1 : Form {

        public Form1() { 

            InitializeComponent();
        
        }

        private void button1_Click(object sender, EventArgs e) {}

        private void MostrarButton_Click(object sender, EventArgs e) {
     
            DateTime fechaNacimiento = (dateTimePicker1.Value);
            MessageBox.Show("Fecha de nacimiento: " + "Año: " + fechaNacimiento.Year + " Mes: " + fechaNacimiento.Month + " Dia: " + fechaNacimiento.Day,".", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(DevuelveLaEdadPersona(fechaNacimiento).ToString(), "Edad ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private int DevuelveLaEdadPersona(DateTime fechaNacimiento) {

            DateTime _fechaNacimiento = fechaNacimiento;
            DateTime _fechaActual = DateTime.Now;

            int edad;

            if (_fechaNacimiento >= _fechaActual) {

                edad = 0;

            } else {

                edad = _fechaActual.Year - _fechaNacimiento.Year;

                if (_fechaNacimiento.Month > _fechaActual.Month) {

                    --edad;

                }

                if (edad >= 30) {

                    MessageBox.Show("Aplica para aumento de salario.");

                } else {

                    MessageBox.Show("No aplica para aumento de salario.");
                }
            }

            return edad;

        }

        private void CalcularButton_Click(object sender, EventArgs e) {

            int ventasPromedio;
            ventasPromedio = Convert.ToInt32(textBox1.Text);


            if (ventasPromedio >= 10000) {

                MessageBox.Show("Las ventas promedio son mayores de: 10000, aplica para aumento de salario. ");
                int aumento = (ventasPromedio * 5) / 100;
                MessageBox.Show("El aumento es de: " + aumento);
                int aumento1 = ventasPromedio + (ventasPromedio * 5) / 100;
                MessageBox.Show("El nuevo salario mas el aumento es de: " + aumento1);
            
            } else {

                MessageBox.Show("Las ventas promedio son menores de: 10000, no aplica para aumento de salario. ");
                MessageBox.Show("El salario es de: " + ventasPromedio);
            }
        }

        private void GenerarButton_Click(object sender, EventArgs e) {

            int tiempoLaborando;
            tiempoLaborando = Convert.ToInt32(textBox2.Text);

            if (tiempoLaborando >= 10) {
               
                MessageBox.Show("Tiene mas de 10 años laborando, aplica para aumento. ");

            } else {   

                MessageBox.Show("Tiene menos de 10 años laborando, no aplica para aumento. ");

            }
        }

        private void Form1_Load(object sender, EventArgs e) {}
    }
}

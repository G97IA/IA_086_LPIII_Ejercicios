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
    public partial class FuncionesDataTime : Form
    {
        public FuncionesDataTime()
        {
            InitializeComponent();
        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;

            //MessageBox.Show("Año: " + fecha.Year, "Formato de Fecha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBox.Show("Mes: " + fecha.Month, "Formato de Fecha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBox.Show("Día: " + fecha.Day, "Formato de Fecha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBox.Show("Día: " + fecha.DayOfWeek, "Formato de Fecha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBox.Show("Día: " + fecha.DayOfYear, "Formato de Fecha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBox.Show(fecha.Year + "-" + fecha.Month + "-" + fecha.Day, "Formato de Fecha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBox.Show(fecha.AddDays(3).ToShortDateString(), "Formato de Fecha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBox.Show(fecha.AddDays(-10).ToShortDateString(), "Formato de Fecha", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MessageBox.Show(DevuelveLaEdadPersona(fecha).ToString(), "Edad", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private int DevuelveLaEdadPersona(DateTime fechaNacimiento)
        {
            DateTime _fechaNacimiento = fechaNacimiento;
            DateTime _fechaActual = DateTime.Now;

            int edad = 0;

            if (_fechaNacimiento >= _fechaActual)
            {
                edad = 0;
            }
            else
            {
                edad = _fechaActual.Year - _fechaNacimiento.Year;
                if (_fechaNacimiento.Month > _fechaActual.Month)
                {
                    --edad;
                }
            }

            return edad;
        }


    }
}

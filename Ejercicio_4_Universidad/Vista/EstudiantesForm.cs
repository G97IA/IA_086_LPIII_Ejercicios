using System;
using Datos;
using Entidades;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class EstudiantesForm : Form
    {
        public EstudiantesForm()
        {
            InitializeComponent();
        }

        string tipoOperacion = string.Empty;
        UsuarioDatos userDatos = new UsuarioDatos();
        Usuario user = new Usuario();

        private void HabilitarControles()
        {
            IdentidadTextBox.Enabled = true;
            CodigoTextBox.Enabled = true;
            NombreTextBox.Enabled = true;
            CarreraTextBox.Enabled = true;
            CorreoTextBox.Enabled = true;
            TelefonoTextBox.Enabled = true;
            DireccionTextBox.Enabled = true; 
        }

        private void DesabilitarControles()
        {
            IdentidadTextBox.Enabled = false;
            CodigoTextBox.Enabled = false;
            NombreTextBox.Enabled = false;
            CarreraTextBox.Enabled = false;
            CorreoTextBox.Enabled = false;
            TelefonoTextBox.Enabled = false;
            DireccionTextBox.Enabled = false;
        }

        private async void LlenarDataGrid()
        {
            EstudiantesDataGridView.DataSource = await userDatos.DevolverUsuariosAsync();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            HabilitarControles();
            tipoOperacion = "nuevo";
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DesabilitarControles();
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            tipoOperacion = "modificar";
        }

        private void EstudiantesForm_Load(object sender, EventArgs e)
        {
            LlenarDataGrid();
        }

        private async void GuardarButton_Click(object sender, EventArgs e)
        {
            if (tipoOperacion == "nuevo")
            {
                if (string.IsNullOrEmpty(CodigoTextBox.Text))
                {
                    errorProvider1.SetError(CodigoTextBox, "Ingrese un código");
                    CodigoTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(NombreTextBox.Text))
                {
                    errorProvider1.SetError(NombreTextBox, "Ingrese un nombre");
                    NombreTextBox.Focus();
                    return;
                }

                user.Codigo = CodigoTextBox.Text;
                user.Nombre = NombreTextBox.Text;
                user.Email = CorreoTextBox.Text;

                bool inserto = await userDatos.InsertarNuevoUsuarioAsync(user);

                if (inserto)
                {
                    MessageBox.Show("Usuario Guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarDataGrid();

                }
                else
                {
                    MessageBox.Show("Usuario No se pudo Guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

    }
}

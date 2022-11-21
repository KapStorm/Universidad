using Choferes.Entidades;
using Choferes.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Choferes.Front
{
    public partial class FrmAgregarVisitante : Form
    {
        public FrmAgregarVisitante()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            nudEdad.Value = 1;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            int edad = Convert.ToInt32(nudEdad.Value);

            if (string.IsNullOrEmpty(nombres) || string.IsNullOrEmpty(apellidos)) return;

            try
            {
                Visitante visitante = new Visitante(nombres, apellidos, edad);
                string rpta = NVisitante.AgregarVisitante(visitante);

                if (rpta == "OK")
                {
                    MessageBox.Show("Visitante agregada con éxito", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else if (rpta == "YA EXISTE")
                {
                    MessageBox.Show("No se pudo agregar, ya existe el visitante", "No agregado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("No se pudo agregar", "No agregado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No fue posible agrega los datos");

                foreach (SqlError err in ex.Errors)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void txtNombres_Validating(object sender, CancelEventArgs e)
        {
            string nombres = txtNombres.Text;

            if (nombres == null || nombres.Length < 3)
            {
                e.Cancel = true;
                txtNombres.SelectAll();
                errorP.SetError(txtNombres, "Error: Debe de tener una longitud mayor de 3");
            }
        }

        private void txtApellidos_Validating(object sender, CancelEventArgs e)
        {
            string apellidos = txtApellidos.Text;

            if (apellidos == null || apellidos.Length < 3)
            {
                e.Cancel = true;
                txtApellidos.SelectAll();
                errorP.SetError(txtApellidos, "Error: Debe de tener una longitud mayor de 3");
            }
        }

        private void txtNombres_Validated(object sender, EventArgs e)
        {
            errorP.Clear();
        }

        private void txtApellidos_Validated(object sender, EventArgs e)
        {
            errorP.Clear();
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

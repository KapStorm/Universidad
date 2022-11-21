using Choferes.Entidades;
using Choferes.Negocio;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Choferes.Front
{
    public partial class FrmAgregarChofer : Form
    {
        public FrmAgregarChofer()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtNumeroLicencia.Text = "";
            dtpFecha.Value = DateTime.Now;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            string numeroLicencia = txtNumeroLicencia.Text;
            DateTime fecha = dtpFecha.Value;

            if (string.IsNullOrEmpty(nombres) || string.IsNullOrEmpty(apellidos) || string.IsNullOrEmpty(numeroLicencia) || fecha == null)
                return;

            try
            {
                Chofer chofer = new Chofer(nombres, apellidos, numeroLicencia, fecha);
                string salida = NChofer.Agregar(chofer);

                if (salida == "Ok")
                {
                    MessageBox.Show("Agregado con éxito", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else if (salida == "YA EXISTE")
                {
                    MessageBox.Show("El chofer ya existe", "No Agregado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("No se pudo agregar", "No Agregado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Imposible consultar con los datos");

                foreach (SqlError err in ex.Errors)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void FrmAgregarChofer_Load(object sender, EventArgs e)
        {
            dtpFecha.MinDate = DateTime.Now;
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

        private void txtNombres_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string nombres = txtNombres.Text;

            if (nombres == null || nombres.Length < 3)
            {
                e.Cancel = true;
                txtNombres.SelectAll();
                errorP.SetError(txtNombres, "Error: Debe de tener una longitud mayor de 3");
            }
        }

        private void txtNombres_Validated(object sender, EventArgs e)
        {
            errorP.Clear();
        }

        private void txtApellidos_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string apellidos = txtApellidos.Text;

            if (apellidos == null || apellidos.Length < 3)
            {
                e.Cancel = true;
                txtApellidos.SelectAll();
                errorP.SetError(txtApellidos, "Error: Debe de tener una longitud mayor de 3");
            }
        }

        private void txtApellidos_Validated(object sender, EventArgs e)
        {
            errorP.Clear();
        }

        private void txtNumeroLicencia_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string numeroLicencia = txtNumeroLicencia.Text;

            if (numeroLicencia == null || numeroLicencia.Length < 10)
            {
                e.Cancel = true;
                txtNumeroLicencia.SelectAll();
                errorP.SetError(txtNumeroLicencia, "Error: Debe de tener una longitud de 10");
            }
        }
    }
}

using Choferes.Entidades;
using Choferes.Negocio;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Choferes.Front
{
    public partial class FrmAgregarVisita : Form
    {
        public FrmAgregarVisita()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            cmbChofer.SelectedIndex = 0;
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;
            nupNumeroPersonas.Value = 1;
            cmbTipoEvento.SelectedIndex = 0;
            txtDescripcionEvento.Text = "";
            txtCiudadDestino.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int chofer = Convert.ToInt32(cmbChofer.GetItemText(cmbChofer.SelectedItem));
            DateTime fechaInicio = dtpFechaInicio.Value;
            DateTime fechaFin = dtpFechaFin.Value;
            int numeroPersonas = Convert.ToInt32(nupNumeroPersonas.Value);
            char tipoEvento = ' ';
            switch (cmbTipoEvento.SelectedIndex)
            {
                case 0:
                    tipoEvento = 'C';
                    break;
                case 1:
                    tipoEvento = 'M';
                    break;
                case 2:
                    tipoEvento = 'F';
                    break;
                case 3:
                    tipoEvento = 'D';
                    break;
                case 4:
                    tipoEvento = 'E';
                    break;
            }
            string descripcionEvento = txtDescripcionEvento.Text;
            string ciudadDestino = txtCiudadDestino.Text;

            if (fechaInicio == null || fechaFin == null || string.IsNullOrEmpty(descripcionEvento) || string.IsNullOrEmpty(ciudadDestino))
                return;

            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha final no puede ser mayor a la fecha de inicio", "Fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Visita visita = new Visita(chofer, fechaInicio, fechaFin, numeroPersonas, tipoEvento, descripcionEvento, ciudadDestino);
                string rpta = NVisita.Agregar(visita);

                if (rpta == "OK")
                {
                    MessageBox.Show("Visita agregada con éxito", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else if (rpta == "CHOFER NO DISPONIBLE")
                {
                    MessageBox.Show("No se pudo agregar, chofer no disponible", "No agregado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void FrmAgregarVisita_Load(object sender, EventArgs e)
        {
            dtpFechaInicio.MinDate = DateTime.Now;
            dtpFechaFin.MinDate = DateTime.Now;

            try
            {
                cmbChofer.DataSource = NChofer.ObtenerNumeroEmpleadoChoferes();
                cmbChofer.DisplayMember = "NUM EMPLEADO";
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

        private void cmbChofer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int clave = Convert.ToInt32(cmbChofer.GetItemText(cmbChofer.SelectedItem));
                Chofer chofer = NChofer.ObtenerChofer(clave);
                txtNombreChofer.Text = $"{chofer.Nombres} {chofer.Apellidos}";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Imposible consultar con los datos");

                foreach (SqlError err in ex.Errors)
                {
                    MessageBox.Show(err.Message);

                }
            }
            catch (Exception) { }
        }

        private void txtTipoEvento_Validated(object sender, EventArgs e)
        {
            errorP.Clear();
        }

        private void txtDescripcionEvento_Validated(object sender, EventArgs e)
        {
            errorP.Clear();
        }

        private void txtCiudadDestino_Validated(object sender, EventArgs e)
        {
            errorP.Clear();
        }

        private void txtDescripcionEvento_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string descripcion = txtDescripcionEvento.Text;

            if (descripcion == null || descripcion.Length < 3)
            {
                e.Cancel = true;
                txtDescripcionEvento.SelectAll();
                errorP.SetError(txtDescripcionEvento, "Error: Debe de tener una longitud mayor de 3");
            }
        }

        private void txtCiudadDestino_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string ciudad = txtCiudadDestino.Text;

            if (ciudad == null || ciudad.Length < 3)
            {
                e.Cancel = true;
                txtCiudadDestino.SelectAll();
                errorP.SetError(txtCiudadDestino, "Error: Debe de tener una longitud mayor de 3");
            }
        }

        private void txtTipoEvento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDescripcionEvento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCiudadDestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

using System;
using System.Windows.Forms;

namespace Auto
{
    public partial class frmAgregarServicio : Form
    {
        private AdmServicio admServicio;

        public frmAgregarServicio(AdmServicio admServicio)
        {
            InitializeComponent();
            this.admServicio = admServicio;
        }

        public void Limpiar()
        {
            txtClave.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string clave = txtClave.Text;
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            string costoString = txtPrecio.Text;

            if (string.IsNullOrEmpty(clave)
                || string.IsNullOrEmpty(nombre)
                || string.IsNullOrEmpty(descripcion)
                || string.IsNullOrEmpty(costoString)
                )
            {
                MessageBox.Show("No se admiten campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double costo = Convert.ToDouble(costoString);

            if (admServicio.ExisteClave(clave)) {
                MessageBox.Show("Ya se tiene esa clave","Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Servicio servicio = new Servicio(nombre, descripcion, costo);
            admServicio.AgregarServicio(clave, servicio);

            MessageBox.Show("Servicio agregado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Limpiar();
        }

        private void txtClave_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string texto = txtClave.Text;

            if (string.IsNullOrEmpty(texto))
            {
                e.Cancel = true;
                txtClave.SelectAll();
                errorP.SetError(txtClave, "Debe de tener algo escrito");
            }
            
            foreach(char c in texto)
            {
                if (Char.IsLetter(c))
                {
                    e.Cancel = true;
                    txtClave.SelectAll();
                    errorP.SetError(txtClave, "Solo admite numeros");
                }
            }
        }

        private void txtClave_Validated(object sender, EventArgs e)
        {
            errorP.Clear();
        }

        private void txtNombre_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string texto = txtNombre.Text;

            if (string.IsNullOrEmpty(texto))
            {
                e.Cancel = true;
                txtNombre.SelectAll();
                errorP.SetError(txtNombre, "Debe de tener algo escrito");
            }
        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            errorP.Clear();
        }

        private void txtDescripcion_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string texto = txtDescripcion.Text;

            if (string.IsNullOrEmpty(texto))
            {
                e.Cancel = true;
                txtDescripcion.SelectAll();
                errorP.SetError(txtDescripcion, "Debe de tener algo escrito");
            }
        }

        private void txtDescripcion_Validated(object sender, EventArgs e)
        {
            errorP.Clear();
        }

        private void txtPrecio_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            double precio = 0;

            try
            {
                precio = Convert.ToDouble(txtPrecio.Text);
            }
            catch (Exception)
            {
                e.Cancel = true;
                txtPrecio.SelectAll();
                errorP.SetError(txtPrecio, "Debe de contener un numero");
            }

            if (precio < 0)
            {
                e.Cancel = true;
                txtPrecio.SelectAll();
                errorP.SetError(txtPrecio, "El precio debe de ser positivo");
            }
        }

        private void txtPrecio_Validated(object sender, EventArgs e)
        {
            errorP.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultaServicio frmConsulta = new frmConsultaServicio(admServicio);
            frmConsulta.ShowDialog();
        }
    }
}

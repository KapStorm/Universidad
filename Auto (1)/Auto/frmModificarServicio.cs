using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto
{
    public partial class frmModificarServicio : Form
    {
        AdmServicio admS;
        Servicio servicio;
        public frmModificarServicio(AdmServicio admS)
        {
            InitializeComponent();
            this.admS = admS;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbClave.SelectedItem.ToString())) return;

            DialogResult result = MessageBox.Show("¿Desea modificar el servicio?", "Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //Modificacion
                string newNombre = txtNombre.Text;
                string newDescripcion = txtDescripcion.Text;
                string newCosto = txtPrecio.Text;
                double newCos = Convert.ToDouble(newCosto);

                //Modificamos
                servicio.pNombre = newNombre;
                servicio.pDescripcion = newDescripcion;
                servicio.pCosto = newCos;
            }
        }
        private void cmbClave_SelectedIndexChanged(object sender, EventArgs e)
        {
            string campo = cmbClave.SelectedItem.ToString();
            servicio = admS.ObtenerServicio(campo);

            //Mandamos los datos guardados de ese servicio
            txtNombre.Text = servicio.pNombre;
            txtDescripcion.Text = servicio.pDescripcion;
            txtPrecio.Text = servicio.pCosto.ToString();
        }

        private void frmModificarServicio_Load(object sender, EventArgs e)
        {
            List<string> lista = admS.ObtenerClaves();
            cmbClave.DataSource = lista;
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            string campo = txtNombre.Text;
            if (string.IsNullOrEmpty(campo))
            {
                e.Cancel = true;
                txtNombre.SelectAll();
                errorP.SetError(txtNombre, "Ingrese un nombre.");
            }
            foreach (char c in campo)
            {
                if (Char.IsDigit(c))
                {
                    e.Cancel = true;
                    txtNombre.SelectAll();
                    errorP.SetError(txtNombre,"No se admiten numeros");
                }
            }
        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            errorP.Clear();
        }

        private void txtDescripcion_Validating(object sender, CancelEventArgs e)
        {
            string campo = txtDescripcion.Text;
            if (string.IsNullOrEmpty(campo))
            {
                e.Cancel = true;
                txtDescripcion.SelectAll();
                errorP.SetError(txtDescripcion, "Ingrese una descripcion");
            }
        }

        private void txtDescripcion_Validated(object sender, EventArgs e)
        {
            errorP.Clear();
        }

        private void txtPrecio_Validating(object sender, CancelEventArgs e)
        {
            string campo = txtPrecio.Text;
            if (string.IsNullOrEmpty(campo))
            {
                e.Cancel = true;
                txtPrecio.SelectAll();
                errorP.SetError(txtPrecio, "Ingrese un precio.");
            }

            foreach (char c in campo)
            {
                if (Char.IsLetter(c))
                {
                    e.Cancel = true;
                    txtPrecio.SelectAll();
                    errorP.SetError(txtPrecio, "No se aceptan letras.");
                    return;
                }
            }

            double precio = Convert.ToDouble(campo);
            if (precio < 0)
            {
                e.Cancel = true;
                txtPrecio.SelectAll();
                errorP.SetError(txtPrecio, "Tiene que ser positivo.");
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
    }
}

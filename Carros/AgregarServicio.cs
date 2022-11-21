using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carros
{
    public partial class frmAgregarServicio : Form
    {
        AdministraCatalogoServicio admCatalogo;
        public frmAgregarServicio(AdministraCatalogoServicio admCatalogo)
        {
            InitializeComponent();
            this.admCatalogo = admCatalogo;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();

        }
        public void Limpiar()//Este metodo pone todos los valores por defecto y vacios
        {
            txtNomServicio.Text = "";
            txtClaveServicio.Text = "";
            txtCosto.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string clave = txtClaveServicio.Text;
            if (admCatalogo.BuscaClave(clave))
            {
                MessageBox.Show("La clave ya existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string nombre = txtNomServicio.Text;
                if (String.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("Ingrese el nombre del servicio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string costoText = txtCosto.Text;
                    if (String.IsNullOrWhiteSpace(costoText))
                    {
                        MessageBox.Show("Ingrese el costo del servicio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        double costo = Convert.ToDouble(txtCosto.Text);
                        admCatalogo.AgregarServicio(clave, nombre, costo);
                        MessageBox.Show("Servicio agregado con exito!", "INFORMACION", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);//Mandamos mensaje de confirmacion
                        Limpiar();
                    }
                }
            }
        }
        //Validacion de costo
        private void txtCosto_Validating(object sender, CancelEventArgs e)
        {
            double costo = 0;
            try
            {
                costo = Convert.ToDouble(txtCosto.Text);
                if (costo <= 0)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                e.Cancel = true;
                txtCosto.SelectAll();
                errorPServicio.SetError(txtCosto, "ERROR: Ingrese un costo mayor a 0");
            }
        }
        private void txtCosto_Validated(object sender, EventArgs e)
        {
            errorPServicio.Clear();
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsControl(e.KeyChar)) && char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //termina validacion de costo
        //Validacion clave de servicio
        private void txtClaveServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsControl(e.KeyChar)) && char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtClaveServicio_Validating(object sender, CancelEventArgs e)
        {
            string dato = txtClaveServicio.Text;
            int conversion = 0;
            try
            {
                conversion = Convert.ToInt32(txtClaveServicio.Text);
                if(dato.Length != 5)
                {
                    throw new Exception();
                }
            }
            catch(Exception)
            {
                e.Cancel = true;
                txtClaveServicio.SelectAll();
                errorPServicio.SetError(txtClaveServicio, "ERROR: Ingrese un valor numerico");
            }
        }
        private void txtClaveServicio_Validated(object sender, EventArgs e)
        {
            errorPServicio.Clear();
        }
        //Termina validacion clave servicio
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            frmConsultaServicio consultaServicio = new frmConsultaServicio(admCatalogo);
            consultaServicio.ShowDialog();//Mostramos la ventana de consultas
        }

    }      
}

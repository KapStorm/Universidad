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
    public partial class frmModificarCosto : Form
    {
        AdministraCatalogoServicio admCat;
        public frmModificarCosto(AdministraCatalogoServicio admCat)
        {
            InitializeComponent();
            this.admCat = admCat;
        }

        private void frmModificarCosto_Load(object sender, EventArgs e)
        {
            List<string> listado = admCat.RegresaClave();
            cmbClave.DataSource = listado;
        }
        private void cmbClave_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clave = cmbClave.SelectedItem.ToString();
            CatalogoServicio CatSer = admCat.RegresaCatalogo(clave);
            txtNombre.Text = CatSer.pNombreServicio;
            txtCosto.Text = CatSer.pCosto.ToString();
        }

        private void cmbClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        //Validacion de costo
        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsControl(e.KeyChar)) && (char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtCosto_Validating(object sender, CancelEventArgs e)
        {
            double conversion = 0;
            try
            {
                conversion = Convert.ToDouble(txtCosto.Text);
                if (conversion<=0)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                e.Cancel = true;
                txtCosto.SelectAll();
                errorP.SetError(txtCosto, "ERROR: Ingrese un costo mayor a 0");
            }            
        }

        private void txtCosto_Validated(object sender, EventArgs e)
        {
            errorP.Clear();
        }
        //Fin validacion de costo
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(cmbClave.SelectedItem == null)
            {
                MessageBox.Show("Lista de servicios vacia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Desea guardar los cambios?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string clave = cmbClave.SelectedItem.ToString();
                    CatalogoServicio catClave = admCat.RegresaCatalogo(clave);
                    catClave.pCosto = Convert.ToDouble(txtCosto.Text);
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

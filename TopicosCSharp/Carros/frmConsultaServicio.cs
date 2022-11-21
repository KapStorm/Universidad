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
    public partial class frmConsultaServicio : Form
    {
        AdministraCatalogoServicio admCat;
        public frmConsultaServicio(AdministraCatalogoServicio admCat)
        {
            InitializeComponent();
            this.admCat = admCat;  
        }
        private void frmConsultaServicio_Load(object sender, EventArgs e)
        {
            List<string> listado = admCat.RegresaClave();
            cmbClave.DataSource = listado;
        }
        private void cmbClave_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clave = cmbClave.SelectedIndex.ToString();
            CatalogoServicio cat = admCat.RegresaCatalogo(cmbClave.Text);
            txtNombre.Text = cat.pNombreServicio;
            txtCosto.Text = "$" + cat.pCosto.ToString();
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

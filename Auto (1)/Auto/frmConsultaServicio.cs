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
    public partial class frmConsultaServicio : Form
    {
        private AdmServicio admServicio;

        public frmConsultaServicio(AdmServicio admServicio)
        {
            InitializeComponent();
            this.admServicio = admServicio; 
        }

        private void frmConsultaServicio_Load(object sender, EventArgs e)
        {
            List<string> claves = admServicio.ObtenerClaves();
            cmbClave.DataSource = claves;
        }

        private void cmbClave_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clave = cmbClave.Text;
            Servicio servicio = admServicio.ObtenerServicio(clave);

            txtNombre.Text = servicio.pNombre;
            txtDescripcion.Text = servicio.pDescripcion;
            txtCosto.Text = servicio.pCosto.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

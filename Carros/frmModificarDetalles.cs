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
    public partial class frmModificarDetalles : Form
    {
        Administrador adm;
        public frmModificarDetalles(Administrador adm)
        {
            InitializeComponent();
            this.adm = adm;
        }

        private void cmbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            string numSerie = cmbLista.SelectedItem.ToString();
            Carro auto = adm.RegresaAuto(numSerie);
            txtNombre.Text = auto.pNombre;
            txtMarca.Text = auto.pMarca;
            rtxtDetalles.Text = auto.pDetalle;
            picLogo.Image = auto.pMarca == "NISSAN" ? Carros.Properties.Resources.nissan :
                auto.pMarca == "CHEVROLET" ? Carros.Properties.Resources.chevrolet :
                auto.pMarca == "HYUNDAI" ? Carros.Properties.Resources.hyundai :
                auto.pMarca == "FORD" ? Carros.Properties.Resources.ford : Carros.Properties.Resources.Mazda;
        }

        private void frmModificarDetalles_Load(object sender, EventArgs e)
        {
            List<string> lista = adm.RegresaNumSerie();
            cmbLista.DataSource = lista;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbLista.SelectedItem ==null)
            {
                MessageBox.Show("Lista de autos vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Desea guardar los cambios?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string numSerie = cmbLista.SelectedItem.ToString();
                    Carro auto = adm.RegresaAuto(numSerie);
                    auto.pDetalle = rtxtDetalles.Text;
                    MessageBox.Show("Detalle modificado con exito!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void rtxtDetalles_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void cmbLista_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

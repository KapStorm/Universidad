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
    public partial class frmReporteDetalles : Form
    {
        Administrador adm;
        public frmReporteDetalles(Administrador adm)
        {
            InitializeComponent();
            this.adm = adm;
        }

        private void frmReporteDetalles_Load(object sender, EventArgs e)
        {
            cmbMarca.SelectedIndex = 0;
        }

        private void cmbNumSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Carro> auto = adm.RegresaCarros();
            List<string> numSerie = adm.RegresaNumSerie();

            dgvDetalles.Rows.Clear();
            if (rbtnSi.Checked) {
                for (int i = 0; i < auto.Count; i++)
                {
                    if (auto.ElementAt(i).pMarca == cmbMarca.SelectedItem.ToString() && auto.ElementAt(i).pDetalle != "")
                    {
                        dgvDetalles.Rows.Add(numSerie.ElementAt(i), auto.ElementAt(i).pMarca, auto.ElementAt(i).pDetalle);
                    }
                }
            }
            else 
            {
                for (int i = 0; i < auto.Count; i++)
                {
                    if (auto.ElementAt(i).pMarca == cmbMarca.SelectedItem.ToString() && auto.ElementAt(i).pDetalle == "")
                    {
                        dgvDetalles.Rows.Add(numSerie.ElementAt(i), auto.ElementAt(i).pMarca, auto.ElementAt(i).pDetalle);
                    }
                }               
            }
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

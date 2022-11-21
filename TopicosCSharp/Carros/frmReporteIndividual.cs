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
    public partial class frmReporteIndividual : Form
    {
        AdministraReporte admRep;
        Administrador adm;
        AdministraCatalogoServicio admCat;
        public frmReporteIndividual(AdministraReporte admRep, Administrador adm, AdministraCatalogoServicio admCat)
        {
            InitializeComponent();
            this.admRep = admRep;
            this.adm = adm;
            this.admCat = admCat;
        }

        private void frmReporteIndividual_Load(object sender, EventArgs e)
        {
            List<string> listaFolio = admRep.RegresaFolio();
            cmbFolio.DataSource = listaFolio;
        }

        private void cmbFolio_SelectedIndexChanged(object sender, EventArgs e)
        {
            string folio = cmbFolio.SelectedItem.ToString();
            Reporte rep = admRep.RegresaReporte(folio);
            txtNumSerie.Text = rep.pNumSerie;
            txtClave.Text = rep.pClaveServ;
            txtFecha.Text = rep.pFecha.ToShortDateString().ToString();
            txtNombreAuto.Text = adm.RegresaAuto(rep.pNumSerie).pNombre;
            txtNomServicio.Text = admCat.RegresaCatalogo(rep.pClaveServ).pNombreServicio;
        }

        private void cmbFolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

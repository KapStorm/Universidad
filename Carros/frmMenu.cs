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
    public partial class frmMenu : Form
    {
        Administrador adm;
        AdministraCatalogoServicio admCatalogo;
        AdministraReporte admReporte;
        public frmMenu()
        {
            InitializeComponent();
            adm = new Administrador();
            admCatalogo = new AdministraCatalogoServicio();
            admReporte = new AdministraReporte();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 Carros = new Form1(adm);
            Carros.ShowDialog();
        }
        private void individualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulta Consulta = new frmConsulta(adm);
            Consulta.ShowDialog();
        }
        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaGeneral ConsultaGeneral = new frmConsultaGeneral(adm);
            ConsultaGeneral.ShowDialog();
        }
        private void frmMenu_Load(object sender, EventArgs e)
        {
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAgregarServicio AgregarServicio = new frmAgregarServicio(admCatalogo);
            AgregarServicio.ShowDialog();
        }

        private void individualToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaServicio ConsultaServicio = new frmConsultaServicio(admCatalogo);
            ConsultaServicio.ShowDialog();
        }

        private void generalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaServicioGeneral ConsultaGeneral = new frmConsultaServicioGeneral(admCatalogo);
            ConsultaGeneral.ShowDialog();
        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAcercade AcercaDe = new frmAcercade();
            AcercaDe.ShowDialog();
        }

        private void detallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarDetalles detalles = new frmModificarDetalles(adm);
            detalles.ShowDialog();
        }

        private void costoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarCosto costo = new frmModificarCosto(admCatalogo);
            costo.ShowDialog();
        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmAgregarReporte reporte = new frmAgregarReporte(adm,admCatalogo,admReporte);
            reporte.ShowDialog();
        }

        private void generalToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmConsultaReporteGeneral reporte = new frmConsultaReporteGeneral(admReporte,adm,admCatalogo);
            reporte.ShowDialog();
        }

        private void porDetallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteDetalles detalle = new frmReporteDetalles(adm);
            detalle.ShowDialog();
        }

        private void porServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrarServicioAuto mostrar = new frmMostrarServicioAuto(adm,admCatalogo,admReporte);
            mostrar.ShowDialog();
        }

        private void individualToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmReporteIndividual rep = new frmReporteIndividual(admReporte, adm, admCatalogo);
            rep.ShowDialog();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

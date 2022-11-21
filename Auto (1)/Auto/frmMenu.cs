using Auto;
using System;
using System.Windows.Forms;

namespace Auto
{
    public partial class frmMenu : Form
    {
        AdmAuto admAuto;
        AdmServicio admServicio;
        AdmAutoServicio admAutoServicio;
        public frmMenu()
        {
            InitializeComponent();
            admAuto = new AdmAuto();
            admServicio = new AdmServicio();
            admAutoServicio = new AdmAutoServicio();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarAuto autos = new frmAgregarAuto(admAuto);
            autos.ShowDialog();
        }

        private void individualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaAuto consultafrm = new frmConsultaAuto(admAuto);
            consultafrm.ShowDialog();
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaTodosDatos consultafrm = new frmConsultaTodosDatos(admAuto);
            consultafrm.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();//Salir de toda la aplicacion
        }

        private void agregarServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarServicio frm = new frmAgregarServicio(admServicio);
            frm.ShowDialog();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarAuto frm = new frmModificarAuto(admAuto, admAutoServicio);
            frm.ShowDialog();
        }

        private void consultaIndividualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaServicio frm = new frmConsultaServicio(admServicio);
            frm.ShowDialog();
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmModificarServicio frmModificar = new frmModificarServicio(admServicio);
            frmModificar.ShowDialog();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercade acerca = new frmAcercade();
            acerca.ShowDialog();
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void consultaTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaTodoServicio frmServ = new frmConsultaTodoServicio(admServicio);
            frmServ.ShowDialog();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAgregarAutoServicio frmDetalle = new frmAgregarAutoServicio(admAutoServicio, admAuto, admServicio);
            frmDetalle.ShowDialog();
        }

        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportePorFecha frm = new frmReportePorFecha(admAutoServicio, admAuto, admServicio);
            frm.ShowDialog();
        }

        private void individualToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaAutoServicio frm = new frmConsultaAutoServicio(admAuto, admServicio, admAutoServicio);
            frm.ShowDialog();
        }

        private void productosOrdenadosPorPrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteAutosServicio frm = new frmReporteAutosServicio(admServicio, admAutoServicio, admAuto);
            frm.ShowDialog();
        }

        private void totalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaTodosAutoServicio frmTodos = new frmConsultaTodosAutoServicio(admServicio,admAuto,admAutoServicio);
            frmTodos.ShowDialog();
        }
    }
}

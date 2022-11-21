using Choferes.Front;
using System;
using System.Windows.Forms;

namespace SQL
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void individualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaChoferes frm = new FrmConsultaChoferes();
            frm.ShowDialog();
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaChoferesTodos frm = new FrmConsultaChoferesTodos();
            frm.ShowDialog();
        }

        private void todosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaVisitasTodos frm = new FrmConsultaVisitasTodos();
            frm.ShowDialog();
        }

        private void individualToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaVisitas frm = new FrmConsultaVisitas();
            frm.ShowDialog();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarChofer frm = new FrmAgregarChofer();
            frm.ShowDialog();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAgregarVisita frm = new FrmAgregarVisita();
            frm.ShowDialog();
        }

        private void todosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmConsultarVisitantesTodos frm = new FrmConsultarVisitantesTodos();
            frm.ShowDialog();
        }

        private void individualToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmConsultaVisitante frm = new FrmConsultaVisitante();
            frm.ShowDialog();
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmAgregarVisitante frm = new FrmAgregarVisitante();
            frm.ShowDialog();
        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmAgregarVisitanteAVisita frm = new FrmAgregarVisitanteAVisita();
            frm.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaVisitanteVisita frm = new FrmConsultaVisitanteVisita();
            frm.ShowDialog();
        }

        private void visitasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmReportesVisitas frm = new FrmReportesVisitas();
            frm.ShowDialog();
        }

        private void choferesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmReporteChoferesDisponible frm = new FrmReporteChoferesDisponible();
            frm.ShowDialog();
        }
    }
}

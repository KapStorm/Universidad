using Choferes.Negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace SQL
{
    public partial class FrmConsultaChoferesTodos : Form
    {
        public FrmConsultaChoferesTodos()
        {
            InitializeComponent();
        }

        private void FrmConsultaChoferesTodos_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable data = NChofer.ObtenerChoferes();
                dgvChoferes.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

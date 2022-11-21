using Choferes.Negocio;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Choferes.Front
{
    public partial class FrmConsultarVisitantesTodos : Form
    {
        public FrmConsultarVisitantesTodos()
        {
            InitializeComponent();
        }

        private void FrmConsultarVisitantesTodos_Load(object sender, EventArgs e)
        {
            try
            {
                dgvVisitantes.DataSource = NVisitante.ObtenerVisitantes();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Imposible consultar con los datos");

                foreach (SqlError err in ex.Errors)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }
    }
}

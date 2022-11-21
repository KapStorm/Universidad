using Choferes.Negocio;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SQL
{
    public partial class FrmConsultaVisitasTodos : Form
    {
        public FrmConsultaVisitasTodos()
        {
            InitializeComponent();
        }

        private void FrmConsultaVisitasTodos_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable table = NVisita.ObtenerVistas();
                dgvVisitas.DataSource = table;
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

using Choferes.Negocio;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Choferes.Front
{
    public partial class FrmConsultaVisitanteVisita : Form
    {
        public FrmConsultaVisitanteVisita()
        {
            InitializeComponent();
        }

        private void FrmConsultaVisitanteVisita_Load(object sender, EventArgs e)
        {
            try
            {
                cmbClaves.DataSource = NVisita.ObtenerClaveVisitas();
                cmbClaves.DisplayMember = "CLAVE";
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

        private void cmbClaves_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string claveStr = cmbClaves.GetItemText(cmbClaves.SelectedItem);
                int clave = Convert.ToInt32(claveStr);

                dgvVisitas.DataSource = NVisitaVisitante.ObtenerDatos(clave);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Imposible consultar con los datos");

                foreach (SqlError err in ex.Errors)
                {
                    MessageBox.Show(err.Message);
                }
            }
            catch (Exception) { }
        }
    }
}

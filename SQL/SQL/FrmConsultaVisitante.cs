using Choferes.Entidades;
using Choferes.Negocio;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Choferes.Front
{
    public partial class FrmConsultaVisitante : Form
    {
        public FrmConsultaVisitante()
        {
            InitializeComponent();
        }

        private void FrmConsultaVisitante_Load(object sender, System.EventArgs e)
        {
            try
            {
                cmbVisitantes.DataSource = NVisitante.ObtenerClaveVisitantes();
                cmbVisitantes.DisplayMember = "CLAVE";
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

        private void cmbVisitantes_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string claveStr = cmbVisitantes.GetItemText(cmbVisitantes.SelectedItem);

            if (claveStr == null) return;

            try
            {
                int clave = Convert.ToInt32(claveStr);
                Visitante visitante = NVisitante.ObtenerVisitante(clave);

                if (visitante == null) return;

                txtNombres.Text = visitante.Nombres;
                txtApellidos.Text = visitante.Apellidos;
                txtEdad.Text = visitante.Edad.ToString();
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

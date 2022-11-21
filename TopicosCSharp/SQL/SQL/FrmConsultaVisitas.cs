using Choferes.Entidades;
using Choferes.Negocio;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SQL
{
    public partial class FrmConsultaVisitas : Form
    {
        public FrmConsultaVisitas()
        {
            InitializeComponent();
        }

        private void FrmConsultaVisitas_Load(object sender, EventArgs e)
        {
            try
            {
                cmbClave.DataSource = NVisita.ObtenerClaveVisitas();
                cmbClave.DisplayMember = "CLAVE";
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

        private void cmbClave_SelectedIndexChanged(object sender, EventArgs e)
        {
            string claveVisitaStr = cmbClave.GetItemText(cmbClave.SelectedItem);

            if (claveVisitaStr == null) return;

            try
            {
                int claveVisita = Convert.ToInt32(claveVisitaStr);
                Visita visita = NVisita.ObtenerVisita(claveVisita);

                txtChofer.Text = visita.Chofer.ToString();
                dtpFechaInicio.Text = visita.FechaInicio.ToString("dd-MM-yyyy");
                dtpFechaFinal.Text = visita.FechaFin.ToString("dd-MM-yyyy");
                txtNumeroPersonas.Text = visita.NumeroPersonas.ToString();
                
                switch (visita.TipoEvento)
                {
                    case 'C':
                        txtTipoEvento.Text = "CONGRESO";
                        break;
                    case 'M':
                        txtTipoEvento.Text = "MUSEO";
                        break;
                    case 'F':
                        txtTipoEvento.Text = "FIESTA";
                        break;
                    case 'D':
                        txtTipoEvento.Text = "DISCOTECA";
                        break;
                    case 'E':
                        txtTipoEvento.Text = "ESCUELA";
                        break;
                }
                txtDescripcionEvento.Text = visita.DescripcionEvento;
                txtCiudadDestino.Text = visita.CiudadDestino;

                Chofer chofer = NChofer.ObtenerChofer(visita.Chofer);
                txtNombreChofer.Text = $"{chofer.Nombres} {chofer.Apellidos}";
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

using Choferes.Entidades;
using Choferes.Negocio;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Choferes.Front
{
    public partial class FrmAgregarVisitanteAVisita : Form
    {
        public FrmAgregarVisitanteAVisita()
        {
            InitializeComponent();
        }

        public void RecargarDGV()
        {
            try
            {
                string claveStr = cmbClaveVisita.GetItemText(cmbClaveVisita.SelectedItem);
                int clave = Convert.ToInt32(claveStr);
                dgvVisita.DataSource = NVisitaVisitante.ObtenerDatos(clave);
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

        private void FrmAgregarVisitanteAVisita_Load(object sender, EventArgs e)
        {
            try
            {
                cmbClaveVisita.DataSource = NVisita.ObtenerClaveVisitas();
                cmbClaveVisita.DisplayMember = "CLAVE";

                cmbClaveVisitante.DataSource = NVisitante.ObtenerClaveVisitantes();
                cmbClaveVisitante.DisplayMember = "CLAVE";

                RecargarDGV();
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string claveVisitaStr = cmbClaveVisita.GetItemText(cmbClaveVisita.SelectedItem);
                int claveVisita = Convert.ToInt32(claveVisitaStr);

                string claveVisitanteStr = cmbClaveVisitante.GetItemText(cmbClaveVisitante.SelectedItem);
                int claveVisitante = Convert.ToInt32(claveVisitanteStr);

                string rpta = NVisitaVisitante.AgregarVisitanteAVisita(claveVisita, claveVisitante);
                if (rpta == "Ok")
                {
                    MessageBox.Show("Visitante agregada con éxito", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rpta == "YA EXISTE")
                {
                    MessageBox.Show("No se pudo agregar, ya existe el visitante", "No agregado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("No se pudo agregar", "No agregado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                RecargarDGV();
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

        private void cmbClaveVisitante_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string claveVisitanteStr = cmbClaveVisitante.GetItemText(cmbClaveVisitante.SelectedItem);
                int claveVisitante = Convert.ToInt32(claveVisitanteStr);

                Visitante visitante = NVisitante.ObtenerVisitante(claveVisitante);
                txtNombreVisitante.Text = $"{visitante.Nombres} {visitante.Apellidos}";
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

        private void cmbClaveVisita_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecargarDGV();
        }
    }
}

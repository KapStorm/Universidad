using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Choferes.Negocio;
using Choferes.Entidades;
using System;

namespace SQL
{
    public partial class FrmConsultaChoferes : Form
    { 
        public FrmConsultaChoferes()
        {
            InitializeComponent();
        }

        private void FrmConsultaChoferes_Load(object sender, System.EventArgs e)
        {
            try
            { 
                cmbChofer.DataSource = NChofer.ObtenerNumeroEmpleadoChoferes();
                cmbChofer.DisplayMember = "NUM EMPLEADO";
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

        private void cmbChofer_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string numeroEmpleadoStr = cmbChofer.GetItemText(cmbChofer.SelectedItem);

            if (numeroEmpleadoStr == null) return;
            
            try
            {
                int numeroEmpleado = Convert.ToInt32(numeroEmpleadoStr);
                Chofer chofer = NChofer.ObtenerChofer(numeroEmpleado);

                if (chofer == null) return;

                txtNombres.Text = chofer.Nombres;
                txtApellidos.Text = chofer.Apellidos;
                txtNumLicencia.Text = chofer.NumeroLicencia;
                txtFechaVenLicencia.Text = chofer.FechaVencimientoLicencia.ToString();
            }
            catch(SqlException ex)
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

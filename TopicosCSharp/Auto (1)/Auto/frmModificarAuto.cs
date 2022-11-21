using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Auto
{
    public partial class frmModificarAuto : Form
    {
        AdmAuto admA;
        Auto autoA;
        public frmModificarAuto(AdmAuto adma, AdmAutoServicio adms)
        {
            InitializeComponent();
            admA = adma;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbNumSerie.SelectedItem == null) return;

            DialogResult result = MessageBox.Show("¿Desea modificar el auto?", "Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //Modificacion
                byte nNumeroPa = Convert.ToByte(numupPasajeros.Value);
                bool nEstandar = rdEstandar.Checked;
                string nDescripcion = txtOtros.Text;//Descripcion agregada
                nDescripcion += chkDefensa.Checked ? "DEFENSA" + "\n" : "";
                nDescripcion += chkPuertas.Checked ? "PUERTAS" + "\n" : "";
                nDescripcion += chkTrasera.Checked ? "TRASERA" + "\n" : "";
                string nPropietario = txtPropietario.Text;

                autoA.pnumPasajeros = nNumeroPa;
                autoA.pEstandar = nEstandar;
                autoA.pDetalles = nDescripcion;
                autoA.pPropietario = nPropietario;
            }
        }

        private void cmbNumSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Modificacion
            string campo = cmbNumSerie.SelectedItem.ToString();
            autoA = admA.GetAuto(campo);

            //Mostramos los datos que obtuvimos
            txtNomAuto.Text = autoA.pnombre;
            txtMarca.Text = autoA.pmarca;
            txtPropietario.Text = autoA.pPropietario;
            numupPasajeros.Value = autoA.pnumPasajeros;
            rdAutomatica.Checked = !autoA.pEstandar;
            rdEstandar.Checked = autoA.pEstandar;
            chkDefensa.Checked = autoA.pDetalles.Contains("DEFENSA");
            chkPuertas.Checked = autoA.pDetalles.Contains("PUERTAS");
            chkTrasera.Checked = autoA.pDetalles.Contains("TRASERA");

        }

        private void frmModificarAuto_Load(object sender, EventArgs e)
        {
            List<string> lista = admA.RegresaNumSerie();
            cmbNumSerie.DataSource = lista;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPropietario_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string campo = txtPropietario.Text;
            if (string.IsNullOrEmpty(campo))
            {
                e.Cancel = true;
                txtPropietario.SelectAll();
                errorP.SetError(txtPropietario, "Campo vacío");
            }
   
        }

        private void txtPropietario_Validated(object sender, EventArgs e)
        {
            errorP.Clear();
        }
    }
}

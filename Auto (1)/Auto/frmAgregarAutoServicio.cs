using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Auto
{
    public partial class frmAgregarAutoServicio : Form
    {
        AdmAutoServicio admAutoServicio;
        AdmAuto admAuto;
        AdmServicio admServicio;

        public frmAgregarAutoServicio(AdmAutoServicio admSer, AdmAuto admAu, AdmServicio admServicio)
        {
            InitializeComponent();
            admAutoServicio = admSer;
            admAuto = admAu;
            this.admServicio = admServicio;
        }

        public void Limpiar()
        {
            txtFolio.Text = admAutoServicio.ListaServicio().Count.ToString();
            txtDesc.Text = "";
            cmbFolio.SelectedIndex = 0;
            cmbMatAuto.SelectedIndex = 0;
            mntFecha.MinDate = DateTime.Now;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Agregar Servicio
            string folio = txtFolio.Text;
            string numSerieAuto = cmbMatAuto.SelectedItem.ToString();
            string folioServicio = cmbFolio.SelectedItem.ToString();
            double descuento = 0;

            if (!string.IsNullOrEmpty(txtDesc.Text))
                descuento = Convert.ToDouble(txtDesc.Text);

            DateTime fecha = mntFecha.SelectionStart;

            admAutoServicio.AgregaServ(folio, numSerieAuto, folioServicio, fecha, descuento);
            Limpiar();

            MessageBox.Show("Agregado exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbMatAuto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string numeroSerie = cmbMatAuto.SelectedItem.ToString(); //Obtenemos el nombre del auto mediante la matricula
            Auto auto = admAuto.GetAuto(numeroSerie);
            txtNomAuto.Text = auto.pnombre;
        }

        private void FrmAgregarServ_Load(object sender, EventArgs e)
        {
            cmbMatAuto.DataSource = admAuto.RegresaNumSerie();
            cmbFolio.DataSource = admServicio.ObtenerClaves();
                
            txtFolio.Text = admAutoServicio.ListaServicio().Count.ToString();
            mntFecha.MinDate = DateTime.Now;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtDesc_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            double descuento = 0;
            Servicio servicio = admServicio.ObtenerServicio(cmbFolio.SelectedItem.ToString());

            try
            {
                descuento = Convert.ToDouble(txtDesc.Text);
            }
            catch (Exception)
            {
                e.Cancel = true;
                txtDesc.SelectAll();
                errorP.SetError(txtDesc, "Debe de ser un numero");
            }

            try
            {
                if (descuento < 0) throw new Exception("No se admiten descuentos negativos");
                if (descuento > servicio.pCosto) throw new Exception("No se admiten descuentos mayor al precio");
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                txtDesc.SelectAll();
                errorP.SetError(txtDesc, ex.Message);
            }
        }

        private void txtDesc_Validated(object sender, EventArgs e)
        {
            errorP.Clear();
        }

        private void cmbMatAuto_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cmbMatAuto.SelectedIndex < 0) //El index del primer elemento es 0 por lo que si es menor a cero marcara error.
            {
                e.Cancel = true;
                cmbMatAuto.SelectAll();
                errorP.SetError(cmbMatAuto, "Error, seleccione un elemento");
            }
        }

        private void cmbMatAuto_Validated(object sender, EventArgs e)
        {
            errorP.Clear();
        }

        private void cmbFolio_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cmbFolio.SelectedIndex < 0) //El index del primer elemento es 0 por lo que si es menor a cero marcara error.
            {
                e.Cancel = true;
                cmbFolio.SelectAll();
                errorP.SetError(cmbFolio, "Error, seleccione un elemento");
            }
        }

        private void cmbFolio_Validated(object sender, EventArgs e)
        {
            errorP.Clear();
        }

        private void cmbFolio_SelectedIndexChanged(object sender, EventArgs e)
        {
            string numeroSerie = cmbFolio.SelectedItem.ToString(); //Obtenemos el nombre del auto mediante la matricula
            Servicio servicio = admServicio.ObtenerServicio(numeroSerie);
            txtNombre.Text = servicio.pNombre;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultaAutoServicio frm = new frmConsultaAutoServicio(admAuto, admServicio, admAutoServicio);
            frm.ShowDialog();
        }
    }
}

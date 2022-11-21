using System.Windows.Forms;
using System.Collections.Generic;

namespace Auto
{
    public partial class frmConsultaAutoServicio : Form
    {
        private AdmAuto admAuto;
        private AdmServicio admServicio;
        private AdmAutoServicio admAutoServicio;

        public frmConsultaAutoServicio(AdmAuto admAuto, AdmServicio admServicio, AdmAutoServicio admAutoServicio)
        {
            InitializeComponent();
            this.admAuto = admAuto;
            this.admServicio = admServicio;
            this.admAutoServicio = admAutoServicio;
        }

        private void frmConsultaAutoServicio_Load(object sender, System.EventArgs e)
        {
            cmbFolio.DataSource = admAutoServicio.ListaClv();
        }

        private void cmbFolio_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            AutoServicio autoServicio = admAutoServicio.Clave(cmbFolio.SelectedItem.ToString());
            Auto auto = admAuto.GetAuto(autoServicio.pNumeroAuto);
            Servicio servicio = admServicio.ObtenerServicio(autoServicio.pClaveServicio);

            txtAutoNumSerie.Text = autoServicio.pClaveServicio;
            txtAutoNombre.Text = auto.pnombre;

            txtServicioClave.Text = autoServicio.pClaveServicio;
            txtServicioNombre.Text = servicio.pNombre;

            txtFecha.Text = autoServicio.pFecha.ToString("yyyy-MM-dd");
            txtPrecio.Text = (servicio.pCosto - autoServicio.pDescuento).ToString();
        }

        private void btnSalir_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto
{
    public partial class frmReporteAutosServicio : Form
    {
        AdmAuto admAuto;
        AdmServicio admServicio;
        AdmAutoServicio admAutoServicio;

        public frmReporteAutosServicio(AdmServicio admServicio, AdmAutoServicio admAutoServicio, AdmAuto admAuto)
        {
            InitializeComponent();
            this.admAuto = admAuto;
            this.admServicio = admServicio;
            this.admAutoServicio = admAutoServicio;
        }

        private void frmReporteAutosMarca_Load(object sender, EventArgs e)
        {
            cmbServicio.DataSource = admServicio.ObtenerClaves();
        }

        private void cmbServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvConsultaMarca.Rows.Clear();

            string servicioClave = cmbServicio.SelectedItem.ToString();
            Servicio servicio = admServicio.ObtenerServicio(servicioClave);
            List<AutoServicio> listaServicios = admAutoServicio.ListaServicio();
            List<string> listaServiciosFolio = admAutoServicio.ListaClv();

            txtServicioNombre.Text = servicio.pNombre;

            for (int i = 0; i < listaServicios.Count; i++)
            {
                if (listaServicios[i].pClaveServicio == servicioClave)
                {
                    Auto auto = admAuto.GetAuto(listaServicios[i].pNumeroAuto);
                    dgvConsultaMarca.Rows.Add(listaServiciosFolio[i], listaServicios[i].pNumeroAuto, auto.pnombre, listaServicios[i].pFecha.ToString("yyyy-MM-dd"), servicio.pCosto - listaServicios[i].pDescuento);
                }
            }
        }
    }
}

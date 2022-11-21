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
    public partial class frmConsultaTodosDatos : Form
    {
       AdmAuto adm;
        public frmConsultaTodosDatos(AdmAuto adm2)
        {
            InitializeComponent();
            adm = adm2;
        }

        private void dgvAutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmConsultaTodosDatos_Load(object sender, EventArgs e)
        {
            //LLENAR DATAGRID AGREGAR EL NUMERO DE SERIE
            List<Auto> listaAutos = adm.RegresaAutos();
            List<string> listaNumS = adm.RegresaNumSerie();
            for (int i = 0; i < listaAutos.Count; i++)
            {
                dgvAutos.Rows.Add(listaNumS[i], listaAutos[i].pnombre, listaAutos[i].pmarca, listaAutos[i].pPropietario, listaAutos[i].pnumPasajeros, listaAutos[i].pDetalles, listaAutos[i].pEstandar ? "ESTANDAR" : "AUTOMATICO");
            }
        }
    }
}

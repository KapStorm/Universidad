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
    public partial class frmConsultaTodoServicio : Form
    {
        AdmServicio admS;
        public frmConsultaTodoServicio(AdmServicio admS2)
        {
            InitializeComponent();
            admS = admS2;
        }

        private void frmConsultaTodoServicio_Load(object sender, EventArgs e)
        {
            //Lenar datos con el numero de serie
            List<Servicio> listaServicio = admS.ObtenerServicios();
            List<string> listaNumeroS = admS.ObtenerClaves();
            for (int i = 0; i < listaServicio.Count; i++)
            {
                dgvServicios.Rows.Add(listaNumeroS[i], listaServicio[i].pNombre, listaServicio[i].pDescripcion, listaServicio[i].pCosto);
            }
        }
    }
}

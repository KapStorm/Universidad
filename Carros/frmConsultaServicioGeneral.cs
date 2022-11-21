using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carros
{
    public partial class frmConsultaServicioGeneral : Form
    {
        AdministraCatalogoServicio admCat;
        public frmConsultaServicioGeneral(AdministraCatalogoServicio admCat)
        {
            InitializeComponent();
            this.admCat = admCat;
        }

        private void frmConsultaServicioGeneral_Load(object sender, EventArgs e)
        {
            int j = 0;
            List<CatalogoServicio> Listado = admCat.RegresaCatalogoServicio();
            List<string> ListaClave = admCat.RegresaClave();

            foreach (CatalogoServicio serv in Listado)
            {
                dvgServicios.Rows.Add(ListaClave.ElementAt(j), serv.pNombreServicio, serv.pCosto);
                j++;
            }
        }
    }
}

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
    public partial class frmConsultaGeneral : Form
    {
        Administrador adm;
        public frmConsultaGeneral(Administrador adm)
        {
            InitializeComponent();
            this.adm = adm;
        }

        private void frmConsultaGeneral_Load(object sender, EventArgs e)
        {
            List<Carro> listado = adm.RegresaCarros();
            List<string> listaNum = adm.RegresaNumSerie();
            int j = 0;
            foreach (Carro i in listado)
            {
                dgvCarros.Rows.Add(listaNum.ElementAt(j),i.pNombre,i.pMarca,i.pNumPasajeros,i.pTransmision,i.pDetalle);
                j++;
            }          
        }

        private void dgvCarros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


}

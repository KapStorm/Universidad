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
    public partial class frmConsulta : Form
    {
        Administrador adm;
        public frmConsulta(Administrador adm) 
        {
            InitializeComponent();
            this.adm = adm;          
        }
        private void frmConsulta_Load(object sender, EventArgs e)
        {
            List<string> lista = adm.RegresaNumSerie();//Administramos el evento obteniendo la lista de objetos agregados
            cmbNumSerie.DataSource = lista;//Agregamos la lista en el combobox
        }
        private void cmbNumSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            string NumSerie = cmbNumSerie.SelectedItem.ToString();//Seleccionamos uno de los objetos agregados
            Carro carro = adm.RegresaAuto(NumSerie);//Utilizamos el metodo para obtener los datos de ese objeto
            txtNombre.Text = carro.pNombre;//utilizamos la propiedad para obtener nombre
            txtMarca.Text = carro.pMarca;//utilizamos la propiedad para obtener marca
            picLogo.Image = carro.pMarca == "NISSAN" ? Carros.Properties.Resources.nissan :
                carro.pMarca == "CHEVROLET" ? Carros.Properties.Resources.chevrolet :
                carro.pMarca == "HYUNDAI" ? Carros.Properties.Resources.hyundai :
                carro.pMarca == "FORD" ? Carros.Properties.Resources.ford : Carros.Properties.Resources.Mazda;
            txtTransmision.Text = carro.pTransmision;
            txtNumPasajeros.Text = carro.pNumPasajeros.ToString();//Utilizamos la propiedad para agregar la informacion
            rtxtDetalle.Text = carro.pDetalle;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();//Utilizamos el metodo close para cerrar la ventana
        }

        private void cmbNumSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

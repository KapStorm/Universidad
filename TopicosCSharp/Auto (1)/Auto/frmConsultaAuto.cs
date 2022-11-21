using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Auto
{
    public partial class frmConsultaAuto : Form
    {
        AdmAuto admAuto; //Creamos un objeto tipo Administra auto para referenciar
        public frmConsultaAuto(AdmAuto autos) //Constructor
        {
            admAuto = autos;
            InitializeComponent();
        }

        private void cmbNumSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            string numSerie = cmbNumSerie.SelectedItem.ToString(); //Mostrar numeros de serie, el seleccionado asignarlo a una nueva variable
            Auto auto = admAuto.GetAuto(numSerie); //Referencia al auto en el dictionary con ese numero de serie
            txtMarca.Text = auto.pmarca; //Mostramos su marca
            txtNomAuto.Text = auto.pnombre; //Mostramos su nombre
            txtNumPasajeros.Text = auto.pnumPasajeros.ToString(); //Mostramos el numero de pasajeros
            if (auto.pEstandar) //Validamos si auto en su propiedad Estandar es verdadero es el valor por defecto (Estandar)
            {
                txtTransmision.Text = "ESTANDAR";//Mostramos el tipo de transmision
            }
            else
            {
                txtTransmision.Text = "AUTOMATICO";//Mostramos el tipo de transmision
            }
            rchDetalleC.Text = auto.pDetalles;//Agregar los detalles en un richbox
            txtPropietario.Text = auto.pPropietario;
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            List<string> lista = admAuto.RegresaNumSerie(); //Lista con los numeros de serie guardados
            cmbNumSerie.DataSource = lista; //Mostrar lista en el combo box
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();//Salir
        }
    }
}

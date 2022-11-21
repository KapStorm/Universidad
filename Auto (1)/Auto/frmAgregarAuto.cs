using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Auto
{
    public partial class frmAgregarAuto : Form
    {
        AdmAuto admAuto;
        public frmAgregarAuto(AdmAuto admn)
        {
            InitializeComponent();
            admAuto = admn;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Llamamos al metodo limpiar porque se utilizará
            Limpiar();
        }
        public void Limpiar()
        {
            //Creación de metodo limpiar para despues de cada proceso terminado inicialicemos los campos.
            txtNumSerie.Text = "";
            txtNomAuto.Text = "";
            txtPropietario.Text = "";
            numupPasajeros.Value = 1; //Numeric count 
            cmbMarca.SelectedIndex = 0; //Combo Box
            txtOtros.Text = "";
            rdEstandar.Checked = true;
            chkDefensa.Checked = false;
            chkPuertas.Checked = false;
            chkTrasera.Checked = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string numSerie = txtNumSerie.Text;//Asignación de string con el campo escrito en el textbox txtNumSerie
            string nomAuto = txtNomAuto.Text; //Asignamos nombre ingresado
            string marcaAuto = cmbMarca.Text;//Asignamos marca seleccionada convirtiendo a string
            string propietario = txtPropietario.Text; //Asignamos el nombre del propietario
            bool VerificaVacio()  //METODO QUE VALIDE VACIOS
            {
                bool retorno = false;
   
                //Control de mensajes cuando un campo este vacío o numero de serie exista
                if (admAuto.ExisteNumSerie(numSerie)) //Comparamos si existe y tiene contenido con metodos de administra auto
                {
                    retorno = true;
                    MessageBox.Show("El numero de Serie ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumSerie.Focus();
                }
                if (admAuto.CampoVacio(nomAuto) || admAuto.CampoVacio(numSerie) || admAuto.CampoVacio(marcaAuto) || admAuto.CampoVacio(propietario))
                {
                    retorno = true;
                    MessageBox.Show("Existen campos vacíos, ingrese datos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNomAuto.Focus();
                }
 
                return retorno;
            }//Metodo
            if (!VerificaVacio())
            {    
                byte numPasajeros = Convert.ToByte(numupPasajeros.Value);//Asignamos y convertimos a byte el numero de pasajeros, rangos seleccionados en forms
                bool transEstandar = rdEstandar.Checked; //Obtenemos si es estandar o automatico
                string descripcion = txtOtros.Text;//Descripcion agregada
                descripcion += chkDefensa.Checked ? "\n" + "DEFENSA" : "";
                descripcion += chkPuertas.Checked ? "\n" + "PUERTAS" : "";
                descripcion += chkTrasera.Checked ? "\n" + "TRASERA" : "";
                admAuto.AgregarAuto(numSerie, nomAuto, marcaAuto, numPasajeros, transEstandar, descripcion, propietario);//Agregamos mediante la referencia de administra
                MessageBox.Show("Auto agregado", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
           frmConsultaAuto consultaAuto = new frmConsultaAuto(admAuto);//CREAMOS PARA ENLAZAR VENTANA
           consultaAuto.ShowDialog(); //LLAMAMOS A LA VENTANA MEDIANTE ELBOTON
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        //VALIDACION NUMERO DE SERIE
        private void txtNumSerie_Validating(object sender, CancelEventArgs e)
        {
            //Validar con evento validating si el usuario ingresa un dato no numerico en el numero de serie
            string dato = txtNumSerie.Text;//Obtenemos el numero de serie
            int datoInt = 0;
            try
            {
                datoInt = Convert.ToInt32(dato);
            }
            catch(Exception)
            {
                e.Cancel = true;
                txtNumSerie.SelectAll();
                //poner error provider
                errorP.SetError(txtNumSerie, "Error, ingrese un dato numerico.");
            }
        }
        private void txtNumSerie_Validated(object sender, EventArgs e)
        {
            errorP.Clear();//Validate para limpiar si hay error
        }

        private void txtNomAuto_KeyPress(object sender, KeyPressEventArgs e) //KeyPress de Nombre de Auto
        {
            //Validar no numeros en nombre
            if(!(char.IsControl(e.KeyChar)) && (char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        //VALIDACION NOMBRE VACIO 
        private void txtNomAuto_Validating(object sender, CancelEventArgs e)
        {
            //Validaremos que el campo de textbox no este vacío
            string campo = txtNomAuto.Text;
            if (string.IsNullOrEmpty(campo))
            {
                e.Cancel = true;
                txtNomAuto.SelectAll();
                errorP.SetError(txtNomAuto, "Error el campo de nombre está vacío");
            }
        }
        private void txtNomAuto_Validated(object sender, EventArgs e)
        {
            errorP.Clear();
        }
        //VALIDACION COMBOBOX DE MARCA PREGUNTAR         
        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)//Componente marca
        {}
        private void cmbMarca_Validating(object sender, CancelEventArgs e)
        {
            string dato = cmbMarca.Text;
            if (cmbMarca.SelectedIndex < 0) //El index del primer elemento es 0 por lo que si es menor a cero marcara error.
            {
                e.Cancel = true;
                cmbMarca.SelectAll();
                errorP.SetError(cmbMarca, "Error, seleccione un elemento");
            }
        }
        private void cmbMarca_Validated(object sender, EventArgs e)
        {
            errorP.Clear();
        }
        //VALIDACION TEXTBOX DE PROPIETARIO 
        private void txtPropietario_Validating(object sender, CancelEventArgs e)
        {
            //Validaremos que el campo de textbox no este vacío
            string campo = txtPropietario.Text;
            if (string.IsNullOrEmpty(campo))
            {
                e.Cancel = true;
                txtPropietario.SelectAll();
                errorP.SetError(txtPropietario, "Error el campo de nombre está vacío");
            }
        }
        private void txtPropietario_Validated(object sender, EventArgs e)
        {
            errorP.Clear();
        }
        //Cerrar el formulario a cerrarse en caso de que haya activo en validación.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel=false;
        }
    }
}

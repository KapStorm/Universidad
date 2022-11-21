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
    public partial class Form1 : Form
    {
        Administrador adm;
        public Form1(Administrador adm)
        {
            InitializeComponent();
            Limpiar();
            this.adm = adm;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string NumSerie = txtNumSerie.Text;
           if (adm.BuscaNumSerie(NumSerie))//Utilizamos el metodo para validar que no exista el numSerie
            {
                MessageBox.Show("Numero de Serie repetido", "ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);//Mandamos el mensaje de error
                txtNumSerie.Focus();
            }
            else
            {
                string Nombre = txtNombre.Text;
                if (String.IsNullOrWhiteSpace(txtNombre.Text))//Validamos que no sea vacio o nulo
                {
                    MessageBox.Show("Porfavor, Ingrese un nombre", "ADVERTENCIA", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);//Mandamos el mensaje de advertencia
                    txtNombre.Focus();
                }
                else
                {
                    string Marca = cmbMarca.SelectedItem.ToString();
                    byte NumPasajeros = Convert.ToByte(nudPasajeros.Value);
                    string Transmision;
                    Transmision = rdEstandar.Checked ? "ESTANDAR" : "AUTOMATICO";
                    string Detalle="";
                    Detalle += chkDefensa.Checked ? "DEFENSA " : "";
                    Detalle += chkPuertas.Checked ? "\nPUERTAS " : "";
                    Detalle += chkTrasera.Checked ? "\nTRASERA \n" : "";
                    Detalle +=  txtOtros.Text ;
                    
                    adm.AgregaCarro(NumSerie, Nombre, Marca, NumPasajeros, Transmision,Detalle);//Utilizamos el metodo para agregar con los valores obtenidos
                    MessageBox.Show("Auto agregado con exito!", "INFORMACION", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);//Mandamos mensaje de confirmacion
                    Limpiar();//Utilizamos el metodo limpiar para quitar los datos puestos
                }
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();//Mandamos llamar al metodo limpiar
            
        }
        public void Limpiar()//Este metodo pone todos los valores por defecto y vacios
        {
            txtNombre.Text = "";
            txtNumSerie.Text = "";
            cmbMarca.SelectedIndex = 0;
            nudPasajeros.Value = 1;
            chkDefensa.Checked = false;
            chkPuertas.Checked = false;
            chkTrasera.Checked = false;
            txtOtros.Text = "";
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsulta consultaCarro = new frmConsulta(adm);
            consultaCarro.ShowDialog();//Mostramos la ventana de consultas
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();//Utilizamos el metodo para salir de la ventana
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
        private void txtNumSerie_Validating(object sender, CancelEventArgs e)
        {
            string dato = txtNumSerie.Text;
            int conversion = 0;
            try
            {
                conversion = Convert.ToInt32(dato);
                if (dato.Length != 8)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                e.Cancel = true;
                txtNumSerie.SelectAll();
                errorP.SetError(txtNumSerie, "ERROR: Ingrese un valor numerico de 8 digitos");
            }
        }
        private void txtNumSerie_Validated(object sender, EventArgs e)
        {
            errorP.Clear();
        }

        //Evitar ingresar teclas en combobox
        private void cmbMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtNumSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsControl(e.KeyChar)) && (char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}

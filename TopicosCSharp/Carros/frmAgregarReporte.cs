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
    public partial class frmAgregarReporte : Form
    {
        Administrador adm;
        AdministraCatalogoServicio admCat;
        AdministraReporte admRep;
        public frmAgregarReporte(Administrador adm,AdministraCatalogoServicio admCat,AdministraReporte admRep)
        {
            InitializeComponent();
            this.adm = adm;
            this.admCat = admCat;
            this.admRep = admRep;
        }

        private void frmAgregarReporte_Load(object sender, EventArgs e)
        {
            List<string> numSerie = adm.RegresaNumSerie();
            List<string> clave = admCat.RegresaClave();
            cmbNumSerie.DataSource = numSerie;
            cmbClave.DataSource = clave;
            txtFolio.Focus();
        }

        private void cmbNumSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            string numeroSerie = cmbNumSerie.SelectedItem.ToString();
            Carro auto = adm.RegresaAuto(numeroSerie);
            txtNombre.Text = auto.pNombre;
            txtMarca.Text = auto.pMarca;
        }

        private void cmbClave_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clave = cmbClave.SelectedItem.ToString();
            CatalogoServicio cat = admCat.RegresaCatalogo(clave);
            txtNombreCat.Text = cat.pNombreServicio;
            txtCosto.Text = cat.pCosto.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string folio = txtFolio.Text;
            if (String.IsNullOrEmpty(folio))
            {
                MessageBox.Show("Ingrese un folio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (admRep.BuscaFolio(folio))
            {
                MessageBox.Show("El folio ya existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string numSerie = cmbNumSerie.SelectedItem.ToString();
                string auto = cmbNumSerie.Text;

                string clave = cmbClave.SelectedItem.ToString();
                string servicio = cmbClave.Text;

                DateTime fecha = dtFecha.Value;

                admRep.AgregarReporte(folio, auto, servicio, fecha);
                MessageBox.Show("Registro realizado con exito!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
        }
        private void Limpiar()
        {
            txtFolio.Text = "";
            dtFecha.Text = DateTime.Now.ToString();
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbNumSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtFolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsControl(e.KeyChar)) && (char.IsLetter(e.KeyChar)))
            {
                e.Handled= true;
            }
        }

        private void txtFolio_Validating(object sender, CancelEventArgs e)
        {
            int conversion = 0;
            string dato = txtFolio.Text;
            try
            {
                conversion = Convert.ToInt32(txtFolio.Text);
                if ( dato.Length!= 5)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                e.Cancel = true;
                txtFolio.SelectAll();
                errorP.SetError(txtFolio,"ERROR: Ingrese un valor numerico de 5 digitos");
            }
        }
        //Validacion fecha
        private void dtFecha_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (dtFecha.Value.Date < DateTime.Now)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                e.Cancel = true;
                dtFecha.Select();
                errorP.SetError(dtFecha, "Ingrese una fecha proxima");
            }
        }
        private void dtFecha_Validated(object sender, EventArgs e)
        {
            errorP.Clear();
        }

        private void txtFolio_Validated(object sender, EventArgs e)
        {
            errorP.Clear();
        }
    }
}

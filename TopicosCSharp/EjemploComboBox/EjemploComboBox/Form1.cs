using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elementoSel = cmbLenguajes.SelectedItem.ToString();
            int indexSel = cmbLenguajes.SelectedIndex;

            lblAgregar.Text = elementoSel;
            lblPosicion.Text = indexSel.ToString();
        }
    }
}

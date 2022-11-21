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
    public partial class frmAcercade : Form
    {
        public frmAcercade()
        {
            InitializeComponent();
        }
        int a;
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            switch (a)
            {
                case 1:
                    picFotografia.Image = Properties.Resources.Daniel1;
                    a += 1;
                    lblNombres.Text = "CASTRO CRUZ\nLUIS DANIEL";
                    lblNumeroControl.Text = "20170627";
                    lblFrase.Text = "Vale mas un buen dia\nque aprobar una materia";
                    break;
                case 2:
                    picFotografia.Image = Properties.Resources.Ryan1;
                    a+=1;
                    lblNombres.Text = "FELIX FIERRO\nRYAN GUADALUPE";
                    lblNumeroControl.Text = "20170657";
                    lblFrase.Text = "Nose que poner";
                    break;
                case 3:
                    picFotografia.Image = Properties.Resources.Diego1;
                    a = 1;
                    lblNombres.Text = "LOPEZ CAMACHO\nDIEGO ARMANDO";
                    lblNumeroControl.Text = "20170627";
                    lblFrase.Text = "Este parcial es el bueno";
                    break;
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            switch (a)
            {
                case 1:
                    picFotografia.Image = Properties.Resources.Daniel1;
                    a += 1;
                    lblNombres.Text = "CASTRO CRUZ\nLUIS DANIEL";
                    lblNumeroControl.Text = "20170627";
                    lblFrase.Text = "Vale mas un buen dia\nque aprobar una materia";
                    break;
                case 2:
                    picFotografia.Image = Properties.Resources.Diego1;
                    a += 1;
                    lblNombres.Text = "LOPEZ CAMACHO\nDIEGO ARMANDO";
                    lblNumeroControl.Text = "20170627";
                    lblFrase.Text = "Este parcial es el bueno";
                    break;
                case 3:
                    picFotografia.Image = Properties.Resources.Ryan1;
                    a = 1;
                    lblNombres.Text = "FELIX FIERRO\nRYAN GUADALUPE";
                    lblNumeroControl.Text = "20170657";
                    lblFrase.Text = "Nose que poner";
                    break;
            }
        }
        private void frmAcercade_Load(object sender, EventArgs e)
        {
            a = 1;
        }
    }
}

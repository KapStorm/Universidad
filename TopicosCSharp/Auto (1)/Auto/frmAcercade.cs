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
    public partial class frmAcercade : Form
    {
        public frmAcercade()
        {
            InitializeComponent();
        }

        private void btnFrase_Click(object sender, EventArgs e)
        {
            lblDes.Visible = true;
            lblVideo.Visible = true;
            lblLeer.Visible = true;
        }

        private void btnFAlan_Click(object sender, EventArgs e)
        {
            lblFall.Visible = true;
            lblFlow.Visible = true;
            lblFut.Visible = true;
        }

        private void btnFAme_Click(object sender, EventArgs e)
        {
            lblBailar.Visible = true;
            lblSeria.Visible = true;
            lblPasion.Visible = true;
        }
    }
}

using System;
using PDF;
using System.Windows.Forms;
using iText.Layout;

namespace UsandoLibreriaPDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGeneraPDF_Click(object sender, EventArgs e)
        {
            Document document = Class1.CreatePDF("PDFdos.pdf");

            document = Class1.EncabezadoPDF(document, "SISTEMA DE PRUEBA", "REPORTE 1");

            document.Close();
        }
    }
}

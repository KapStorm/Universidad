using Choferes.Negocio;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Layout;
using iText.Layout.Element;
using LibreriaPDF;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Choferes.Front
{
    public partial class FrmReporteChoferesDisponible : Form
    {
        DataTable tabla;

        public FrmReporteChoferesDisponible()
        {
            InitializeComponent();
        }

        private void FrmReporteChoferesDisponible_Load(object sender, EventArgs e)
        {
            try
            {
                tabla = NChofer.ObtenerChoferesDisponible();
                dgvChoferes.DataSource = tabla;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Imposible consultar con los datos");

                foreach (SqlError err in ex.Errors)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                string fecha = DateTime.Now.ToString("dd-MM-yyyy");
                Document documento = Utility.CreatePDF($"Choferes Disponbiles {fecha}.pdf");
                documento = Utility.EncabezadoPDF(documento, "Choferes disponbles", $"Fecha {fecha}");

                string[] columnas = { "NOMBRES", "APELLIDOS", "NUM LICENCIA" };
                float[] tamanio = { 20, 20, 20 };

                Table tablaPdf = Utility.EncabezadoTabla(columnas, tamanio);
                PdfFont fontNormal = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

                foreach (DataRow row in tabla.Rows)
                {
                    Paragraph p = new Paragraph(row.Field<string>("NOMBRES")).SetFont(fontNormal);
                    tablaPdf.AddCell(new Cell().Add(p));
                    p = new Paragraph(row.Field<string>("APELLIDOS")).SetFont(fontNormal);
                    tablaPdf.AddCell(new Cell().Add(p));
                    p = new Paragraph(row.Field<string>("NUM LICENCIA")).SetFont(fontNormal);
                    tablaPdf.AddCell(new Cell().Add(p));
                }

                documento.Add(tablaPdf);
                documento.Close();

                MessageBox.Show("PDF Creado", "Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

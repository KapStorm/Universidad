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
    public partial class FrmReportesVisitas : Form
    {
        DataTable tabla;

        public FrmReportesVisitas()
        {
            InitializeComponent();
        }

        private void FrmReportesVisitas_Load(object sender, System.EventArgs e)
        {
            try
            {
                cmbClaves.DataSource = NVisita.ObtenerClaveVisitas();
                cmbClaves.DisplayMember = "CLAVE";
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

        private void cmbClaves_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            try
            {
                string claveStr = cmbClaves.GetItemText(cmbClaves.SelectedItem);
                int clave = Convert.ToInt32(claveStr);
                tabla = NVisitaVisitante.ObtenerDatos(clave);
                dgvVisitas.DataSource = tabla;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Imposible consultar con los datos");

                foreach (SqlError err in ex.Errors)
                {
                    MessageBox.Show(err.Message);
                }
            }
            catch (Exception) { }
        }

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                string clave = cmbClaves.GetItemText(cmbClaves.SelectedItem);
                Document documento = Utility.CreatePDF($"Reporte de la visita {clave}.pdf");
                documento = Utility.EncabezadoPDF(documento, $"Reporte por visita", $"Visita {clave}");

                string[] columnas = { "NOMBRES", "APELLIDOS" };
                float[] tamanio = { 20, 20 };

                Table tablaPdf = Utility.EncabezadoTabla(columnas, tamanio);
                PdfFont fontNormal = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

                foreach (DataRow row in tabla.Rows)
                {
                    Paragraph p = new Paragraph(row.Field<string>("NOMBRE")).SetFont(fontNormal);
                    tablaPdf.AddCell(new Cell().Add(p));
                    p = new Paragraph(row.Field<string>("APELLIDOS")).SetFont(fontNormal);
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

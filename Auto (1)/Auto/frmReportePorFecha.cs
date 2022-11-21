using System;
using System.Collections.Generic;
using System.Windows.Forms;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Layout;
using iText.Layout.Element;
using LibreriaPDF;

namespace Auto
{
    public partial class frmReportePorFecha : Form
    {
        private AdmAutoServicio admAutoServicio;
        private AdmAuto admAuto;
        private AdmServicio admServicio;

        public frmReportePorFecha(AdmAutoServicio admAutoServicio, AdmAuto admAuto, AdmServicio admServicio)
        {
            InitializeComponent();
            this.admAutoServicio = admAutoServicio;
            this.admAuto = admAuto;
            this.admServicio = admServicio;
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            CambioDeFecha();
        }

        private void CambioDeFecha()
        {
            List<AutoServicio> lista = admAutoServicio.ListaServicio();
            List<string> folios = admAutoServicio.ListaClv();

            string fecha = dtpFecha.Value.ToString("yyyy-MM-dd");
            dgvReporte.Rows.Clear();

            for (int i = 0; i < folios.Count; i++)
            {
                Auto auto = admAuto.GetAuto(lista[i].pNumeroAuto);
                Servicio servicio = admServicio.ObtenerServicio(lista[i].pClaveServicio);

                if (lista[i].pFecha.ToString("yyyy-MM-dd") == fecha)
                {
                    dgvReporte.Rows.Add(folios[i], auto.pnombre, servicio.pNombre, servicio.pCosto - lista[i].pDescuento);
                }
            }
        }

        private void frmReportePorFecha_Load(object sender, EventArgs e)
        {
            CambioDeFecha();
        }

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            string fecha = dtpFecha.Value.ToString("yyyy-MM-dd");
            Document document = Utility.CreatePDF($"Reporte del dia {fecha}.pdf");
            document = Utility.EncabezadoPDF(document, $"Reporte por fecha", fecha);

            string[] columnas = { "Folio", "Nombre del auto", "Descripción del servicio", "Costo" };
            float[] tamanio = { 20, 20, 20, 20 };

            Table tabla = Utility.EncabezadoTabla(columnas, tamanio);

            List<AutoServicio> lista = admAutoServicio.ListaServicio();
            List<string> folios = admAutoServicio.ListaClv();
            PdfFont fontNormal = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            for (int i = 0; i < folios.Count; i++)
            {
                Auto auto = admAuto.GetAuto(lista[i].pNumeroAuto);
                Servicio servicio = admServicio.ObtenerServicio(lista[i].pClaveServicio);

                if (lista[i].pFecha.ToString("yyyy-MM-dd") == fecha)
                {
                    Paragraph p = new Paragraph(folios[i]).SetFont(fontNormal);
                    tabla.AddCell(new Cell().Add(p));
                    p = new Paragraph(auto.pnombre).SetFont(fontNormal);
                    tabla.AddCell(new Cell().Add(p));
                    p = new Paragraph(servicio.pNombre).SetFont(fontNormal);
                    tabla.AddCell(new Cell().Add(p));
                    p = new Paragraph(servicio.pCosto.ToString()).SetFont(fontNormal);
                    tabla.AddCell(new Cell().Add(p));
                }
            }

            document.Add(tabla);
            document.Close();

            MessageBox.Show("PDF Generado");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using BibliotecaUsoPDF;
using System.Windows.Forms;

namespace Carros
{
    public partial class frmConsultaReporteGeneral : Form
    {
        AdministraReporte admRep;
        Administrador adm;
        AdministraCatalogoServicio admCat;
        public frmConsultaReporteGeneral(AdministraReporte admRep,Administrador adm,AdministraCatalogoServicio admCat)
        {
            InitializeComponent();
            this.admRep = admRep;
            this.adm = adm;
            this.admCat = admCat;
        }

        private void frmConsultaReporteGeneral_Load(object sender, EventArgs e)
        {
            List<Reporte> listaReporte = admRep.RegresaListaServicios();
            for (int i = 0; i < listaReporte.Count; i++)
            {
                dgvReportes.Rows.Add(listaReporte.ElementAt(i).pfolio, listaReporte.ElementAt(i).pNumSerie,
                    adm.RegresaAuto(listaReporte.ElementAt(i).pNumSerie).pNombre, listaReporte.ElementAt(i).pClaveServ,
                    admCat.RegresaCatalogo(listaReporte.ElementAt(i).pClaveServ).pNombreServicio,
                    listaReporte.ElementAt(i).pFecha.ToShortDateString());
            }
        }

        private void btnGeneraPDF_Click(object sender, EventArgs e)
        {
            PdfFont fontNormal = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            Document documento = Utility.CreatePDF("ReporteServicioGen1.pdf");

            documento = Utility.EncabezadoPDF(documento, "SERVICIO AUTOS", "Reporte Servicios");
            string[] columnas = { "FOLIO", "NUMERO SERIE", "NOMBRE AUTO","CLAVE","NOMRE SERVICIO","FECHA"};
            float[] tam = { 20,20,40,20,40,30};

            Table tabla = Utility.EncabezadoTabla(columnas, tam);

            List<Reporte> listaReporte = admRep.RegresaListaServicios();
            for (int i = 0; i < listaReporte.Count; i++)
            {
                Paragraph p = new Paragraph(listaReporte.ElementAt(i).pfolio).SetFont(fontNormal);
                tabla.AddCell(new Cell().Add(p));
                p = new Paragraph(listaReporte.ElementAt(i).pNumSerie).SetFont(fontNormal);
                tabla.AddCell(new Cell().Add(p));
                p = new Paragraph(adm.RegresaAuto(listaReporte.ElementAt(i).pNumSerie).pNombre).SetFont(fontNormal);
                tabla.AddCell(new Cell().Add(p));
                p = new Paragraph(listaReporte.ElementAt(i).pClaveServ).SetFont(fontNormal);
                tabla.AddCell(new Cell().Add(p));
                p = new Paragraph(admCat.RegresaCatalogo(listaReporte.ElementAt(i).pClaveServ).pNombreServicio).SetFont(fontNormal);
                tabla.AddCell(new Cell().Add(p));
                p = new Paragraph(listaReporte.ElementAt(i).pFecha.Date.ToString()).SetFont(fontNormal);
                tabla.AddCell(new Cell().Add(p));
            }
            documento.Add(tabla);
            documento.Close();
            MessageBox.Show("PDF GENERADO CON EXITO", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

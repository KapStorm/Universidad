using iText.Layout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaPDF;
using iText.Layout.Element;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Auto
{
    public partial class frmConsultaTodosAutoServicio : Form
    {
        AdmServicio admS;
        AdmAuto admAuto;
        AdmAutoServicio admAutoServicio;
        public frmConsultaTodosAutoServicio(AdmServicio admS, AdmAuto admA, AdmAutoServicio admAs )
        {
            InitializeComponent();
            this.admS = admS;
            this.admAuto = admA;
            this.admAutoServicio = admAs;
        }

        private void frmConsultaTodosAutoServicio_Load(object sender, EventArgs e)
        {
            dgvAutoServicio.Rows.Clear();

            List<AutoServicio> listaServicios = admAutoServicio.ListaServicio();
            List<string> listaServiciosFolio = admAutoServicio.ListaClv();

            for (int i = 0; i < listaServicios.Count; i++)
            {
                    Auto auto = admAuto.GetAuto(listaServicios[i].pNumeroAuto);
                    Servicio servicio = admS.ObtenerServicio(listaServicios[i].pClaveServicio);
                    dgvAutoServicio.Rows.Add(listaServiciosFolio[i], listaServicios[i].pNumeroAuto, auto.pnombre, listaServicios[i].pClaveServicio, servicio.pNombre, listaServicios[i].pFecha.ToString("yyyy-MM-dd"), servicio.pCosto - listaServicios[i].pDescuento);
            }

        }

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            Document document = Utility.CreatePDF("Reporte servicios autos.pdf");
            document = Utility.EncabezadoPDF(document, "Reporte servicio autos", "Todos");

            string[] columnas = { "Folio", "Numero Serie", "Nombre Auto", "Cve Servicio", "Nombre Servicio", "Fecha", "Costo" };
            float[] tamanio = { 20, 20, 20, 20, 20, 20, 20 };

            Table tabla = Utility.EncabezadoTabla(columnas, tamanio);
            PdfFont fontNormal = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            List<AutoServicio> listaServicios = admAutoServicio.ListaServicio();
            List<string> listaServiciosFolio = admAutoServicio.ListaClv();

            for (int i = 0; i < listaServicios.Count; i++)
            {
                Auto auto = admAuto.GetAuto(listaServicios[i].pNumeroAuto);
                Servicio servicio = admS.ObtenerServicio(listaServicios[i].pClaveServicio);

                Paragraph p = new Paragraph(listaServiciosFolio[i]).SetFont(fontNormal);
                tabla.AddCell(new Cell().Add(p));
                p = new Paragraph(listaServicios[i].pNumeroAuto).SetFont(fontNormal);
                tabla.AddCell(new Cell().Add(p));
                p = new Paragraph(auto.pnombre).SetFont(fontNormal);
                tabla.AddCell(new Cell().Add(p));
                p = new Paragraph(listaServicios[i].pClaveServicio).SetFont(fontNormal);
                tabla.AddCell(new Cell().Add(p));
                p = new Paragraph(servicio.pNombre).SetFont(fontNormal);
                tabla.AddCell(new Cell().Add(p));
                p = new Paragraph(listaServicios[i].pFecha.ToString("yyyy-MM-dd")).SetFont(fontNormal);
                tabla.AddCell(new Cell().Add(p));
                p = new Paragraph((servicio.pCosto - listaServicios[i].pDescuento).ToString()).SetFont(fontNormal);
                tabla.AddCell(new Cell().Add(p));
            }

            document.Add(tabla);
            document.Close();

            MessageBox.Show("PDF Generado");
        }
    }
}

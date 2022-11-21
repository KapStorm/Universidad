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
    public partial class frmMostrarServicioAuto : Form
    {
        Administrador adm;
        AdministraCatalogoServicio admCat;
        AdministraReporte admRep;
        public frmMostrarServicioAuto(Administrador adm,AdministraCatalogoServicio admCat,AdministraReporte admRep)
        {
            InitializeComponent();
            this.adm = adm;
            this.admCat = admCat;
            this.admRep = admRep;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMostrarServicioAuto_Load(object sender, EventArgs e)
        {
            List<string> listaNumSerie = adm.RegresaNumSerie();
            cmbNumSerie.DataSource = listaNumSerie;
        }

        private void cmbNumSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cmbNumSerie.Text))
            {
                string numSerie = cmbNumSerie.Text;
                List<Reporte> listaServ = admRep.RegresaListaServicios();
                if (listaServ != null)
                {
                    dgvServicioAuto.Rows.Clear();
                    for (int i = 0; i < listaServ.Count; i++)
                    {
                        if (numSerie.Equals(listaServ.ElementAt(i).pNumSerie))
                        {
                            dgvServicioAuto.Rows.Add(listaServ.ElementAt(i).pfolio, listaServ.ElementAt(i).pNumSerie,
                                adm.RegresaAuto(listaServ.ElementAt(i).pNumSerie).pNombre, listaServ.ElementAt(i).pClaveServ,
                                admCat.RegresaCatalogo(listaServ.ElementAt(i).pClaveServ).pNombreServicio, admRep.RegresaServicio(i).pFecha.Date);
                        }
                    }
                }

            }
        }

        private void cmbNumSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnGeneraPDF_Click(object sender, EventArgs e)
        {
            PdfFont fontNormal = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            Document documento = Utility.CreatePDF("ReporteAutosClave1.PDF");

            documento = Utility.EncabezadoPDF(documento, "SERVICIO AUTOS", "Reporte Servicios Autos Consultados");
            string[] columnas = { "FOLIO", "NUMERO SERIE", "NOMBRE AUTO", "CLAVE", "NOMRE SERVICIO", "FECHA" };
            float[] tam = { 20, 20, 40, 20, 40, 30 };

            Table tabla1 = Utility.EncabezadoTabla(columnas, tam);

            if (!String.IsNullOrEmpty(cmbNumSerie.Text))
            {
                string numSerie = cmbNumSerie.Text;
                List<Reporte> listaReporte = admRep.RegresaListaServicios();
                if (listaReporte != null)
                {
                    dgvServicioAuto.Rows.Clear();
                    for (int i = 0; i < listaReporte.Count; i++)
                    {
                        if (numSerie.Equals(listaReporte.ElementAt(i).pNumSerie))
                        {
                            Paragraph p = new Paragraph(listaReporte.ElementAt(i).pfolio).SetFont(fontNormal);
                            tabla1.AddCell(new Cell().Add(p));
                            p = new Paragraph(listaReporte.ElementAt(i).pNumSerie).SetFont(fontNormal);
                            tabla1.AddCell(new Cell().Add(p));
                            p = new Paragraph(adm.RegresaAuto(listaReporte.ElementAt(i).pNumSerie).pNombre).SetFont(fontNormal);
                            tabla1.AddCell(new Cell().Add(p));
                            p = new Paragraph(listaReporte.ElementAt(i).pClaveServ).SetFont(fontNormal);
                            tabla1.AddCell(new Cell().Add(p));
                            p = new Paragraph(admCat.RegresaCatalogo(listaReporte.ElementAt(i).pClaveServ).pNombreServicio).SetFont(fontNormal);
                            tabla1.AddCell(new Cell().Add(p));
                            p = new Paragraph(listaReporte.ElementAt(i).pFecha.Date.ToString()).SetFont(fontNormal);
                            tabla1.AddCell(new Cell().Add(p));
                        }
                    }
                }
                documento.Add(tabla1);
                documento.Close();
                MessageBox.Show("PDF GENERADO CON EXITO", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}

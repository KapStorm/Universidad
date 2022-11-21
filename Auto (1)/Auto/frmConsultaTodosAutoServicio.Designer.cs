
namespace Auto
{
    partial class frmConsultaTodosAutoServicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAutoServicio = new System.Windows.Forms.DataGridView();
            this.Folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClaveS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerarPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutoServicio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAutoServicio
            // 
            this.dgvAutoServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutoServicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Folio,
            this.NumS,
            this.NomA,
            this.ClaveS,
            this.NombreS,
            this.Fecha,
            this.Descuento});
            this.dgvAutoServicio.Location = new System.Drawing.Point(0, 46);
            this.dgvAutoServicio.Name = "dgvAutoServicio";
            this.dgvAutoServicio.Size = new System.Drawing.Size(801, 364);
            this.dgvAutoServicio.TabIndex = 0;
            // 
            // Folio
            // 
            this.Folio.HeaderText = "Folio";
            this.Folio.Name = "Folio";
            this.Folio.Width = 150;
            // 
            // NumS
            // 
            this.NumS.HeaderText = "Numero de Serie";
            this.NumS.Name = "NumS";
            this.NumS.Width = 150;
            // 
            // NomA
            // 
            this.NomA.HeaderText = "Nombre del Auto";
            this.NomA.Name = "NomA";
            this.NomA.Width = 150;
            // 
            // ClaveS
            // 
            this.ClaveS.HeaderText = "Clave del Servicio";
            this.ClaveS.Name = "ClaveS";
            this.ClaveS.Width = 150;
            // 
            // NombreS
            // 
            this.NombreS.HeaderText = "Nombre del Servicio";
            this.NombreS.Name = "NombreS";
            this.NombreS.Width = 150;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 150;
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Costo";
            this.Descuento.Name = "Descuento";
            this.Descuento.Width = 150;
            // 
            // btnGenerarPDF
            // 
            this.btnGenerarPDF.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerarPDF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGenerarPDF.Location = new System.Drawing.Point(36, 13);
            this.btnGenerarPDF.Name = "btnGenerarPDF";
            this.btnGenerarPDF.Size = new System.Drawing.Size(107, 23);
            this.btnGenerarPDF.TabIndex = 1;
            this.btnGenerarPDF.Text = "Generar PDF";
            this.btnGenerarPDF.UseVisualStyleBackColor = false;
            this.btnGenerarPDF.Click += new System.EventHandler(this.btnGenerarPDF_Click);
            // 
            // frmConsultaTodosAutoServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(801, 410);
            this.Controls.Add(this.btnGenerarPDF);
            this.Controls.Add(this.dgvAutoServicio);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmConsultaTodosAutoServicio";
            this.Text = "Consulta con todos los servicios";
            this.Load += new System.EventHandler(this.frmConsultaTodosAutoServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutoServicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAutoServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaveS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.Button btnGenerarPDF;
    }
}

namespace Auto
{
    partial class frmReporteAutosServicio
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
            this.components = new System.ComponentModel.Container();
            this.dgvConsultaMarca = new System.Windows.Forms.DataGridView();
            this.Folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombAuto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbServicio = new System.Windows.Forms.ComboBox();
            this.txtServicioNombre = new System.Windows.Forms.TextBox();
            this.toolP = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaMarca
            // 
            this.dgvConsultaMarca.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvConsultaMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaMarca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Folio,
            this.NumeroS,
            this.NombAuto,
            this.Fecha,
            this.Precio});
            this.dgvConsultaMarca.Location = new System.Drawing.Point(1, 59);
            this.dgvConsultaMarca.Name = "dgvConsultaMarca";
            this.dgvConsultaMarca.Size = new System.Drawing.Size(660, 392);
            this.dgvConsultaMarca.TabIndex = 0;
            // 
            // Folio
            // 
            this.Folio.HeaderText = "Folio";
            this.Folio.Name = "Folio";
            this.Folio.ReadOnly = true;
            // 
            // NumeroS
            // 
            this.NumeroS.HeaderText = "Numero de Serie";
            this.NumeroS.Name = "NumeroS";
            this.NumeroS.ReadOnly = true;
            this.NumeroS.Width = 150;
            // 
            // NombAuto
            // 
            this.NombAuto.HeaderText = "Nombre Auto";
            this.NombAuto.Name = "NombAuto";
            this.NombAuto.ReadOnly = true;
            this.NombAuto.Width = 150;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 150;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 150;
            // 
            // cmbServicio
            // 
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Location = new System.Drawing.Point(12, 12);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Size = new System.Drawing.Size(121, 21);
            this.cmbServicio.TabIndex = 1;
            this.toolP.SetToolTip(this.cmbServicio, "Seleccione una marca");
            this.cmbServicio.SelectedIndexChanged += new System.EventHandler(this.cmbServicio_SelectedIndexChanged);
            // 
            // txtServicioNombre
            // 
            this.txtServicioNombre.Location = new System.Drawing.Point(178, 12);
            this.txtServicioNombre.MaxLength = 100;
            this.txtServicioNombre.Name = "txtServicioNombre";
            this.txtServicioNombre.ReadOnly = true;
            this.txtServicioNombre.Size = new System.Drawing.Size(122, 20);
            this.txtServicioNombre.TabIndex = 2;
            this.toolP.SetToolTip(this.txtServicioNombre, "Nombre ");
            // 
            // frmReporteAutosMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 451);
            this.Controls.Add(this.txtServicioNombre);
            this.Controls.Add(this.cmbServicio);
            this.Controls.Add(this.dgvConsultaMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmReporteAutosMarca";
            this.Text = "Reporte de autos por folio";
            this.Load += new System.EventHandler(this.frmReporteAutosMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaMarca;
        private System.Windows.Forms.ComboBox cmbServicio;
        private System.Windows.Forms.TextBox txtServicioNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombAuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.ToolTip toolP;
    }
}
namespace Choferes.Front
{
    partial class FrmReportesVisitas
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
            this.btnGenerarPDF = new System.Windows.Forms.Button();
            this.cmbClaves = new System.Windows.Forms.ComboBox();
            this.dgvVisitas = new System.Windows.Forms.DataGridView();
            this.lblClaves = new System.Windows.Forms.Label();
            this.lblReporte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerarPDF
            // 
            this.btnGenerarPDF.Location = new System.Drawing.Point(157, 295);
            this.btnGenerarPDF.Name = "btnGenerarPDF";
            this.btnGenerarPDF.Size = new System.Drawing.Size(106, 23);
            this.btnGenerarPDF.TabIndex = 0;
            this.btnGenerarPDF.Text = "Generar PDF";
            this.btnGenerarPDF.UseVisualStyleBackColor = true;
            this.btnGenerarPDF.Click += new System.EventHandler(this.btnGenerarPDF_Click);
            // 
            // cmbClaves
            // 
            this.cmbClaves.FormattingEnabled = true;
            this.cmbClaves.Location = new System.Drawing.Point(178, 74);
            this.cmbClaves.Name = "cmbClaves";
            this.cmbClaves.Size = new System.Drawing.Size(121, 21);
            this.cmbClaves.TabIndex = 1;
            this.cmbClaves.SelectedIndexChanged += new System.EventHandler(this.cmbClaves_SelectedIndexChanged);
            // 
            // dgvVisitas
            // 
            this.dgvVisitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisitas.Location = new System.Drawing.Point(21, 130);
            this.dgvVisitas.Name = "dgvVisitas";
            this.dgvVisitas.Size = new System.Drawing.Size(381, 150);
            this.dgvVisitas.TabIndex = 2;
            // 
            // lblClaves
            // 
            this.lblClaves.AutoSize = true;
            this.lblClaves.Location = new System.Drawing.Point(119, 77);
            this.lblClaves.Name = "lblClaves";
            this.lblClaves.Size = new System.Drawing.Size(39, 13);
            this.lblClaves.TabIndex = 3;
            this.lblClaves.Text = "Claves";
            // 
            // lblReporte
            // 
            this.lblReporte.AutoSize = true;
            this.lblReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporte.Location = new System.Drawing.Point(93, 21);
            this.lblReporte.Name = "lblReporte";
            this.lblReporte.Size = new System.Drawing.Size(206, 25);
            this.lblReporte.TabIndex = 4;
            this.lblReporte.Text = "Reporte de Visitas";
            // 
            // FrmReportesVisitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 330);
            this.Controls.Add(this.lblReporte);
            this.Controls.Add(this.lblClaves);
            this.Controls.Add(this.dgvVisitas);
            this.Controls.Add(this.cmbClaves);
            this.Controls.Add(this.btnGenerarPDF);
            this.Name = "FrmReportesVisitas";
            this.Text = "Reporte de Visitas";
            this.Load += new System.EventHandler(this.FrmReportesVisitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarPDF;
        private System.Windows.Forms.ComboBox cmbClaves;
        private System.Windows.Forms.DataGridView dgvVisitas;
        private System.Windows.Forms.Label lblClaves;
        private System.Windows.Forms.Label lblReporte;
    }
}
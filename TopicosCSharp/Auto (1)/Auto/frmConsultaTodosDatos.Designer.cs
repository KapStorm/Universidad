namespace Auto
{
    partial class frmConsultaTodosDatos
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
            this.dgvAutos = new System.Windows.Forms.DataGridView();
            this.NumSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomAuto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Propietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroPasajeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transmisión = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAutos
            // 
            this.dgvAutos.AllowUserToAddRows = false;
            this.dgvAutos.AllowUserToDeleteRows = false;
            this.dgvAutos.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumSerie,
            this.NomAuto,
            this.Marca,
            this.Propietario,
            this.NumeroPasajeros,
            this.Detalles,
            this.Transmisión});
            this.dgvAutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAutos.Location = new System.Drawing.Point(0, 0);
            this.dgvAutos.Name = "dgvAutos";
            this.dgvAutos.ReadOnly = true;
            this.dgvAutos.Size = new System.Drawing.Size(732, 366);
            this.dgvAutos.TabIndex = 0;
            this.dgvAutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAutos_CellContentClick);
            // 
            // NumSerie
            // 
            this.NumSerie.HeaderText = "Numero de Serie";
            this.NumSerie.Name = "NumSerie";
            this.NumSerie.ReadOnly = true;
            // 
            // NomAuto
            // 
            this.NomAuto.HeaderText = "Nombre del auto";
            this.NomAuto.Name = "NomAuto";
            this.NomAuto.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Propietario
            // 
            this.Propietario.HeaderText = "Propietario";
            this.Propietario.Name = "Propietario";
            this.Propietario.ReadOnly = true;
            // 
            // NumeroPasajeros
            // 
            this.NumeroPasajeros.HeaderText = "Numero Maximo de Pasajeros";
            this.NumeroPasajeros.Name = "NumeroPasajeros";
            this.NumeroPasajeros.ReadOnly = true;
            // 
            // Detalles
            // 
            this.Detalles.HeaderText = "Detalles";
            this.Detalles.Name = "Detalles";
            this.Detalles.ReadOnly = true;
            // 
            // Transmisión
            // 
            this.Transmisión.HeaderText = "Tipo de Transmisión";
            this.Transmisión.Name = "Transmisión";
            this.Transmisión.ReadOnly = true;
            // 
            // frmConsultaTodosDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 366);
            this.Controls.Add(this.dgvAutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaTodosDatos";
            this.Text = "Consulta de todos los autos";
            this.Load += new System.EventHandler(this.frmConsultaTodosDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomAuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Propietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroPasajeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transmisión;
    }
}
namespace Choferes.Front
{
    partial class FrmAgregarVisitanteAVisita
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
            this.cmbClaveVisita = new System.Windows.Forms.ComboBox();
            this.cmbClaveVisitante = new System.Windows.Forms.ComboBox();
            this.dgvVisita = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblAgregar = new System.Windows.Forms.Label();
            this.lblVisita = new System.Windows.Forms.Label();
            this.lblVisitante = new System.Windows.Forms.Label();
            this.txtNombreVisitante = new System.Windows.Forms.TextBox();
            this.toolP = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisita)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbClaveVisita
            // 
            this.cmbClaveVisita.FormattingEnabled = true;
            this.cmbClaveVisita.Location = new System.Drawing.Point(68, 83);
            this.cmbClaveVisita.Name = "cmbClaveVisita";
            this.cmbClaveVisita.Size = new System.Drawing.Size(121, 21);
            this.cmbClaveVisita.TabIndex = 0;
            this.toolP.SetToolTip(this.cmbClaveVisita, "Clave de la visita");
            this.cmbClaveVisita.SelectedIndexChanged += new System.EventHandler(this.cmbClaveVisita_SelectedIndexChanged);
            // 
            // cmbClaveVisitante
            // 
            this.cmbClaveVisitante.FormattingEnabled = true;
            this.cmbClaveVisitante.Location = new System.Drawing.Point(286, 83);
            this.cmbClaveVisitante.Name = "cmbClaveVisitante";
            this.cmbClaveVisitante.Size = new System.Drawing.Size(121, 21);
            this.cmbClaveVisitante.TabIndex = 1;
            this.toolP.SetToolTip(this.cmbClaveVisitante, "Clave del visitante");
            this.cmbClaveVisitante.SelectedIndexChanged += new System.EventHandler(this.cmbClaveVisitante_SelectedIndexChanged);
            // 
            // dgvVisita
            // 
            this.dgvVisita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisita.Location = new System.Drawing.Point(54, 163);
            this.dgvVisita.Name = "dgvVisita";
            this.dgvVisita.ReadOnly = true;
            this.dgvVisita.Size = new System.Drawing.Size(377, 150);
            this.dgvVisita.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(189, 134);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.toolP.SetToolTip(this.btnAgregar, "Agregar visitante");
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblAgregar
            // 
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregar.Location = new System.Drawing.Point(86, 20);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(280, 25);
            this.lblAgregar.TabIndex = 9;
            this.lblAgregar.Text = "Agregar Visitante a Visita";
            // 
            // lblVisita
            // 
            this.lblVisita.AutoSize = true;
            this.lblVisita.Location = new System.Drawing.Point(68, 64);
            this.lblVisita.Name = "lblVisita";
            this.lblVisita.Size = new System.Drawing.Size(62, 13);
            this.lblVisita.TabIndex = 10;
            this.lblVisita.Text = "Clave Visita";
            // 
            // lblVisitante
            // 
            this.lblVisitante.AutoSize = true;
            this.lblVisitante.Location = new System.Drawing.Point(286, 63);
            this.lblVisitante.Name = "lblVisitante";
            this.lblVisitante.Size = new System.Drawing.Size(77, 13);
            this.lblVisitante.TabIndex = 11;
            this.lblVisitante.Text = "Clave Visitante";
            // 
            // txtNombreVisitante
            // 
            this.txtNombreVisitante.Location = new System.Drawing.Point(286, 110);
            this.txtNombreVisitante.Name = "txtNombreVisitante";
            this.txtNombreVisitante.ReadOnly = true;
            this.txtNombreVisitante.Size = new System.Drawing.Size(188, 20);
            this.txtNombreVisitante.TabIndex = 12;
            // 
            // FrmAgregarVisitanteAVisita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 322);
            this.Controls.Add(this.txtNombreVisitante);
            this.Controls.Add(this.lblVisitante);
            this.Controls.Add(this.lblVisita);
            this.Controls.Add(this.lblAgregar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvVisita);
            this.Controls.Add(this.cmbClaveVisitante);
            this.Controls.Add(this.cmbClaveVisita);
            this.Name = "FrmAgregarVisitanteAVisita";
            this.Text = "Agregar Visitante a Visita";
            this.Load += new System.EventHandler(this.FrmAgregarVisitanteAVisita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClaveVisita;
        private System.Windows.Forms.ComboBox cmbClaveVisitante;
        private System.Windows.Forms.DataGridView dgvVisita;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblAgregar;
        private System.Windows.Forms.Label lblVisita;
        private System.Windows.Forms.Label lblVisitante;
        private System.Windows.Forms.TextBox txtNombreVisitante;
        private System.Windows.Forms.ToolTip toolP;
    }
}
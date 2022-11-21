namespace SQL
{
    partial class FrmConsultaChoferes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblConsultaIndividual = new System.Windows.Forms.Label();
            this.lblChofer = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.cmbChofer = new System.Windows.Forms.ComboBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNumLicencia = new System.Windows.Forms.TextBox();
            this.lblNumLicencia = new System.Windows.Forms.Label();
            this.lblFechaVenLicencia = new System.Windows.Forms.Label();
            this.txtFechaVenLicencia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblConsultaIndividual
            // 
            this.lblConsultaIndividual.AutoSize = true;
            this.lblConsultaIndividual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaIndividual.Location = new System.Drawing.Point(59, 34);
            this.lblConsultaIndividual.Name = "lblConsultaIndividual";
            this.lblConsultaIndividual.Size = new System.Drawing.Size(186, 24);
            this.lblConsultaIndividual.TabIndex = 0;
            this.lblConsultaIndividual.Text = "Consulta Individual";
            // 
            // lblChofer
            // 
            this.lblChofer.AutoSize = true;
            this.lblChofer.Location = new System.Drawing.Point(40, 97);
            this.lblChofer.Name = "lblChofer";
            this.lblChofer.Size = new System.Drawing.Size(38, 13);
            this.lblChofer.TabIndex = 1;
            this.lblChofer.Text = "Chofer";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(40, 127);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(49, 13);
            this.lblNombres.TabIndex = 2;
            this.lblNombres.Text = "Nombres";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(40, 155);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblApellidos.TabIndex = 3;
            this.lblApellidos.Text = "Apellidos";
            // 
            // cmbChofer
            // 
            this.cmbChofer.FormattingEnabled = true;
            this.cmbChofer.Location = new System.Drawing.Point(163, 94);
            this.cmbChofer.Name = "cmbChofer";
            this.cmbChofer.Size = new System.Drawing.Size(121, 21);
            this.cmbChofer.TabIndex = 4;
            this.cmbChofer.SelectedIndexChanged += new System.EventHandler(this.cmbChofer_SelectedIndexChanged);
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(163, 124);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.ReadOnly = true;
            this.txtNombres.Size = new System.Drawing.Size(100, 20);
            this.txtNombres.TabIndex = 5;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(163, 152);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.ReadOnly = true;
            this.txtApellidos.Size = new System.Drawing.Size(100, 20);
            this.txtApellidos.TabIndex = 6;
            // 
            // txtNumLicencia
            // 
            this.txtNumLicencia.Location = new System.Drawing.Point(163, 179);
            this.txtNumLicencia.Name = "txtNumLicencia";
            this.txtNumLicencia.ReadOnly = true;
            this.txtNumLicencia.Size = new System.Drawing.Size(100, 20);
            this.txtNumLicencia.TabIndex = 7;
            // 
            // lblNumLicencia
            // 
            this.lblNumLicencia.AutoSize = true;
            this.lblNumLicencia.Location = new System.Drawing.Point(40, 182);
            this.lblNumLicencia.Name = "lblNumLicencia";
            this.lblNumLicencia.Size = new System.Drawing.Size(102, 13);
            this.lblNumLicencia.TabIndex = 9;
            this.lblNumLicencia.Text = "Numero de Licencia";
            // 
            // lblFechaVenLicencia
            // 
            this.lblFechaVenLicencia.AutoSize = true;
            this.lblFechaVenLicencia.Location = new System.Drawing.Point(40, 209);
            this.lblFechaVenLicencia.Name = "lblFechaVenLicencia";
            this.lblFechaVenLicencia.Size = new System.Drawing.Size(113, 13);
            this.lblFechaVenLicencia.TabIndex = 10;
            this.lblFechaVenLicencia.Text = "Fecha de Vencimiento";
            // 
            // txtFechaVenLicencia
            // 
            this.txtFechaVenLicencia.Location = new System.Drawing.Point(163, 206);
            this.txtFechaVenLicencia.Name = "txtFechaVenLicencia";
            this.txtFechaVenLicencia.ReadOnly = true;
            this.txtFechaVenLicencia.Size = new System.Drawing.Size(151, 20);
            this.txtFechaVenLicencia.TabIndex = 11;
            // 
            // FrmConsultaChoferes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 257);
            this.Controls.Add(this.txtFechaVenLicencia);
            this.Controls.Add(this.lblFechaVenLicencia);
            this.Controls.Add(this.lblNumLicencia);
            this.Controls.Add(this.txtNumLicencia);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.cmbChofer);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblChofer);
            this.Controls.Add(this.lblConsultaIndividual);
            this.Name = "FrmConsultaChoferes";
            this.Text = "Consulta Choferes";
            this.Load += new System.EventHandler(this.FrmConsultaChoferes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsultaIndividual;
        private System.Windows.Forms.Label lblChofer;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.ComboBox cmbChofer;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNumLicencia;
        private System.Windows.Forms.Label lblNumLicencia;
        private System.Windows.Forms.Label lblFechaVenLicencia;
        private System.Windows.Forms.TextBox txtFechaVenLicencia;
    }
}


namespace SQL
{
    partial class FrmConsultaVisitas
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
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.txtChofer = new System.Windows.Forms.TextBox();
            this.txtNumeroPersonas = new System.Windows.Forms.TextBox();
            this.txtTipoEvento = new System.Windows.Forms.TextBox();
            this.txtDescripcionEvento = new System.Windows.Forms.TextBox();
            this.txtCiudadDestino = new System.Windows.Forms.TextBox();
            this.cmbClave = new System.Windows.Forms.ComboBox();
            this.lblClaveChofer = new System.Windows.Forms.Label();
            this.lblChofer = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblNumPersonas = new System.Windows.Forms.Label();
            this.lblTipoEvento = new System.Windows.Forms.Label();
            this.lblDescripcionEvento = new System.Windows.Forms.Label();
            this.lblCiudadDestino = new System.Windows.Forms.Label();
            this.lblConsultaVisitas = new System.Windows.Forms.Label();
            this.txtNombreChofer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Enabled = false;
            this.dtpFechaInicio.Location = new System.Drawing.Point(184, 119);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 1;
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Enabled = false;
            this.dtpFechaFinal.Location = new System.Drawing.Point(184, 145);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFinal.TabIndex = 2;
            // 
            // txtChofer
            // 
            this.txtChofer.Location = new System.Drawing.Point(184, 93);
            this.txtChofer.Name = "txtChofer";
            this.txtChofer.ReadOnly = true;
            this.txtChofer.Size = new System.Drawing.Size(100, 20);
            this.txtChofer.TabIndex = 4;
            // 
            // txtNumeroPersonas
            // 
            this.txtNumeroPersonas.Location = new System.Drawing.Point(184, 171);
            this.txtNumeroPersonas.Name = "txtNumeroPersonas";
            this.txtNumeroPersonas.ReadOnly = true;
            this.txtNumeroPersonas.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroPersonas.TabIndex = 5;
            // 
            // txtTipoEvento
            // 
            this.txtTipoEvento.Location = new System.Drawing.Point(184, 197);
            this.txtTipoEvento.Name = "txtTipoEvento";
            this.txtTipoEvento.ReadOnly = true;
            this.txtTipoEvento.Size = new System.Drawing.Size(100, 20);
            this.txtTipoEvento.TabIndex = 6;
            // 
            // txtDescripcionEvento
            // 
            this.txtDescripcionEvento.Location = new System.Drawing.Point(184, 223);
            this.txtDescripcionEvento.Name = "txtDescripcionEvento";
            this.txtDescripcionEvento.ReadOnly = true;
            this.txtDescripcionEvento.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcionEvento.TabIndex = 7;
            // 
            // txtCiudadDestino
            // 
            this.txtCiudadDestino.Location = new System.Drawing.Point(184, 249);
            this.txtCiudadDestino.Name = "txtCiudadDestino";
            this.txtCiudadDestino.ReadOnly = true;
            this.txtCiudadDestino.Size = new System.Drawing.Size(100, 20);
            this.txtCiudadDestino.TabIndex = 8;
            // 
            // cmbClave
            // 
            this.cmbClave.FormattingEnabled = true;
            this.cmbClave.Location = new System.Drawing.Point(184, 66);
            this.cmbClave.Name = "cmbClave";
            this.cmbClave.Size = new System.Drawing.Size(121, 21);
            this.cmbClave.TabIndex = 9;
            this.cmbClave.SelectedIndexChanged += new System.EventHandler(this.cmbClave_SelectedIndexChanged);
            // 
            // lblClaveChofer
            // 
            this.lblClaveChofer.AutoSize = true;
            this.lblClaveChofer.Location = new System.Drawing.Point(52, 69);
            this.lblClaveChofer.Name = "lblClaveChofer";
            this.lblClaveChofer.Size = new System.Drawing.Size(34, 13);
            this.lblClaveChofer.TabIndex = 10;
            this.lblClaveChofer.Text = "Clave";
            // 
            // lblChofer
            // 
            this.lblChofer.AutoSize = true;
            this.lblChofer.Location = new System.Drawing.Point(52, 96);
            this.lblChofer.Name = "lblChofer";
            this.lblChofer.Size = new System.Drawing.Size(38, 13);
            this.lblChofer.TabIndex = 11;
            this.lblChofer.Text = "Chofer";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(52, 125);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(65, 13);
            this.lblFechaInicio.TabIndex = 12;
            this.lblFechaInicio.Text = "Fecha Inicio";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(52, 151);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(54, 13);
            this.lblFechaFin.TabIndex = 13;
            this.lblFechaFin.Text = "Fecha Fin";
            // 
            // lblNumPersonas
            // 
            this.lblNumPersonas.AutoSize = true;
            this.lblNumPersonas.Location = new System.Drawing.Point(52, 174);
            this.lblNumPersonas.Name = "lblNumPersonas";
            this.lblNumPersonas.Size = new System.Drawing.Size(106, 13);
            this.lblNumPersonas.TabIndex = 14;
            this.lblNumPersonas.Text = "Numero de Personas";
            // 
            // lblTipoEvento
            // 
            this.lblTipoEvento.AutoSize = true;
            this.lblTipoEvento.Location = new System.Drawing.Point(52, 200);
            this.lblTipoEvento.Name = "lblTipoEvento";
            this.lblTipoEvento.Size = new System.Drawing.Size(80, 13);
            this.lblTipoEvento.TabIndex = 15;
            this.lblTipoEvento.Text = "Tipo de Evento";
            // 
            // lblDescripcionEvento
            // 
            this.lblDescripcionEvento.AutoSize = true;
            this.lblDescripcionEvento.Location = new System.Drawing.Point(52, 226);
            this.lblDescripcionEvento.Name = "lblDescripcionEvento";
            this.lblDescripcionEvento.Size = new System.Drawing.Size(117, 13);
            this.lblDescripcionEvento.TabIndex = 16;
            this.lblDescripcionEvento.Text = "Descripción del Evento";
            // 
            // lblCiudadDestino
            // 
            this.lblCiudadDestino.AutoSize = true;
            this.lblCiudadDestino.Location = new System.Drawing.Point(52, 252);
            this.lblCiudadDestino.Name = "lblCiudadDestino";
            this.lblCiudadDestino.Size = new System.Drawing.Size(94, 13);
            this.lblCiudadDestino.TabIndex = 17;
            this.lblCiudadDestino.Text = "Ciudad de Destino";
            // 
            // lblConsultaVisitas
            // 
            this.lblConsultaVisitas.AutoSize = true;
            this.lblConsultaVisitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaVisitas.Location = new System.Drawing.Point(79, 13);
            this.lblConsultaVisitas.Name = "lblConsultaVisitas";
            this.lblConsultaVisitas.Size = new System.Drawing.Size(187, 24);
            this.lblConsultaVisitas.TabIndex = 18;
            this.lblConsultaVisitas.Text = "Consulta de Visitas";
            // 
            // txtNombreChofer
            // 
            this.txtNombreChofer.Location = new System.Drawing.Point(299, 93);
            this.txtNombreChofer.Name = "txtNombreChofer";
            this.txtNombreChofer.ReadOnly = true;
            this.txtNombreChofer.Size = new System.Drawing.Size(164, 20);
            this.txtNombreChofer.TabIndex = 19;
            // 
            // FrmConsultaVisitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 297);
            this.Controls.Add(this.txtNombreChofer);
            this.Controls.Add(this.lblConsultaVisitas);
            this.Controls.Add(this.lblCiudadDestino);
            this.Controls.Add(this.lblDescripcionEvento);
            this.Controls.Add(this.lblTipoEvento);
            this.Controls.Add(this.lblNumPersonas);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.lblChofer);
            this.Controls.Add(this.lblClaveChofer);
            this.Controls.Add(this.cmbClave);
            this.Controls.Add(this.txtCiudadDestino);
            this.Controls.Add(this.txtDescripcionEvento);
            this.Controls.Add(this.txtTipoEvento);
            this.Controls.Add(this.txtNumeroPersonas);
            this.Controls.Add(this.txtChofer);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.dtpFechaInicio);
            this.Name = "FrmConsultaVisitas";
            this.Text = "Consulta Visitas";
            this.Load += new System.EventHandler(this.FrmConsultaVisitas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.TextBox txtChofer;
        private System.Windows.Forms.TextBox txtNumeroPersonas;
        private System.Windows.Forms.TextBox txtTipoEvento;
        private System.Windows.Forms.TextBox txtDescripcionEvento;
        private System.Windows.Forms.TextBox txtCiudadDestino;
        private System.Windows.Forms.ComboBox cmbClave;
        private System.Windows.Forms.Label lblClaveChofer;
        private System.Windows.Forms.Label lblChofer;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblNumPersonas;
        private System.Windows.Forms.Label lblTipoEvento;
        private System.Windows.Forms.Label lblDescripcionEvento;
        private System.Windows.Forms.Label lblCiudadDestino;
        private System.Windows.Forms.Label lblConsultaVisitas;
        private System.Windows.Forms.TextBox txtNombreChofer;
    }
}
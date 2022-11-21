namespace Choferes.Front
{
    partial class FrmAgregarVisita
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
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.nupNumeroPersonas = new System.Windows.Forms.NumericUpDown();
            this.txtDescripcionEvento = new System.Windows.Forms.TextBox();
            this.txtCiudadDestino = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblAgregar = new System.Windows.Forms.Label();
            this.lblCiudadDestino = new System.Windows.Forms.Label();
            this.lblDescripcionEvento = new System.Windows.Forms.Label();
            this.lblTipoEvento = new System.Windows.Forms.Label();
            this.lblNumPersonas = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblChofer = new System.Windows.Forms.Label();
            this.cmbChofer = new System.Windows.Forms.ComboBox();
            this.txtNombreChofer = new System.Windows.Forms.TextBox();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolP = new System.Windows.Forms.ToolTip(this.components);
            this.cmbTipoEvento = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumeroPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(162, 95);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 1;
            this.toolP.SetToolTip(this.dtpFechaInicio, "Fecha inicio");
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(162, 122);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFin.TabIndex = 2;
            this.toolP.SetToolTip(this.dtpFechaFin, "Fecha fin");
            // 
            // nupNumeroPersonas
            // 
            this.nupNumeroPersonas.Location = new System.Drawing.Point(162, 149);
            this.nupNumeroPersonas.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nupNumeroPersonas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupNumeroPersonas.Name = "nupNumeroPersonas";
            this.nupNumeroPersonas.Size = new System.Drawing.Size(120, 20);
            this.nupNumeroPersonas.TabIndex = 3;
            this.toolP.SetToolTip(this.nupNumeroPersonas, "Cantidad maxima de personas en el viaje");
            this.nupNumeroPersonas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtDescripcionEvento
            // 
            this.txtDescripcionEvento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcionEvento.Location = new System.Drawing.Point(162, 204);
            this.txtDescripcionEvento.MaxLength = 100;
            this.txtDescripcionEvento.Name = "txtDescripcionEvento";
            this.txtDescripcionEvento.Size = new System.Drawing.Size(321, 20);
            this.txtDescripcionEvento.TabIndex = 5;
            this.toolP.SetToolTip(this.txtDescripcionEvento, "Descripción del evento");
            this.txtDescripcionEvento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcionEvento_KeyPress);
            this.txtDescripcionEvento.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescripcionEvento_Validating);
            this.txtDescripcionEvento.Validated += new System.EventHandler(this.txtDescripcionEvento_Validated);
            // 
            // txtCiudadDestino
            // 
            this.txtCiudadDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCiudadDestino.Location = new System.Drawing.Point(162, 230);
            this.txtCiudadDestino.MaxLength = 20;
            this.txtCiudadDestino.Name = "txtCiudadDestino";
            this.txtCiudadDestino.Size = new System.Drawing.Size(100, 20);
            this.txtCiudadDestino.TabIndex = 6;
            this.toolP.SetToolTip(this.txtCiudadDestino, "Ciudad destino");
            this.txtCiudadDestino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCiudadDestino_KeyPress);
            this.txtCiudadDestino.Validating += new System.ComponentModel.CancelEventHandler(this.txtCiudadDestino_Validating);
            this.txtCiudadDestino.Validated += new System.EventHandler(this.txtCiudadDestino_Validated);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(162, 257);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(243, 257);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblAgregar
            // 
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregar.Location = new System.Drawing.Point(121, 21);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(141, 24);
            this.lblAgregar.TabIndex = 27;
            this.lblAgregar.Text = "Agregar Visita";
            // 
            // lblCiudadDestino
            // 
            this.lblCiudadDestino.AutoSize = true;
            this.lblCiudadDestino.Location = new System.Drawing.Point(38, 233);
            this.lblCiudadDestino.Name = "lblCiudadDestino";
            this.lblCiudadDestino.Size = new System.Drawing.Size(94, 13);
            this.lblCiudadDestino.TabIndex = 26;
            this.lblCiudadDestino.Text = "Ciudad de Destino";
            // 
            // lblDescripcionEvento
            // 
            this.lblDescripcionEvento.AutoSize = true;
            this.lblDescripcionEvento.Location = new System.Drawing.Point(38, 207);
            this.lblDescripcionEvento.Name = "lblDescripcionEvento";
            this.lblDescripcionEvento.Size = new System.Drawing.Size(117, 13);
            this.lblDescripcionEvento.TabIndex = 25;
            this.lblDescripcionEvento.Text = "Descripción del Evento";
            // 
            // lblTipoEvento
            // 
            this.lblTipoEvento.AutoSize = true;
            this.lblTipoEvento.Location = new System.Drawing.Point(38, 181);
            this.lblTipoEvento.Name = "lblTipoEvento";
            this.lblTipoEvento.Size = new System.Drawing.Size(80, 13);
            this.lblTipoEvento.TabIndex = 24;
            this.lblTipoEvento.Text = "Tipo de Evento";
            // 
            // lblNumPersonas
            // 
            this.lblNumPersonas.AutoSize = true;
            this.lblNumPersonas.Location = new System.Drawing.Point(38, 151);
            this.lblNumPersonas.Name = "lblNumPersonas";
            this.lblNumPersonas.Size = new System.Drawing.Size(106, 13);
            this.lblNumPersonas.TabIndex = 23;
            this.lblNumPersonas.Text = "Numero de Personas";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(38, 128);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(54, 13);
            this.lblFechaFin.TabIndex = 22;
            this.lblFechaFin.Text = "Fecha Fin";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(38, 102);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(65, 13);
            this.lblFechaInicio.TabIndex = 21;
            this.lblFechaInicio.Text = "Fecha Inicio";
            // 
            // lblChofer
            // 
            this.lblChofer.AutoSize = true;
            this.lblChofer.Location = new System.Drawing.Point(38, 71);
            this.lblChofer.Name = "lblChofer";
            this.lblChofer.Size = new System.Drawing.Size(38, 13);
            this.lblChofer.TabIndex = 20;
            this.lblChofer.Text = "Chofer";
            // 
            // cmbChofer
            // 
            this.cmbChofer.FormattingEnabled = true;
            this.cmbChofer.Location = new System.Drawing.Point(161, 68);
            this.cmbChofer.Name = "cmbChofer";
            this.cmbChofer.Size = new System.Drawing.Size(121, 21);
            this.cmbChofer.TabIndex = 28;
            this.toolP.SetToolTip(this.cmbChofer, "Clave del chofer");
            this.cmbChofer.SelectedIndexChanged += new System.EventHandler(this.cmbChofer_SelectedIndexChanged);
            // 
            // txtNombreChofer
            // 
            this.txtNombreChofer.Location = new System.Drawing.Point(299, 68);
            this.txtNombreChofer.Name = "txtNombreChofer";
            this.txtNombreChofer.ReadOnly = true;
            this.txtNombreChofer.Size = new System.Drawing.Size(184, 20);
            this.txtNombreChofer.TabIndex = 29;
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // cmbTipoEvento
            // 
            this.cmbTipoEvento.FormattingEnabled = true;
            this.cmbTipoEvento.Items.AddRange(new object[] {
            "CONGRESO",
            "MUSEO",
            "FIESTA",
            "DISCOTECA",
            "ESCUELA"});
            this.cmbTipoEvento.Location = new System.Drawing.Point(162, 176);
            this.cmbTipoEvento.Name = "cmbTipoEvento";
            this.cmbTipoEvento.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoEvento.TabIndex = 30;
            // 
            // FrmAgregarVisita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 302);
            this.Controls.Add(this.cmbTipoEvento);
            this.Controls.Add(this.txtNombreChofer);
            this.Controls.Add(this.cmbChofer);
            this.Controls.Add(this.lblAgregar);
            this.Controls.Add(this.lblCiudadDestino);
            this.Controls.Add(this.lblDescripcionEvento);
            this.Controls.Add(this.lblTipoEvento);
            this.Controls.Add(this.lblNumPersonas);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.lblChofer);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCiudadDestino);
            this.Controls.Add(this.txtDescripcionEvento);
            this.Controls.Add(this.nupNumeroPersonas);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Name = "FrmAgregarVisita";
            this.Text = "Agregar Visita";
            this.Load += new System.EventHandler(this.FrmAgregarVisita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupNumeroPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.NumericUpDown nupNumeroPersonas;
        private System.Windows.Forms.TextBox txtDescripcionEvento;
        private System.Windows.Forms.TextBox txtCiudadDestino;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblAgregar;
        private System.Windows.Forms.Label lblCiudadDestino;
        private System.Windows.Forms.Label lblDescripcionEvento;
        private System.Windows.Forms.Label lblTipoEvento;
        private System.Windows.Forms.Label lblNumPersonas;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblChofer;
        private System.Windows.Forms.ComboBox cmbChofer;
        private System.Windows.Forms.TextBox txtNombreChofer;
        private System.Windows.Forms.ErrorProvider errorP;
        private System.Windows.Forms.ToolTip toolP;
        private System.Windows.Forms.ComboBox cmbTipoEvento;
    }
}
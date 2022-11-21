
namespace Auto
{
    partial class frmAgregarAuto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarAuto));
            this.lblNumSerie = new System.Windows.Forms.Label();
            this.lblNomAuto = new System.Windows.Forms.Label();
            this.Marca = new System.Windows.Forms.Label();
            this.lblNumMaxPa = new System.Windows.Forms.Label();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.txtNomAuto = new System.Windows.Forms.TextBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.numupPasajeros = new System.Windows.Forms.NumericUpDown();
            this.grpTipoTrans = new System.Windows.Forms.GroupBox();
            this.rdEstandar = new System.Windows.Forms.RadioButton();
            this.rdAutomatica = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grpGolpes = new System.Windows.Forms.GroupBox();
            this.chkTrasera = new System.Windows.Forms.CheckBox();
            this.chkPuertas = new System.Windows.Forms.CheckBox();
            this.chkDefensa = new System.Windows.Forms.CheckBox();
            this.lblOtros = new System.Windows.Forms.Label();
            this.txtOtros = new System.Windows.Forms.TextBox();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.toolP = new System.Windows.Forms.ToolTip(this.components);
            this.txtPropietario = new System.Windows.Forms.TextBox();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblPropietario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numupPasajeros)).BeginInit();
            this.grpTipoTrans.SuspendLayout();
            this.grpGolpes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumSerie
            // 
            this.lblNumSerie.AutoSize = true;
            this.lblNumSerie.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSerie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNumSerie.Location = new System.Drawing.Point(19, 50);
            this.lblNumSerie.Name = "lblNumSerie";
            this.lblNumSerie.Size = new System.Drawing.Size(160, 22);
            this.lblNumSerie.TabIndex = 0;
            this.lblNumSerie.Text = "Numero de Serie";
            // 
            // lblNomAuto
            // 
            this.lblNomAuto.AutoSize = true;
            this.lblNomAuto.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomAuto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNomAuto.Location = new System.Drawing.Point(20, 110);
            this.lblNomAuto.Name = "lblNomAuto";
            this.lblNomAuto.Size = new System.Drawing.Size(120, 22);
            this.lblNomAuto.TabIndex = 1;
            this.lblNomAuto.Text = "Nombre Auto";
            // 
            // Marca
            // 
            this.Marca.AutoSize = true;
            this.Marca.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Marca.Location = new System.Drawing.Point(21, 242);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(60, 22);
            this.Marca.TabIndex = 2;
            this.Marca.Text = "Marca";
            // 
            // lblNumMaxPa
            // 
            this.lblNumMaxPa.AutoSize = true;
            this.lblNumMaxPa.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumMaxPa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNumMaxPa.Location = new System.Drawing.Point(468, 56);
            this.lblNumMaxPa.Name = "lblNumMaxPa";
            this.lblNumMaxPa.Size = new System.Drawing.Size(270, 22);
            this.lblNumMaxPa.TabIndex = 3;
            this.lblNumMaxPa.Text = "Numero Maximo de Pasajeros";
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumSerie.Location = new System.Drawing.Point(24, 77);
            this.txtNumSerie.MaxLength = 8;
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(156, 26);
            this.txtNumSerie.TabIndex = 4;
            this.toolP.SetToolTip(this.txtNumSerie, "Numero de serie de 11 digitos");
            this.txtNumSerie.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumSerie_Validating);
            this.txtNumSerie.Validated += new System.EventHandler(this.txtNumSerie_Validated);
            // 
            // txtNomAuto
            // 
            this.txtNomAuto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomAuto.Location = new System.Drawing.Point(24, 135);
            this.txtNomAuto.MaxLength = 30;
            this.txtNomAuto.Name = "txtNomAuto";
            this.txtNomAuto.Size = new System.Drawing.Size(156, 26);
            this.txtNomAuto.TabIndex = 5;
            this.toolP.SetToolTip(this.txtNomAuto, "Nombre del auto");
            this.txtNomAuto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomAuto_KeyPress);
            this.txtNomAuto.Validating += new System.ComponentModel.CancelEventHandler(this.txtNomAuto_Validating);
            this.txtNomAuto.Validated += new System.EventHandler(this.txtNomAuto_Validated);
            // 
            // cmbMarca
            // 
            this.cmbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "NISSAN",
            "HYUNDAI",
            "CHEVROLET"});
            this.cmbMarca.Location = new System.Drawing.Point(25, 269);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(155, 28);
            this.cmbMarca.TabIndex = 6;
            this.toolP.SetToolTip(this.cmbMarca, "Seleccione marca");
            this.cmbMarca.SelectedIndexChanged += new System.EventHandler(this.cmbMarca_SelectedIndexChanged);
            this.cmbMarca.Validating += new System.ComponentModel.CancelEventHandler(this.cmbMarca_Validating);
            this.cmbMarca.Validated += new System.EventHandler(this.cmbMarca_Validated);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(56, 368);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 37);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.toolP.SetToolTip(this.btnGuardar, "Guardar auto");
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLimpiar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Location = new System.Drawing.Point(176, 368);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(87, 37);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.toolP.SetToolTip(this.btnLimpiar, "Borrar datos ingresados");
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnConsultar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultar.Location = new System.Drawing.Point(289, 368);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(87, 37);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "Consultar";
            this.toolP.SetToolTip(this.btnConsultar, "Consulta datos de auto");
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalir.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(400, 368);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 37);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.toolP.SetToolTip(this.btnSalir, "Sale del programa");
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // numupPasajeros
            // 
            this.numupPasajeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numupPasajeros.Location = new System.Drawing.Point(576, 100);
            this.numupPasajeros.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numupPasajeros.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numupPasajeros.Name = "numupPasajeros";
            this.numupPasajeros.Size = new System.Drawing.Size(58, 26);
            this.numupPasajeros.TabIndex = 12;
            this.numupPasajeros.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grpTipoTrans
            // 
            this.grpTipoTrans.Controls.Add(this.rdEstandar);
            this.grpTipoTrans.Controls.Add(this.rdAutomatica);
            this.grpTipoTrans.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTipoTrans.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpTipoTrans.Location = new System.Drawing.Point(264, 56);
            this.grpTipoTrans.Name = "grpTipoTrans";
            this.grpTipoTrans.Size = new System.Drawing.Size(187, 114);
            this.grpTipoTrans.TabIndex = 13;
            this.grpTipoTrans.TabStop = false;
            this.grpTipoTrans.Text = "Tipo de Transmisión";
            this.toolP.SetToolTip(this.grpTipoTrans, "Seleccione el tipo de transmision");
            // 
            // rdEstandar
            // 
            this.rdEstandar.AutoSize = true;
            this.rdEstandar.Checked = true;
            this.rdEstandar.Location = new System.Drawing.Point(24, 66);
            this.rdEstandar.Name = "rdEstandar";
            this.rdEstandar.Size = new System.Drawing.Size(88, 23);
            this.rdEstandar.TabIndex = 1;
            this.rdEstandar.TabStop = true;
            this.rdEstandar.Text = "Estandar";
            this.rdEstandar.UseVisualStyleBackColor = true;
            // 
            // rdAutomatica
            // 
            this.rdAutomatica.AutoSize = true;
            this.rdAutomatica.Location = new System.Drawing.Point(24, 35);
            this.rdAutomatica.Name = "rdAutomatica";
            this.rdAutomatica.Size = new System.Drawing.Size(107, 23);
            this.rdAutomatica.TabIndex = 0;
            this.rdAutomatica.Text = "Automatica";
            this.rdAutomatica.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // grpGolpes
            // 
            this.grpGolpes.Controls.Add(this.chkTrasera);
            this.grpGolpes.Controls.Add(this.chkPuertas);
            this.grpGolpes.Controls.Add(this.chkDefensa);
            this.grpGolpes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGolpes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpGolpes.Location = new System.Drawing.Point(264, 228);
            this.grpGolpes.Name = "grpGolpes";
            this.grpGolpes.Size = new System.Drawing.Size(206, 114);
            this.grpGolpes.TabIndex = 14;
            this.grpGolpes.TabStop = false;
            this.grpGolpes.Text = "Golpes en";
            this.toolP.SetToolTip(this.grpGolpes, "Selecciona el detalle o ingresa otro");
            // 
            // chkTrasera
            // 
            this.chkTrasera.AutoSize = true;
            this.chkTrasera.Location = new System.Drawing.Point(23, 70);
            this.chkTrasera.Name = "chkTrasera";
            this.chkTrasera.Size = new System.Drawing.Size(81, 23);
            this.chkTrasera.TabIndex = 2;
            this.chkTrasera.Text = "Trasera";
            this.chkTrasera.UseVisualStyleBackColor = true;
            // 
            // chkPuertas
            // 
            this.chkPuertas.AutoSize = true;
            this.chkPuertas.Location = new System.Drawing.Point(23, 46);
            this.chkPuertas.Name = "chkPuertas";
            this.chkPuertas.Size = new System.Drawing.Size(80, 23);
            this.chkPuertas.TabIndex = 1;
            this.chkPuertas.Text = "Puertas";
            this.chkPuertas.UseVisualStyleBackColor = true;
            // 
            // chkDefensa
            // 
            this.chkDefensa.AutoSize = true;
            this.chkDefensa.Location = new System.Drawing.Point(23, 26);
            this.chkDefensa.Name = "chkDefensa";
            this.chkDefensa.Size = new System.Drawing.Size(84, 23);
            this.chkDefensa.TabIndex = 0;
            this.chkDefensa.Text = "Defensa";
            this.chkDefensa.UseVisualStyleBackColor = true;
            // 
            // lblOtros
            // 
            this.lblOtros.AutoSize = true;
            this.lblOtros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOtros.Location = new System.Drawing.Point(503, 247);
            this.lblOtros.Name = "lblOtros";
            this.lblOtros.Size = new System.Drawing.Size(53, 20);
            this.lblOtros.TabIndex = 15;
            this.lblOtros.Text = "Otros";
            // 
            // txtOtros
            // 
            this.txtOtros.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtOtros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOtros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtros.Location = new System.Drawing.Point(507, 274);
            this.txtOtros.MaxLength = 100;
            this.txtOtros.Name = "txtOtros";
            this.txtOtros.Size = new System.Drawing.Size(164, 26);
            this.txtOtros.TabIndex = 16;
            this.toolP.SetToolTip(this.txtOtros, "Otros detalles de carroceria");
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalles.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDetalles.Location = new System.Drawing.Point(361, 194);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(260, 22);
            this.lblDetalles.TabIndex = 17;
            this.lblDetalles.Text = "Detalles en la carroceria";
            // 
            // txtPropietario
            // 
            this.txtPropietario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropietario.Location = new System.Drawing.Point(25, 202);
            this.txtPropietario.MaxLength = 50;
            this.txtPropietario.Name = "txtPropietario";
            this.txtPropietario.Size = new System.Drawing.Size(155, 26);
            this.txtPropietario.TabIndex = 19;
            this.toolP.SetToolTip(this.txtPropietario, "Ingrese el dueño");
            this.txtPropietario.Validating += new System.ComponentModel.CancelEventHandler(this.txtPropietario_Validating);
            this.txtPropietario.Validated += new System.EventHandler(this.txtPropietario_Validated);
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // lblPropietario
            // 
            this.lblPropietario.AutoSize = true;
            this.lblPropietario.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropietario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPropietario.Location = new System.Drawing.Point(21, 177);
            this.lblPropietario.Name = "lblPropietario";
            this.lblPropietario.Size = new System.Drawing.Size(120, 22);
            this.lblPropietario.TabIndex = 18;
            this.lblPropietario.Text = "Propietario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(519, 335);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // frmAgregarAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(750, 426);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPropietario);
            this.Controls.Add(this.lblNumMaxPa);
            this.Controls.Add(this.lblPropietario);
            this.Controls.Add(this.lblDetalles);
            this.Controls.Add(this.txtOtros);
            this.Controls.Add(this.lblOtros);
            this.Controls.Add(this.grpGolpes);
            this.Controls.Add(this.grpTipoTrans);
            this.Controls.Add(this.numupPasajeros);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.txtNomAuto);
            this.Controls.Add(this.txtNumSerie);
            this.Controls.Add(this.Marca);
            this.Controls.Add(this.lblNomAuto);
            this.Controls.Add(this.lblNumSerie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarAuto";
            this.Text = "Agregar Auto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numupPasajeros)).EndInit();
            this.grpTipoTrans.ResumeLayout(false);
            this.grpTipoTrans.PerformLayout();
            this.grpGolpes.ResumeLayout(false);
            this.grpGolpes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumSerie;
        private System.Windows.Forms.Label lblNomAuto;
        private System.Windows.Forms.Label Marca;
        private System.Windows.Forms.Label lblNumMaxPa;
        private System.Windows.Forms.TextBox txtNumSerie;
        private System.Windows.Forms.TextBox txtNomAuto;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.NumericUpDown numupPasajeros;
        private System.Windows.Forms.GroupBox grpTipoTrans;
        private System.Windows.Forms.RadioButton rdEstandar;
        private System.Windows.Forms.RadioButton rdAutomatica;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox grpGolpes;
        private System.Windows.Forms.CheckBox chkTrasera;
        private System.Windows.Forms.CheckBox chkPuertas;
        private System.Windows.Forms.CheckBox chkDefensa;
        private System.Windows.Forms.Label lblOtros;
        private System.Windows.Forms.TextBox txtOtros;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.ToolTip toolP;
        private System.Windows.Forms.ErrorProvider errorP;
        private System.Windows.Forms.TextBox txtPropietario;
        private System.Windows.Forms.Label lblPropietario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


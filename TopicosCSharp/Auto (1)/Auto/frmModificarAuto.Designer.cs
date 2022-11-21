
namespace Auto
{
    partial class frmModificarAuto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarAuto));
            this.txtPropietario = new System.Windows.Forms.TextBox();
            this.lblPropietario = new System.Windows.Forms.Label();
            this.numupPasajeros = new System.Windows.Forms.NumericUpDown();
            this.txtNomAuto = new System.Windows.Forms.TextBox();
            this.lblNumMaxPa = new System.Windows.Forms.Label();
            this.Marca = new System.Windows.Forms.Label();
            this.lblNomAuto = new System.Windows.Forms.Label();
            this.lblNumSerie = new System.Windows.Forms.Label();
            this.grpTipoTrans = new System.Windows.Forms.GroupBox();
            this.rdEstandar = new System.Windows.Forms.RadioButton();
            this.rdAutomatica = new System.Windows.Forms.RadioButton();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.txtOtros = new System.Windows.Forms.TextBox();
            this.lblOtros = new System.Windows.Forms.Label();
            this.grpGolpes = new System.Windows.Forms.GroupBox();
            this.chkTrasera = new System.Windows.Forms.CheckBox();
            this.chkPuertas = new System.Windows.Forms.CheckBox();
            this.chkDefensa = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbNumSerie = new System.Windows.Forms.ComboBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolP = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numupPasajeros)).BeginInit();
            this.grpTipoTrans.SuspendLayout();
            this.grpGolpes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPropietario
            // 
            this.txtPropietario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropietario.Location = new System.Drawing.Point(16, 346);
            this.txtPropietario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPropietario.MaxLength = 100;
            this.txtPropietario.Name = "txtPropietario";
            this.txtPropietario.Size = new System.Drawing.Size(182, 26);
            this.txtPropietario.TabIndex = 29;
            this.toolP.SetToolTip(this.txtPropietario, "Dato modificable");
            this.txtPropietario.Validating += new System.ComponentModel.CancelEventHandler(this.txtPropietario_Validating);
            this.txtPropietario.Validated += new System.EventHandler(this.txtPropietario_Validated);
            // 
            // lblPropietario
            // 
            this.lblPropietario.AutoSize = true;
            this.lblPropietario.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropietario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPropietario.Location = new System.Drawing.Point(8, 300);
            this.lblPropietario.Name = "lblPropietario";
            this.lblPropietario.Size = new System.Drawing.Size(142, 24);
            this.lblPropietario.TabIndex = 28;
            this.lblPropietario.Text = "Propietario";
            // 
            // numupPasajeros
            // 
            this.numupPasajeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numupPasajeros.Location = new System.Drawing.Point(591, 112);
            this.numupPasajeros.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.numupPasajeros.Size = new System.Drawing.Size(68, 26);
            this.numupPasajeros.TabIndex = 27;
            this.numupPasajeros.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtNomAuto
            // 
            this.txtNomAuto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomAuto.Enabled = false;
            this.txtNomAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomAuto.Location = new System.Drawing.Point(12, 174);
            this.txtNomAuto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomAuto.MaxLength = 30;
            this.txtNomAuto.Name = "txtNomAuto";
            this.txtNomAuto.ReadOnly = true;
            this.txtNomAuto.Size = new System.Drawing.Size(176, 26);
            this.txtNomAuto.TabIndex = 25;
            this.toolP.SetToolTip(this.txtNomAuto, "Ingrese un dato");
            // 
            // lblNumMaxPa
            // 
            this.lblNumMaxPa.AutoSize = true;
            this.lblNumMaxPa.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumMaxPa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNumMaxPa.Location = new System.Drawing.Point(464, 69);
            this.lblNumMaxPa.Name = "lblNumMaxPa";
            this.lblNumMaxPa.Size = new System.Drawing.Size(322, 24);
            this.lblNumMaxPa.TabIndex = 23;
            this.lblNumMaxPa.Text = "Numero Maximo de Pasajeros";
            // 
            // Marca
            // 
            this.Marca.AutoSize = true;
            this.Marca.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Marca.Location = new System.Drawing.Point(12, 217);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(70, 24);
            this.Marca.TabIndex = 22;
            this.Marca.Text = "Marca";
            // 
            // lblNomAuto
            // 
            this.lblNomAuto.AutoSize = true;
            this.lblNomAuto.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomAuto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNomAuto.Location = new System.Drawing.Point(10, 130);
            this.lblNomAuto.Name = "lblNomAuto";
            this.lblNomAuto.Size = new System.Drawing.Size(142, 24);
            this.lblNomAuto.TabIndex = 21;
            this.lblNomAuto.Text = "Nombre Auto";
            // 
            // lblNumSerie
            // 
            this.lblNumSerie.AutoSize = true;
            this.lblNumSerie.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSerie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNumSerie.Location = new System.Drawing.Point(8, 52);
            this.lblNumSerie.Name = "lblNumSerie";
            this.lblNumSerie.Size = new System.Drawing.Size(190, 24);
            this.lblNumSerie.TabIndex = 20;
            this.lblNumSerie.Text = "Numero de Serie";
            // 
            // grpTipoTrans
            // 
            this.grpTipoTrans.Controls.Add(this.rdEstandar);
            this.grpTipoTrans.Controls.Add(this.rdAutomatica);
            this.grpTipoTrans.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTipoTrans.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpTipoTrans.Location = new System.Drawing.Point(238, 69);
            this.grpTipoTrans.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpTipoTrans.Name = "grpTipoTrans";
            this.grpTipoTrans.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpTipoTrans.Size = new System.Drawing.Size(192, 112);
            this.grpTipoTrans.TabIndex = 30;
            this.grpTipoTrans.TabStop = false;
            this.grpTipoTrans.Text = "Tipo de Transmisión";
            this.toolP.SetToolTip(this.grpTipoTrans, "¿Su carro es estandar?");
            // 
            // rdEstandar
            // 
            this.rdEstandar.AutoSize = true;
            this.rdEstandar.Checked = true;
            this.rdEstandar.Location = new System.Drawing.Point(28, 61);
            this.rdEstandar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.rdAutomatica.Location = new System.Drawing.Point(28, 30);
            this.rdAutomatica.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdAutomatica.Name = "rdAutomatica";
            this.rdAutomatica.Size = new System.Drawing.Size(107, 23);
            this.rdAutomatica.TabIndex = 0;
            this.rdAutomatica.Text = "Automatica";
            this.rdAutomatica.UseVisualStyleBackColor = true;
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalles.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDetalles.Location = new System.Drawing.Point(349, 217);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(310, 24);
            this.lblDetalles.TabIndex = 34;
            this.lblDetalles.Text = "Detalles en la carroceria";
            // 
            // txtOtros
            // 
            this.txtOtros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOtros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtros.Location = new System.Drawing.Point(477, 302);
            this.txtOtros.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOtros.MaxLength = 50;
            this.txtOtros.Name = "txtOtros";
            this.txtOtros.Size = new System.Drawing.Size(191, 26);
            this.txtOtros.TabIndex = 33;
            // 
            // lblOtros
            // 
            this.lblOtros.AutoSize = true;
            this.lblOtros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOtros.Location = new System.Drawing.Point(484, 273);
            this.lblOtros.Name = "lblOtros";
            this.lblOtros.Size = new System.Drawing.Size(53, 20);
            this.lblOtros.TabIndex = 32;
            this.lblOtros.Text = "Otros";
            // 
            // grpGolpes
            // 
            this.grpGolpes.Controls.Add(this.chkTrasera);
            this.grpGolpes.Controls.Add(this.chkPuertas);
            this.grpGolpes.Controls.Add(this.chkDefensa);
            this.grpGolpes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGolpes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpGolpes.Location = new System.Drawing.Point(238, 245);
            this.grpGolpes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpGolpes.Name = "grpGolpes";
            this.grpGolpes.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpGolpes.Size = new System.Drawing.Size(192, 118);
            this.grpGolpes.TabIndex = 31;
            this.grpGolpes.TabStop = false;
            this.grpGolpes.Text = "Golpes en";
            this.toolP.SetToolTip(this.grpGolpes, "Seleccione si tiene algun golpe su auto");
            // 
            // chkTrasera
            // 
            this.chkTrasera.AutoSize = true;
            this.chkTrasera.Location = new System.Drawing.Point(27, 86);
            this.chkTrasera.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkTrasera.Name = "chkTrasera";
            this.chkTrasera.Size = new System.Drawing.Size(81, 23);
            this.chkTrasera.TabIndex = 2;
            this.chkTrasera.Text = "Trasera";
            this.chkTrasera.UseVisualStyleBackColor = true;
            // 
            // chkPuertas
            // 
            this.chkPuertas.AutoSize = true;
            this.chkPuertas.Location = new System.Drawing.Point(27, 57);
            this.chkPuertas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkPuertas.Name = "chkPuertas";
            this.chkPuertas.Size = new System.Drawing.Size(80, 23);
            this.chkPuertas.TabIndex = 1;
            this.chkPuertas.Text = "Puertas";
            this.chkPuertas.UseVisualStyleBackColor = true;
            // 
            // chkDefensa
            // 
            this.chkDefensa.AutoSize = true;
            this.chkDefensa.Location = new System.Drawing.Point(27, 28);
            this.chkDefensa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkDefensa.Name = "chkDefensa";
            this.chkDefensa.Size = new System.Drawing.Size(84, 23);
            this.chkDefensa.TabIndex = 0;
            this.chkDefensa.Text = "Defensa";
            this.chkDefensa.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(238, 391);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 36);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.Text = "Modificar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbNumSerie
            // 
            this.cmbNumSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNumSerie.FormattingEnabled = true;
            this.cmbNumSerie.Location = new System.Drawing.Point(14, 80);
            this.cmbNumSerie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbNumSerie.Name = "cmbNumSerie";
            this.cmbNumSerie.Size = new System.Drawing.Size(174, 28);
            this.cmbNumSerie.TabIndex = 37;
            this.toolP.SetToolTip(this.cmbNumSerie, "Seleccione una opción");
            this.cmbNumSerie.SelectedIndexChanged += new System.EventHandler(this.cmbNumSerie_SelectedIndexChanged);
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(14, 248);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMarca.MaxLength = 100;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(184, 26);
            this.txtMarca.TabIndex = 38;
            this.toolP.SetToolTip(this.txtMarca, "Dato modificable");
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(488, 372);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSalir.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(372, 391);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(89, 36);
            this.btnSalir.TabIndex = 36;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmModificarAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(798, 458);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.cmbNumSerie);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblDetalles);
            this.Controls.Add(this.txtOtros);
            this.Controls.Add(this.lblOtros);
            this.Controls.Add(this.grpGolpes);
            this.Controls.Add(this.grpTipoTrans);
            this.Controls.Add(this.txtPropietario);
            this.Controls.Add(this.lblPropietario);
            this.Controls.Add(this.numupPasajeros);
            this.Controls.Add(this.txtNomAuto);
            this.Controls.Add(this.lblNumMaxPa);
            this.Controls.Add(this.Marca);
            this.Controls.Add(this.lblNomAuto);
            this.Controls.Add(this.lblNumSerie);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmModificarAuto";
            this.Text = "Modificar Auto";
            this.Load += new System.EventHandler(this.frmModificarAuto_Load);
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

        private System.Windows.Forms.TextBox txtPropietario;
        private System.Windows.Forms.Label lblPropietario;
        private System.Windows.Forms.NumericUpDown numupPasajeros;
        private System.Windows.Forms.TextBox txtNomAuto;
        private System.Windows.Forms.Label lblNumMaxPa;
        private System.Windows.Forms.Label Marca;
        private System.Windows.Forms.Label lblNomAuto;
        private System.Windows.Forms.Label lblNumSerie;
        private System.Windows.Forms.GroupBox grpTipoTrans;
        private System.Windows.Forms.RadioButton rdEstandar;
        private System.Windows.Forms.RadioButton rdAutomatica;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.TextBox txtOtros;
        private System.Windows.Forms.Label lblOtros;
        private System.Windows.Forms.GroupBox grpGolpes;
        private System.Windows.Forms.CheckBox chkTrasera;
        private System.Windows.Forms.CheckBox chkPuertas;
        private System.Windows.Forms.CheckBox chkDefensa;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cmbNumSerie;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.ErrorProvider errorP;
        private System.Windows.Forms.ToolTip toolP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
    }
}
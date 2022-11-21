namespace Carros
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNumSerie = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblNumPasajeros = new System.Windows.Forms.Label();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.nudPasajeros = new System.Windows.Forms.NumericUpDown();
            this.grpTransmision = new System.Windows.Forms.GroupBox();
            this.rdEstandar = new System.Windows.Forms.RadioButton();
            this.rdAutomatico = new System.Windows.Forms.RadioButton();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.grpDetalles = new System.Windows.Forms.GroupBox();
            this.chkTrasera = new System.Windows.Forms.CheckBox();
            this.chkPuertas = new System.Windows.Forms.CheckBox();
            this.chkDefensa = new System.Windows.Forms.CheckBox();
            this.lblOtros = new System.Windows.Forms.Label();
            this.txtOtros = new System.Windows.Forms.TextBox();
            this.toolP = new System.Windows.Forms.ToolTip(this.components);
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.picDetalles = new System.Windows.Forms.PictureBox();
            this.picTransmision = new System.Windows.Forms.PictureBox();
            this.picMarca = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasajeros)).BeginInit();
            this.grpTransmision.SuspendLayout();
            this.grpDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTransmision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumSerie
            // 
            this.lblNumSerie.AutoSize = true;
            this.lblNumSerie.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSerie.Location = new System.Drawing.Point(12, 9);
            this.lblNumSerie.Name = "lblNumSerie";
            this.lblNumSerie.Size = new System.Drawing.Size(163, 22);
            this.lblNumSerie.TabIndex = 0;
            this.lblNumSerie.Text = "Numero de Serie";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(13, 80);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(83, 22);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(19, 173);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(67, 22);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            // 
            // lblNumPasajeros
            // 
            this.lblNumPasajeros.AutoSize = true;
            this.lblNumPasajeros.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPasajeros.Location = new System.Drawing.Point(297, 7);
            this.lblNumPasajeros.Name = "lblNumPasajeros";
            this.lblNumPasajeros.Size = new System.Drawing.Size(147, 22);
            this.lblNumPasajeros.TabIndex = 3;
            this.lblNumPasajeros.Text = "Num Pasajeros";
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumSerie.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumSerie.Location = new System.Drawing.Point(16, 35);
            this.txtNumSerie.MaxLength = 8;
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(159, 26);
            this.txtNumSerie.TabIndex = 4;
            this.toolP.SetToolTip(this.txtNumSerie, "Ingrese los 8 Digitos del numero de serie");
            this.txtNumSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumSerie_KeyPress);
            this.txtNumSerie.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumSerie_Validating);
            this.txtNumSerie.Validated += new System.EventHandler(this.txtNumSerie_Validated);
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(16, 104);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(159, 26);
            this.txtNombre.TabIndex = 5;
            this.toolP.SetToolTip(this.txtNombre, "Ingrese el nombre o modelo");
            // 
            // cmbMarca
            // 
            this.cmbMarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMarca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "NISSAN",
            "CHEVROLET",
            "HYUNDAI",
            "FORD",
            "MAZDA"});
            this.cmbMarca.Location = new System.Drawing.Point(16, 197);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(159, 26);
            this.cmbMarca.TabIndex = 6;
            this.toolP.SetToolTip(this.cmbMarca, "Seleccion una opcion");
            this.cmbMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbMarca_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.btnGuardar.Location = new System.Drawing.Point(17, 382);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(198, 47);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.toolP.SetToolTip(this.btnGuardar, "Guardar auto");
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(0)))));
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.btnLimpiar.Location = new System.Drawing.Point(230, 383);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(114, 46);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.toolP.SetToolTip(this.btnLimpiar, "Limpiar campos");
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(0)))));
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.btnConsultar.Location = new System.Drawing.Point(356, 383);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(127, 46);
            this.btnConsultar.TabIndex = 9;
            this.btnConsultar.Text = "Consultar";
            this.toolP.SetToolTip(this.btnConsultar, "Consulta carro individual");
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(0)))));
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.btnSalir.Location = new System.Drawing.Point(495, 383);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(117, 46);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Regresar";
            this.toolP.SetToolTip(this.btnSalir, "Regresar al menu");
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // nudPasajeros
            // 
            this.nudPasajeros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudPasajeros.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPasajeros.Location = new System.Drawing.Point(301, 30);
            this.nudPasajeros.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPasajeros.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPasajeros.Name = "nudPasajeros";
            this.nudPasajeros.Size = new System.Drawing.Size(135, 26);
            this.nudPasajeros.TabIndex = 11;
            this.toolP.SetToolTip(this.nudPasajeros, "Ingrese No. de pasajeros");
            this.nudPasajeros.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grpTransmision
            // 
            this.grpTransmision.Controls.Add(this.rdEstandar);
            this.grpTransmision.Controls.Add(this.rdAutomatico);
            this.grpTransmision.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTransmision.Location = new System.Drawing.Point(301, 80);
            this.grpTransmision.Name = "grpTransmision";
            this.grpTransmision.Size = new System.Drawing.Size(200, 79);
            this.grpTransmision.TabIndex = 12;
            this.grpTransmision.TabStop = false;
            this.grpTransmision.Text = "Tipo de Transmision: ";
            this.toolP.SetToolTip(this.grpTransmision, "Seleccione una opcion");
            // 
            // rdEstandar
            // 
            this.rdEstandar.AutoSize = true;
            this.rdEstandar.Checked = true;
            this.rdEstandar.Location = new System.Drawing.Point(25, 42);
            this.rdEstandar.Name = "rdEstandar";
            this.rdEstandar.Size = new System.Drawing.Size(99, 22);
            this.rdEstandar.TabIndex = 1;
            this.rdEstandar.TabStop = true;
            this.rdEstandar.Text = "Estandar";
            this.rdEstandar.UseVisualStyleBackColor = true;
            // 
            // rdAutomatico
            // 
            this.rdAutomatico.AutoSize = true;
            this.rdAutomatico.Location = new System.Drawing.Point(25, 19);
            this.rdAutomatico.Name = "rdAutomatico";
            this.rdAutomatico.Size = new System.Drawing.Size(118, 22);
            this.rdAutomatico.TabIndex = 0;
            this.rdAutomatico.Text = "Automatico";
            this.rdAutomatico.UseVisualStyleBackColor = true;
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalles.Location = new System.Drawing.Point(297, 183);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(211, 22);
            this.lblDetalles.TabIndex = 13;
            this.lblDetalles.Text = "Detalles en carroceria";
            // 
            // grpDetalles
            // 
            this.grpDetalles.Controls.Add(this.chkTrasera);
            this.grpDetalles.Controls.Add(this.chkPuertas);
            this.grpDetalles.Controls.Add(this.chkDefensa);
            this.grpDetalles.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetalles.Location = new System.Drawing.Point(301, 207);
            this.grpDetalles.Name = "grpDetalles";
            this.grpDetalles.Size = new System.Drawing.Size(200, 102);
            this.grpDetalles.TabIndex = 13;
            this.grpDetalles.TabStop = false;
            this.grpDetalles.Text = "Golpes en: ";
            this.toolP.SetToolTip(this.grpDetalles, "Selecciona alguna opcion o especifique");
            // 
            // chkTrasera
            // 
            this.chkTrasera.AutoSize = true;
            this.chkTrasera.Location = new System.Drawing.Point(25, 68);
            this.chkTrasera.Name = "chkTrasera";
            this.chkTrasera.Size = new System.Drawing.Size(90, 22);
            this.chkTrasera.TabIndex = 2;
            this.chkTrasera.Text = "Trasera";
            this.chkTrasera.UseVisualStyleBackColor = true;
            // 
            // chkPuertas
            // 
            this.chkPuertas.AutoSize = true;
            this.chkPuertas.Location = new System.Drawing.Point(25, 48);
            this.chkPuertas.Name = "chkPuertas";
            this.chkPuertas.Size = new System.Drawing.Size(90, 22);
            this.chkPuertas.TabIndex = 1;
            this.chkPuertas.Text = "Puertas";
            this.chkPuertas.UseVisualStyleBackColor = true;
            // 
            // chkDefensa
            // 
            this.chkDefensa.AutoSize = true;
            this.chkDefensa.Location = new System.Drawing.Point(25, 30);
            this.chkDefensa.Name = "chkDefensa";
            this.chkDefensa.Size = new System.Drawing.Size(93, 22);
            this.chkDefensa.TabIndex = 0;
            this.chkDefensa.Text = "Defensa";
            this.chkDefensa.UseVisualStyleBackColor = true;
            // 
            // lblOtros
            // 
            this.lblOtros.AutoSize = true;
            this.lblOtros.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtros.Location = new System.Drawing.Point(297, 314);
            this.lblOtros.Name = "lblOtros";
            this.lblOtros.Size = new System.Drawing.Size(72, 22);
            this.lblOtros.TabIndex = 14;
            this.lblOtros.Text = "Otros: ";
            // 
            // txtOtros
            // 
            this.txtOtros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOtros.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtros.Location = new System.Drawing.Point(359, 314);
            this.txtOtros.MaxLength = 255;
            this.txtOtros.Name = "txtOtros";
            this.txtOtros.Size = new System.Drawing.Size(136, 26);
            this.txtOtros.TabIndex = 15;
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // picDetalles
            // 
            this.picDetalles.Image = global::Carros.Properties.Resources.detalles;
            this.picDetalles.Location = new System.Drawing.Point(510, 207);
            this.picDetalles.Name = "picDetalles";
            this.picDetalles.Size = new System.Drawing.Size(102, 109);
            this.picDetalles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDetalles.TabIndex = 16;
            this.picDetalles.TabStop = false;
            // 
            // picTransmision
            // 
            this.picTransmision.Image = global::Carros.Properties.Resources.transmision;
            this.picTransmision.Location = new System.Drawing.Point(523, 80);
            this.picTransmision.Name = "picTransmision";
            this.picTransmision.Size = new System.Drawing.Size(88, 84);
            this.picTransmision.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTransmision.TabIndex = 17;
            this.picTransmision.TabStop = false;
            // 
            // picMarca
            // 
            this.picMarca.Image = global::Carros.Properties.Resources.medalla;
            this.picMarca.Location = new System.Drawing.Point(181, 197);
            this.picMarca.Name = "picMarca";
            this.picMarca.Size = new System.Drawing.Size(95, 86);
            this.picMarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMarca.TabIndex = 17;
            this.picMarca.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.picMarca);
            this.Controls.Add(this.picTransmision);
            this.Controls.Add(this.picDetalles);
            this.Controls.Add(this.txtOtros);
            this.Controls.Add(this.lblOtros);
            this.Controls.Add(this.lblDetalles);
            this.Controls.Add(this.grpDetalles);
            this.Controls.Add(this.grpTransmision);
            this.Controls.Add(this.nudPasajeros);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNumSerie);
            this.Controls.Add(this.lblNumPasajeros);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNumSerie);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nudPasajeros)).EndInit();
            this.grpTransmision.ResumeLayout(false);
            this.grpTransmision.PerformLayout();
            this.grpDetalles.ResumeLayout(false);
            this.grpDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTransmision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumSerie;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblNumPasajeros;
        private System.Windows.Forms.TextBox txtNumSerie;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.NumericUpDown nudPasajeros;
        private System.Windows.Forms.GroupBox grpTransmision;
        private System.Windows.Forms.RadioButton rdEstandar;
        private System.Windows.Forms.RadioButton rdAutomatico;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.GroupBox grpDetalles;
        private System.Windows.Forms.CheckBox chkTrasera;
        private System.Windows.Forms.CheckBox chkPuertas;
        private System.Windows.Forms.CheckBox chkDefensa;
        private System.Windows.Forms.Label lblOtros;
        private System.Windows.Forms.TextBox txtOtros;
        private System.Windows.Forms.ToolTip toolP;
        private System.Windows.Forms.ErrorProvider errorP;
        private System.Windows.Forms.PictureBox picDetalles;
        private System.Windows.Forms.PictureBox picMarca;
        private System.Windows.Forms.PictureBox picTransmision;
    }
}


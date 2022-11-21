namespace Carros
{
    partial class frmConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsulta));
            this.btnSalir = new System.Windows.Forms.Button();
            this.cmbNumSerie = new System.Windows.Forms.ComboBox();
            this.lblNumSerie = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblTransmision = new System.Windows.Forms.Label();
            this.txtTransmision = new System.Windows.Forms.TextBox();
            this.lblNumeroPasajeros = new System.Windows.Forms.Label();
            this.txtNumPasajeros = new System.Windows.Forms.TextBox();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.rtxtDetalle = new System.Windows.Forms.RichTextBox();
            this.toolTCarro = new System.Windows.Forms.ToolTip(this.components);
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(0)))));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.btnSalir.Location = new System.Drawing.Point(478, 380);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(134, 49);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Regresar";
            this.toolTCarro.SetToolTip(this.btnSalir, "Regresar al menu");
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cmbNumSerie
            // 
            this.cmbNumSerie.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNumSerie.FormattingEnabled = true;
            this.cmbNumSerie.Location = new System.Drawing.Point(174, 22);
            this.cmbNumSerie.Name = "cmbNumSerie";
            this.cmbNumSerie.Size = new System.Drawing.Size(171, 26);
            this.cmbNumSerie.TabIndex = 1;
            this.toolTCarro.SetToolTip(this.cmbNumSerie, "Selecciona un numero de serie");
            this.cmbNumSerie.SelectedIndexChanged += new System.EventHandler(this.cmbNumSerie_SelectedIndexChanged);
            this.cmbNumSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbNumSerie_KeyPress);
            // 
            // lblNumSerie
            // 
            this.lblNumSerie.AutoSize = true;
            this.lblNumSerie.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSerie.Location = new System.Drawing.Point(12, 22);
            this.lblNumSerie.Name = "lblNumSerie";
            this.lblNumSerie.Size = new System.Drawing.Size(163, 22);
            this.lblNumSerie.TabIndex = 2;
            this.lblNumSerie.Text = "Numero de Serie";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 67);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(83, 22);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(12, 112);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(67, 22);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(119, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(226, 26);
            this.txtNombre.TabIndex = 5;
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(119, 112);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(226, 26);
            this.txtMarca.TabIndex = 6;
            // 
            // lblTransmision
            // 
            this.lblTransmision.AutoSize = true;
            this.lblTransmision.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransmision.Location = new System.Drawing.Point(12, 159);
            this.lblTransmision.Name = "lblTransmision";
            this.lblTransmision.Size = new System.Drawing.Size(121, 22);
            this.lblTransmision.TabIndex = 7;
            this.lblTransmision.Text = "Transmision";
            // 
            // txtTransmision
            // 
            this.txtTransmision.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransmision.Location = new System.Drawing.Point(174, 159);
            this.txtTransmision.Name = "txtTransmision";
            this.txtTransmision.ReadOnly = true;
            this.txtTransmision.Size = new System.Drawing.Size(171, 26);
            this.txtTransmision.TabIndex = 8;
            // 
            // lblNumeroPasajeros
            // 
            this.lblNumeroPasajeros.AutoSize = true;
            this.lblNumeroPasajeros.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPasajeros.Location = new System.Drawing.Point(12, 207);
            this.lblNumeroPasajeros.Name = "lblNumeroPasajeros";
            this.lblNumeroPasajeros.Size = new System.Drawing.Size(147, 22);
            this.lblNumeroPasajeros.TabIndex = 9;
            this.lblNumeroPasajeros.Text = "Num Pasajeros";
            // 
            // txtNumPasajeros
            // 
            this.txtNumPasajeros.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPasajeros.Location = new System.Drawing.Point(174, 211);
            this.txtNumPasajeros.Name = "txtNumPasajeros";
            this.txtNumPasajeros.ReadOnly = true;
            this.txtNumPasajeros.Size = new System.Drawing.Size(171, 26);
            this.txtNumPasajeros.TabIndex = 10;
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalles.Location = new System.Drawing.Point(14, 258);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(84, 22);
            this.lblDetalles.TabIndex = 11;
            this.lblDetalles.Text = "Detalles";
            // 
            // rtxtDetalle
            // 
            this.rtxtDetalle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDetalle.Location = new System.Drawing.Point(109, 263);
            this.rtxtDetalle.Name = "rtxtDetalle";
            this.rtxtDetalle.ReadOnly = true;
            this.rtxtDetalle.Size = new System.Drawing.Size(236, 96);
            this.rtxtDetalle.TabIndex = 12;
            this.rtxtDetalle.Text = "";
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(377, 42);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(235, 236);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 13;
            this.picLogo.TabStop = false;
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.rtxtDetalle);
            this.Controls.Add(this.lblDetalles);
            this.Controls.Add(this.txtNumPasajeros);
            this.Controls.Add(this.lblNumeroPasajeros);
            this.Controls.Add(this.txtTransmision);
            this.Controls.Add(this.lblTransmision);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNumSerie);
            this.Controls.Add(this.cmbNumSerie);
            this.Controls.Add(this.btnSalir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cmbNumSerie;
        private System.Windows.Forms.Label lblNumSerie;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblTransmision;
        private System.Windows.Forms.TextBox txtTransmision;
        private System.Windows.Forms.Label lblNumeroPasajeros;
        private System.Windows.Forms.TextBox txtNumPasajeros;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.RichTextBox rtxtDetalle;
        private System.Windows.Forms.ToolTip toolTCarro;
        private System.Windows.Forms.PictureBox picLogo;
    }
}

namespace Auto
{
    partial class frmConsultaAuto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaAuto));
            this.lblNumSer = new System.Windows.Forms.Label();
            this.lblNomAuto = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtNomAuto = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.cmbNumSerie = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblNumPasajeros = new System.Windows.Forms.Label();
            this.txtNumPasajeros = new System.Windows.Forms.TextBox();
            this.lblTransmision = new System.Windows.Forms.Label();
            this.txtTransmision = new System.Windows.Forms.TextBox();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.rchDetalleC = new System.Windows.Forms.RichTextBox();
            this.toolPC = new System.Windows.Forms.ToolTip(this.components);
            this.lblPropietario = new System.Windows.Forms.Label();
            this.txtPropietario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumSer
            // 
            this.lblNumSer.AutoSize = true;
            this.lblNumSer.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNumSer.Location = new System.Drawing.Point(32, 36);
            this.lblNumSer.Name = "lblNumSer";
            this.lblNumSer.Size = new System.Drawing.Size(190, 24);
            this.lblNumSer.TabIndex = 0;
            this.lblNumSer.Text = "Numero de Serie";
            // 
            // lblNomAuto
            // 
            this.lblNomAuto.AutoSize = true;
            this.lblNomAuto.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomAuto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNomAuto.Location = new System.Drawing.Point(32, 119);
            this.lblNomAuto.Name = "lblNomAuto";
            this.lblNomAuto.Size = new System.Drawing.Size(142, 24);
            this.lblNomAuto.TabIndex = 1;
            this.lblNomAuto.Text = "Nombre Auto";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMarca.Location = new System.Drawing.Point(32, 282);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(70, 24);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            // 
            // txtNomAuto
            // 
            this.txtNomAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomAuto.Location = new System.Drawing.Point(36, 153);
            this.txtNomAuto.MaxLength = 100;
            this.txtNomAuto.Name = "txtNomAuto";
            this.txtNomAuto.ReadOnly = true;
            this.txtNomAuto.Size = new System.Drawing.Size(186, 26);
            this.txtNomAuto.TabIndex = 3;
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(36, 309);
            this.txtMarca.MaxLength = 100;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(186, 26);
            this.txtMarca.TabIndex = 4;
            // 
            // cmbNumSerie
            // 
            this.cmbNumSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNumSerie.FormattingEnabled = true;
            this.cmbNumSerie.Location = new System.Drawing.Point(36, 73);
            this.cmbNumSerie.Name = "cmbNumSerie";
            this.cmbNumSerie.Size = new System.Drawing.Size(186, 28);
            this.cmbNumSerie.TabIndex = 5;
            this.toolPC.SetToolTip(this.cmbNumSerie, "Seleccione el numero de serie");
            this.cmbNumSerie.SelectedIndexChanged += new System.EventHandler(this.cmbNumSerie_SelectedIndexChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSalir.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(299, 371);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 35);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblNumPasajeros
            // 
            this.lblNumPasajeros.AutoSize = true;
            this.lblNumPasajeros.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPasajeros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNumPasajeros.Location = new System.Drawing.Point(265, 282);
            this.lblNumPasajeros.Name = "lblNumPasajeros";
            this.lblNumPasajeros.Size = new System.Drawing.Size(238, 24);
            this.lblNumPasajeros.TabIndex = 7;
            this.lblNumPasajeros.Text = "Numero de Pasajeros";
            // 
            // txtNumPasajeros
            // 
            this.txtNumPasajeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPasajeros.Location = new System.Drawing.Point(299, 309);
            this.txtNumPasajeros.MaxLength = 10;
            this.txtNumPasajeros.Name = "txtNumPasajeros";
            this.txtNumPasajeros.ReadOnly = true;
            this.txtNumPasajeros.Size = new System.Drawing.Size(165, 26);
            this.txtNumPasajeros.TabIndex = 8;
            // 
            // lblTransmision
            // 
            this.lblTransmision.AutoSize = true;
            this.lblTransmision.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransmision.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTransmision.Location = new System.Drawing.Point(265, 36);
            this.lblTransmision.Name = "lblTransmision";
            this.lblTransmision.Size = new System.Drawing.Size(238, 24);
            this.lblTransmision.TabIndex = 9;
            this.lblTransmision.Text = "Tipo de Transmisión";
            // 
            // txtTransmision
            // 
            this.txtTransmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransmision.Location = new System.Drawing.Point(299, 64);
            this.txtTransmision.MaxLength = 200;
            this.txtTransmision.Name = "txtTransmision";
            this.txtTransmision.ReadOnly = true;
            this.txtTransmision.Size = new System.Drawing.Size(165, 26);
            this.txtTransmision.TabIndex = 10;
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalles.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDetalles.Location = new System.Drawing.Point(265, 115);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(286, 24);
            this.lblDetalles.TabIndex = 11;
            this.lblDetalles.Text = "Detalles (Golpes en...)";
            this.toolPC.SetToolTip(this.lblDetalles, "Se presentan los golpes añadidos");
            // 
            // rchDetalleC
            // 
            this.rchDetalleC.Location = new System.Drawing.Point(299, 153);
            this.rchDetalleC.MaxLength = 200;
            this.rchDetalleC.Name = "rchDetalleC";
            this.rchDetalleC.ReadOnly = true;
            this.rchDetalleC.Size = new System.Drawing.Size(185, 96);
            this.rchDetalleC.TabIndex = 12;
            this.rchDetalleC.Text = "";
            // 
            // lblPropietario
            // 
            this.lblPropietario.AutoSize = true;
            this.lblPropietario.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropietario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPropietario.Location = new System.Drawing.Point(32, 202);
            this.lblPropietario.Name = "lblPropietario";
            this.lblPropietario.Size = new System.Drawing.Size(142, 24);
            this.lblPropietario.TabIndex = 13;
            this.lblPropietario.Text = "Propietario";
            // 
            // txtPropietario
            // 
            this.txtPropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropietario.Location = new System.Drawing.Point(36, 239);
            this.txtPropietario.MaxLength = 100;
            this.txtPropietario.Name = "txtPropietario";
            this.txtPropietario.ReadOnly = true;
            this.txtPropietario.Size = new System.Drawing.Size(186, 26);
            this.txtPropietario.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(425, 358);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // frmConsultaAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(549, 418);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPropietario);
            this.Controls.Add(this.lblPropietario);
            this.Controls.Add(this.rchDetalleC);
            this.Controls.Add(this.lblDetalles);
            this.Controls.Add(this.txtTransmision);
            this.Controls.Add(this.lblTransmision);
            this.Controls.Add(this.txtNumPasajeros);
            this.Controls.Add(this.lblNumPasajeros);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cmbNumSerie);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtNomAuto);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblNomAuto);
            this.Controls.Add(this.lblNumSer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaAuto";
            this.Text = "Consulta individual de autos";
            this.Load += new System.EventHandler(this.Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumSer;
        private System.Windows.Forms.Label lblNomAuto;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtNomAuto;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.ComboBox cmbNumSerie;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblNumPasajeros;
        private System.Windows.Forms.TextBox txtNumPasajeros;
        private System.Windows.Forms.Label lblTransmision;
        private System.Windows.Forms.TextBox txtTransmision;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.RichTextBox rchDetalleC;
        private System.Windows.Forms.ToolTip toolPC;
        private System.Windows.Forms.Label lblPropietario;
        private System.Windows.Forms.TextBox txtPropietario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
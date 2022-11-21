
namespace Auto
{
    partial class frmConsultaAutoServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaAutoServicio));
            this.lblFolio = new System.Windows.Forms.Label();
            this.cmbFolio = new System.Windows.Forms.ComboBox();
            this.lblAuto = new System.Windows.Forms.Label();
            this.lblServ = new System.Windows.Forms.Label();
            this.txtAutoNumSerie = new System.Windows.Forms.TextBox();
            this.txtServicioClave = new System.Windows.Forms.TextBox();
            this.txtServicioNombre = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.txtAutoNombre = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolP = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFolio.Location = new System.Drawing.Point(17, 29);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(60, 22);
            this.lblFolio.TabIndex = 24;
            this.lblFolio.Text = "Folio";
            // 
            // cmbFolio
            // 
            this.cmbFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFolio.FormattingEnabled = true;
            this.cmbFolio.Location = new System.Drawing.Point(21, 54);
            this.cmbFolio.Name = "cmbFolio";
            this.cmbFolio.Size = new System.Drawing.Size(186, 28);
            this.cmbFolio.TabIndex = 26;
            this.toolP.SetToolTip(this.cmbFolio, "Seleccione el Folio");
            this.cmbFolio.SelectedIndexChanged += new System.EventHandler(this.cmbFolio_SelectedIndexChanged);
            // 
            // lblAuto
            // 
            this.lblAuto.AutoSize = true;
            this.lblAuto.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAuto.Location = new System.Drawing.Point(17, 94);
            this.lblAuto.Name = "lblAuto";
            this.lblAuto.Size = new System.Drawing.Size(150, 22);
            this.lblAuto.TabIndex = 27;
            this.lblAuto.Text = "Datos del auto";
            // 
            // lblServ
            // 
            this.lblServ.AutoSize = true;
            this.lblServ.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServ.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblServ.Location = new System.Drawing.Point(17, 222);
            this.lblServ.Name = "lblServ";
            this.lblServ.Size = new System.Drawing.Size(190, 22);
            this.lblServ.TabIndex = 28;
            this.lblServ.Text = "Datos del servicio";
            // 
            // txtAutoNumSerie
            // 
            this.txtAutoNumSerie.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoNumSerie.Location = new System.Drawing.Point(21, 131);
            this.txtAutoNumSerie.MaxLength = 200;
            this.txtAutoNumSerie.Name = "txtAutoNumSerie";
            this.txtAutoNumSerie.ReadOnly = true;
            this.txtAutoNumSerie.Size = new System.Drawing.Size(186, 27);
            this.txtAutoNumSerie.TabIndex = 29;
            this.toolP.SetToolTip(this.txtAutoNumSerie, "Campo no modificable");
            // 
            // txtServicioClave
            // 
            this.txtServicioClave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicioClave.Location = new System.Drawing.Point(21, 263);
            this.txtServicioClave.MaxLength = 50;
            this.txtServicioClave.Name = "txtServicioClave";
            this.txtServicioClave.ReadOnly = true;
            this.txtServicioClave.Size = new System.Drawing.Size(186, 27);
            this.txtServicioClave.TabIndex = 30;
            this.toolP.SetToolTip(this.txtServicioClave, "Campo no modificable");
            // 
            // txtServicioNombre
            // 
            this.txtServicioNombre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicioNombre.Location = new System.Drawing.Point(21, 305);
            this.txtServicioNombre.MaxLength = 50;
            this.txtServicioNombre.Name = "txtServicioNombre";
            this.txtServicioNombre.ReadOnly = true;
            this.txtServicioNombre.Size = new System.Drawing.Size(186, 27);
            this.txtServicioNombre.TabIndex = 31;
            this.toolP.SetToolTip(this.txtServicioNombre, "Campo no modificable");
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(361, 247);
            this.txtFecha.MaxLength = 20;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(186, 27);
            this.txtFecha.TabIndex = 32;
            this.toolP.SetToolTip(this.txtFecha, "Fecha del servicio");
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(361, 311);
            this.txtPrecio.MaxLength = 10;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(186, 27);
            this.txtPrecio.TabIndex = 33;
            this.toolP.SetToolTip(this.txtPrecio, "Precio con descuento aplicado");
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFecha.Location = new System.Drawing.Point(357, 222);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(60, 22);
            this.lblFecha.TabIndex = 34;
            this.lblFecha.Text = "Fecha";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCosto.Location = new System.Drawing.Point(357, 286);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(70, 22);
            this.lblCosto.TabIndex = 35;
            this.lblCosto.Text = "Precio";
            // 
            // txtAutoNombre
            // 
            this.txtAutoNombre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoNombre.Location = new System.Drawing.Point(21, 178);
            this.txtAutoNombre.MaxLength = 50;
            this.txtAutoNombre.Name = "txtAutoNombre";
            this.txtAutoNombre.ReadOnly = true;
            this.txtAutoNombre.Size = new System.Drawing.Size(186, 27);
            this.txtAutoNombre.TabIndex = 36;
            this.toolP.SetToolTip(this.txtAutoNombre, "Campo no modificable");
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSalir.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(258, 362);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 34);
            this.btnSalir.TabIndex = 38;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(333, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(460, 126);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // frmConsultaAutoServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(661, 418);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtAutoNombre);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtServicioNombre);
            this.Controls.Add(this.txtServicioClave);
            this.Controls.Add(this.txtAutoNumSerie);
            this.Controls.Add(this.lblServ);
            this.Controls.Add(this.lblAuto);
            this.Controls.Add(this.cmbFolio);
            this.Controls.Add(this.lblFolio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmConsultaAutoServicio";
            this.Text = "Consulta Auto Servicio";
            this.Load += new System.EventHandler(this.frmConsultaAutoServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.ComboBox cmbFolio;
        private System.Windows.Forms.Label lblAuto;
        private System.Windows.Forms.Label lblServ;
        private System.Windows.Forms.TextBox txtAutoNumSerie;
        private System.Windows.Forms.TextBox txtServicioClave;
        private System.Windows.Forms.TextBox txtServicioNombre;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox txtAutoNombre;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolP;
    }
}
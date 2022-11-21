
namespace Carros
{
    partial class frmReporteIndividual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteIndividual));
            this.lblFolio = new System.Windows.Forms.Label();
            this.cmbFolio = new System.Windows.Forms.ComboBox();
            this.lblNumServicio = new System.Windows.Forms.Label();
            this.lblNombreAuto = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblNombreServicio = new System.Windows.Forms.Label();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.txtNombreAuto = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtNomServicio = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.picFondo = new System.Windows.Forms.PictureBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.toolT = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolio.Location = new System.Drawing.Point(31, 35);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(53, 22);
            this.lblFolio.TabIndex = 0;
            this.lblFolio.Text = "Folio";
            // 
            // cmbFolio
            // 
            this.cmbFolio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFolio.FormattingEnabled = true;
            this.cmbFolio.Location = new System.Drawing.Point(100, 35);
            this.cmbFolio.Name = "cmbFolio";
            this.cmbFolio.Size = new System.Drawing.Size(143, 26);
            this.cmbFolio.TabIndex = 1;
            this.toolT.SetToolTip(this.cmbFolio, "Seleccione un folio");
            this.cmbFolio.SelectedIndexChanged += new System.EventHandler(this.cmbFolio_SelectedIndexChanged);
            this.cmbFolio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbFolio_KeyPress);
            // 
            // lblNumServicio
            // 
            this.lblNumServicio.AutoSize = true;
            this.lblNumServicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumServicio.Location = new System.Drawing.Point(31, 96);
            this.lblNumServicio.Name = "lblNumServicio";
            this.lblNumServicio.Size = new System.Drawing.Size(135, 22);
            this.lblNumServicio.TabIndex = 2;
            this.lblNumServicio.Text = "Numero Serie";
            // 
            // lblNombreAuto
            // 
            this.lblNombreAuto.AutoSize = true;
            this.lblNombreAuto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAuto.Location = new System.Drawing.Point(31, 134);
            this.lblNombreAuto.Name = "lblNombreAuto";
            this.lblNombreAuto.Size = new System.Drawing.Size(131, 22);
            this.lblNombreAuto.TabIndex = 2;
            this.lblNombreAuto.Text = "Nombre Auto";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(31, 177);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(140, 22);
            this.lblClave.TabIndex = 2;
            this.lblClave.Text = "Clave Servicio";
            // 
            // lblNombreServicio
            // 
            this.lblNombreServicio.AutoSize = true;
            this.lblNombreServicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreServicio.Location = new System.Drawing.Point(31, 218);
            this.lblNombreServicio.Name = "lblNombreServicio";
            this.lblNombreServicio.Size = new System.Drawing.Size(162, 22);
            this.lblNombreServicio.TabIndex = 2;
            this.lblNombreServicio.Text = "Nombre Servicio";
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumSerie.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumSerie.Location = new System.Drawing.Point(172, 96);
            this.txtNumSerie.MaxLength = 255;
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.ReadOnly = true;
            this.txtNumSerie.Size = new System.Drawing.Size(186, 26);
            this.txtNumSerie.TabIndex = 3;
            // 
            // txtNombreAuto
            // 
            this.txtNombreAuto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreAuto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreAuto.Location = new System.Drawing.Point(172, 134);
            this.txtNombreAuto.MaxLength = 255;
            this.txtNombreAuto.Name = "txtNombreAuto";
            this.txtNombreAuto.ReadOnly = true;
            this.txtNombreAuto.Size = new System.Drawing.Size(186, 26);
            this.txtNombreAuto.TabIndex = 4;
            // 
            // txtClave
            // 
            this.txtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(177, 177);
            this.txtClave.MaxLength = 255;
            this.txtClave.Name = "txtClave";
            this.txtClave.ReadOnly = true;
            this.txtClave.Size = new System.Drawing.Size(181, 26);
            this.txtClave.TabIndex = 5;
            // 
            // txtNomServicio
            // 
            this.txtNomServicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomServicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomServicio.Location = new System.Drawing.Point(199, 218);
            this.txtNomServicio.MaxLength = 255;
            this.txtNomServicio.Name = "txtNomServicio";
            this.txtNomServicio.ReadOnly = true;
            this.txtNomServicio.Size = new System.Drawing.Size(159, 26);
            this.txtNomServicio.TabIndex = 6;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(393, 35);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(65, 22);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(464, 35);
            this.txtFecha.MaxLength = 255;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(148, 26);
            this.txtFecha.TabIndex = 3;
            // 
            // picFondo
            // 
            this.picFondo.Image = global::Carros.Properties.Resources.estacionamiento;
            this.picFondo.Location = new System.Drawing.Point(375, 96);
            this.picFondo.Name = "picFondo";
            this.picFondo.Size = new System.Drawing.Size(229, 254);
            this.picFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFondo.TabIndex = 7;
            this.picFondo.TabStop = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(206)))), ((int)(((byte)(0)))));
            this.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.btnRegresar.Location = new System.Drawing.Point(486, 377);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(118, 52);
            this.btnRegresar.TabIndex = 8;
            this.btnRegresar.Text = "Regresar";
            this.toolT.SetToolTip(this.btnRegresar, "Regresar al menu");
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // frmReporteIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.picFondo);
            this.Controls.Add(this.txtNomServicio);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtNombreAuto);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtNumSerie);
            this.Controls.Add(this.lblNombreServicio);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblNombreAuto);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNumServicio);
            this.Controls.Add(this.cmbFolio);
            this.Controls.Add(this.lblFolio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReporteIndividual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Individual";
            this.Load += new System.EventHandler(this.frmReporteIndividual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.ComboBox cmbFolio;
        private System.Windows.Forms.Label lblNumServicio;
        private System.Windows.Forms.Label lblNombreAuto;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblNombreServicio;
        private System.Windows.Forms.TextBox txtNumSerie;
        private System.Windows.Forms.TextBox txtNombreAuto;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtNomServicio;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.PictureBox picFondo;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ToolTip toolT;
    }
}
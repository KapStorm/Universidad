
namespace Carros
{
    partial class frmAgregarServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarServicio));
            this.lblClaveServicio = new System.Windows.Forms.Label();
            this.lblNomServicio = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.txtClaveServicio = new System.Windows.Forms.TextBox();
            this.txtNomServicio = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.errorPServicio = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTServicio = new System.Windows.Forms.ToolTip(this.components);
            this.picServicio = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorPServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picServicio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClaveServicio
            // 
            this.lblClaveServicio.AutoSize = true;
            this.lblClaveServicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveServicio.Location = new System.Drawing.Point(12, 35);
            this.lblClaveServicio.Name = "lblClaveServicio";
            this.lblClaveServicio.Size = new System.Drawing.Size(165, 22);
            this.lblClaveServicio.TabIndex = 0;
            this.lblClaveServicio.Text = "Clave de servicio";
            // 
            // lblNomServicio
            // 
            this.lblNomServicio.AutoSize = true;
            this.lblNomServicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomServicio.Location = new System.Drawing.Point(12, 120);
            this.lblNomServicio.Name = "lblNomServicio";
            this.lblNomServicio.Size = new System.Drawing.Size(187, 22);
            this.lblNomServicio.TabIndex = 1;
            this.lblNomServicio.Text = "Nombre de servicio";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(12, 197);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(63, 22);
            this.lblCosto.TabIndex = 2;
            this.lblCosto.Text = "Costo";
            // 
            // txtClaveServicio
            // 
            this.txtClaveServicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClaveServicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveServicio.Location = new System.Drawing.Point(16, 58);
            this.txtClaveServicio.MaxLength = 5;
            this.txtClaveServicio.Name = "txtClaveServicio";
            this.txtClaveServicio.Size = new System.Drawing.Size(161, 26);
            this.txtClaveServicio.TabIndex = 3;
            this.toolTServicio.SetToolTip(this.txtClaveServicio, "Ingrese clave de 5 digitos");
            this.txtClaveServicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveServicio_KeyPress);
            this.txtClaveServicio.Validating += new System.ComponentModel.CancelEventHandler(this.txtClaveServicio_Validating);
            this.txtClaveServicio.Validated += new System.EventHandler(this.txtClaveServicio_Validated);
            // 
            // txtNomServicio
            // 
            this.txtNomServicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomServicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomServicio.Location = new System.Drawing.Point(16, 143);
            this.txtNomServicio.MaxLength = 30;
            this.txtNomServicio.Name = "txtNomServicio";
            this.txtNomServicio.Size = new System.Drawing.Size(161, 26);
            this.txtNomServicio.TabIndex = 4;
            this.toolTServicio.SetToolTip(this.txtNomServicio, "Ingrese el nombre del servicio");
            // 
            // txtCosto
            // 
            this.txtCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCosto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Location = new System.Drawing.Point(16, 220);
            this.txtCosto.MaxLength = 10;
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(161, 26);
            this.txtCosto.TabIndex = 5;
            this.toolTServicio.SetToolTip(this.txtCosto, "Ingrese el costo del servicio");
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
            this.txtCosto.Validating += new System.ComponentModel.CancelEventHandler(this.txtCosto_Validating);
            this.txtCosto.Validated += new System.EventHandler(this.txtCosto_Validated);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(0)))));
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.btnAgregar.Location = new System.Drawing.Point(12, 383);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(198, 47);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.toolTServicio.SetToolTip(this.btnAgregar, "Agregar servicio");
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(0)))));
            this.btnConsulta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.btnConsulta.Location = new System.Drawing.Point(237, 383);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(123, 46);
            this.btnConsulta.TabIndex = 7;
            this.btnConsulta.Text = "Consultar";
            this.toolTServicio.SetToolTip(this.btnConsulta, "Consultar Servicio");
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
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
            this.btnLimpiar.Location = new System.Drawing.Point(366, 383);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(114, 46);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.toolTServicio.SetToolTip(this.btnLimpiar, "Limpiar campos");
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(0)))));
            this.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.btnRegresar.Location = new System.Drawing.Point(495, 383);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(114, 46);
            this.btnRegresar.TabIndex = 9;
            this.btnRegresar.Text = "Regresar";
            this.toolTServicio.SetToolTip(this.btnRegresar, "Regresar al menu");
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // errorPServicio
            // 
            this.errorPServicio.ContainerControl = this;
            // 
            // picServicio
            // 
            this.picServicio.Image = global::Carros.Properties.Resources.servicio;
            this.picServicio.Location = new System.Drawing.Point(283, 45);
            this.picServicio.Name = "picServicio";
            this.picServicio.Size = new System.Drawing.Size(311, 249);
            this.picServicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picServicio.TabIndex = 10;
            this.picServicio.TabStop = false;
            // 
            // frmAgregarServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.picServicio);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtNomServicio);
            this.Controls.Add(this.txtClaveServicio);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblNomServicio);
            this.Controls.Add(this.lblClaveServicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Servicio";
            ((System.ComponentModel.ISupportInitialize)(this.errorPServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picServicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClaveServicio;
        private System.Windows.Forms.Label lblNomServicio;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox txtClaveServicio;
        private System.Windows.Forms.TextBox txtNomServicio;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ErrorProvider errorPServicio;
        private System.Windows.Forms.ToolTip toolTServicio;
        private System.Windows.Forms.PictureBox picServicio;
    }
}

namespace Carros
{
    partial class frmAcercade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcercade));
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblNumeroControl = new System.Windows.Forms.Label();
            this.lblFrase = new System.Windows.Forms.Label();
            this.picFotografia = new System.Windows.Forms.PictureBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.toolT = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picFotografia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombres.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(281, 135);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(166, 48);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Text = "CASTRO CRUZ\r\n LUIS DANIEL";
            // 
            // lblNumeroControl
            // 
            this.lblNumeroControl.AutoSize = true;
            this.lblNumeroControl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNumeroControl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroControl.Location = new System.Drawing.Point(282, 203);
            this.lblNumeroControl.Name = "lblNumeroControl";
            this.lblNumeroControl.Size = new System.Drawing.Size(88, 18);
            this.lblNumeroControl.TabIndex = 2;
            this.lblNumeroControl.Text = "20170627";
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFrase.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrase.Location = new System.Drawing.Point(282, 250);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(205, 36);
            this.lblFrase.TabIndex = 3;
            this.lblFrase.Text = "Vale mas un buen\r\nque aprobar una materia";
            // 
            // picFotografia
            // 
            this.picFotografia.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picFotografia.Image = global::Carros.Properties.Resources.Daniel1;
            this.picFotografia.Location = new System.Drawing.Point(100, 115);
            this.picFotografia.Name = "picFotografia";
            this.picFotografia.Size = new System.Drawing.Size(153, 171);
            this.picFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFotografia.TabIndex = 4;
            this.picFotografia.TabStop = false;
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackgroundImage = global::Carros.Properties.Resources.siguiente;
            this.btnContinuar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnContinuar.FlatAppearance.BorderSize = 0;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Location = new System.Drawing.Point(519, 185);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(71, 56);
            this.btnContinuar.TabIndex = 5;
            this.toolT.SetToolTip(this.btnContinuar, "Siguiente integrante");
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackgroundImage = global::Carros.Properties.Resources.anterior;
            this.btnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Location = new System.Drawing.Point(2, 185);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(60, 57);
            this.btnAnterior.TabIndex = 5;
            this.toolT.SetToolTip(this.btnAnterior, "Anterior Integrante");
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // frmAcercade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(191)))));
            this.BackgroundImage = global::Carros.Properties.Resources.integrantes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.picFotografia);
            this.Controls.Add(this.lblFrase);
            this.Controls.Add(this.lblNumeroControl);
            this.Controls.Add(this.lblNombres);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAcercade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca de";
            this.Load += new System.EventHandler(this.frmAcercade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFotografia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNoControl;
        private System.Windows.Forms.Label lblFrases;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblNumeroControl;
        private System.Windows.Forms.Label lblFrase;
        private System.Windows.Forms.PictureBox picFotografia;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.ToolTip toolT;
    }
}
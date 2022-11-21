namespace EjemploComboBox
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
            this.cmbLenguajes = new System.Windows.Forms.ComboBox();
            this.lblLenguajes = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblAgregar = new System.Windows.Forms.Label();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbLenguajes
            // 
            this.cmbLenguajes.FormattingEnabled = true;
            this.cmbLenguajes.Items.AddRange(new object[] {
            "C#",
            "Java",
            "Python",
            "JavaScript"});
            this.cmbLenguajes.Location = new System.Drawing.Point(129, 44);
            this.cmbLenguajes.Name = "cmbLenguajes";
            this.cmbLenguajes.Size = new System.Drawing.Size(121, 21);
            this.cmbLenguajes.TabIndex = 0;
            // 
            // lblLenguajes
            // 
            this.lblLenguajes.AutoSize = true;
            this.lblLenguajes.Location = new System.Drawing.Point(51, 47);
            this.lblLenguajes.Name = "lblLenguajes";
            this.lblLenguajes.Size = new System.Drawing.Size(56, 13);
            this.lblLenguajes.TabIndex = 1;
            this.lblLenguajes.Text = "Lenguajes";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(95, 91);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblAgregar
            // 
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.Location = new System.Drawing.Point(118, 124);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(0, 13);
            this.lblAgregar.TabIndex = 3;
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Location = new System.Drawing.Point(121, 151);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(0, 13);
            this.lblPosicion.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 165);
            this.Controls.Add(this.lblPosicion);
            this.Controls.Add(this.lblAgregar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblLenguajes);
            this.Controls.Add(this.cmbLenguajes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLenguajes;
        private System.Windows.Forms.Label lblLenguajes;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblAgregar;
        private System.Windows.Forms.Label lblPosicion;
    }
}


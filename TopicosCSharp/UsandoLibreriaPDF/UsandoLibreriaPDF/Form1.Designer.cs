namespace UsandoLibreriaPDF
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
            this.btnGeneraPDF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGeneraPDF
            // 
            this.btnGeneraPDF.Location = new System.Drawing.Point(338, 196);
            this.btnGeneraPDF.Name = "btnGeneraPDF";
            this.btnGeneraPDF.Size = new System.Drawing.Size(75, 23);
            this.btnGeneraPDF.TabIndex = 0;
            this.btnGeneraPDF.Text = "Genera PDF";
            this.btnGeneraPDF.UseVisualStyleBackColor = true;
            this.btnGeneraPDF.Click += new System.EventHandler(this.btnGeneraPDF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGeneraPDF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGeneraPDF;
    }
}


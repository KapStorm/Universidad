namespace Choferes.Front
{
    partial class FrmConsultarVisitantesTodos
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
            this.dgvVisitantes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitantes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVisitantes
            // 
            this.dgvVisitantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisitantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVisitantes.Location = new System.Drawing.Point(0, 0);
            this.dgvVisitantes.Name = "dgvVisitantes";
            this.dgvVisitantes.ReadOnly = true;
            this.dgvVisitantes.Size = new System.Drawing.Size(800, 450);
            this.dgvVisitantes.TabIndex = 0;
            // 
            // FrmConsultarVisitantesTodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvVisitantes);
            this.Name = "FrmConsultarVisitantesTodos";
            this.Text = "Consulta Todos los Visitantes";
            this.Load += new System.EventHandler(this.FrmConsultarVisitantesTodos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVisitantes;
    }
}
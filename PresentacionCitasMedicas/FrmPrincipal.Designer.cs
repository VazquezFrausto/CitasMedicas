namespace PresentacionCitasMedicas
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.optMedicos = new System.Windows.Forms.ToolStrip();
            this.optMedic = new System.Windows.Forms.ToolStripButton();
            this.optPacientes = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.optSalir = new System.Windows.Forms.ToolStripButton();
            this.optMedicos.SuspendLayout();
            this.SuspendLayout();
            // 
            // optMedicos
            // 
            this.optMedicos.Dock = System.Windows.Forms.DockStyle.Left;
            this.optMedicos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optMedic,
            this.optPacientes,
            this.toolStripButton3,
            this.optSalir});
            this.optMedicos.Location = new System.Drawing.Point(0, 0);
            this.optMedicos.Name = "optMedicos";
            this.optMedicos.Size = new System.Drawing.Size(41, 460);
            this.optMedicos.TabIndex = 1;
            this.optMedicos.Text = "toolStrip1";
            // 
            // optMedic
            // 
            this.optMedic.AutoSize = false;
            this.optMedic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.optMedic.Image = ((System.Drawing.Image)(resources.GetObject("optMedic.Image")));
            this.optMedic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optMedic.Name = "optMedic";
            this.optMedic.Size = new System.Drawing.Size(40, 40);
            this.optMedic.Text = "Médicos";
            this.optMedic.Click += new System.EventHandler(this.optMedic_Click);
            // 
            // optPacientes
            // 
            this.optPacientes.AutoSize = false;
            this.optPacientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.optPacientes.Image = ((System.Drawing.Image)(resources.GetObject("optPacientes.Image")));
            this.optPacientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optPacientes.Name = "optPacientes";
            this.optPacientes.Size = new System.Drawing.Size(40, 40);
            this.optPacientes.Text = "Pacientes";
            this.optPacientes.Click += new System.EventHandler(this.optPacientes_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(40, 40);
            this.toolStripButton3.Text = "Citas";
            // 
            // optSalir
            // 
            this.optSalir.AutoSize = false;
            this.optSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.optSalir.Image = ((System.Drawing.Image)(resources.GetObject("optSalir.Image")));
            this.optSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optSalir.Name = "optSalir";
            this.optSalir.Size = new System.Drawing.Size(40, 40);
            this.optSalir.Text = "Salir";
            this.optSalir.Click += new System.EventHandler(this.optSalir_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 460);
            this.Controls.Add(this.optMedicos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.optMedicos.ResumeLayout(false);
            this.optMedicos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip optMedicos;
        private System.Windows.Forms.ToolStripButton optMedic;
        private System.Windows.Forms.ToolStripButton optPacientes;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton optSalir;
    }
}
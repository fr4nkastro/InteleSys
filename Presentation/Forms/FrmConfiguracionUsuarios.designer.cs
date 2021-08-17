
namespace Presentation.Forms
{
    partial class FrmConfiguracionUsuarios
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
            this.panelToolBar = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelToolBar
            // 
            this.panelToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelToolBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelToolBar.Location = new System.Drawing.Point(0, 0);
            this.panelToolBar.Name = "panelToolBar";
            this.panelToolBar.Size = new System.Drawing.Size(600, 366);
            this.panelToolBar.TabIndex = 0;
            this.panelToolBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FrmConfiguracionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panelToolBar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmConfiguracionUsuarios";
            this.Text = "Configuracion de Usuario";
            this.Load += new System.EventHandler(this.FrmConfiguracionUsuarios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelToolBar;
    }
}
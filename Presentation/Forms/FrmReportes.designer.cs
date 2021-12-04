
namespace Presentation.Forms
{
    partial class FrmReportes
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bdReportes = new Presentation.Reports.BDReportes();
            this.bindingSourceInv = new System.Windows.Forms.BindingSource(this.components);
            this.sp_inventario_generalTableAdapter = new Presentation.Reports.BDReportesTableAdapters.sp_inventario_generalTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInv)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Seleccione un reporte"});
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(842, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(842, 27);
            this.panel2.TabIndex = 2;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentation.Reports.mensualDeInventario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 27);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(842, 445);
            this.reportViewer1.TabIndex = 3;
            // 
            // bdReportes
            // 
            this.bdReportes.DataSetName = "BDReportes";
            this.bdReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSourceInv
            // 
            this.bindingSourceInv.DataMember = "sp_inventario_general";
            this.bindingSourceInv.DataSource = this.bdReportes;
            // 
            // sp_inventario_generalTableAdapter
            // 
            this.sp_inventario_generalTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 472);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmReportes";
            this.Text = "frmReportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Reports.BDReportes bdReportes;
        private System.Windows.Forms.BindingSource bindingSourceInv;
        private Reports.BDReportesTableAdapters.sp_inventario_generalTableAdapter sp_inventario_generalTableAdapter;
    }
}
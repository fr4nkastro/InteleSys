using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdReportes1.sp_inventario_general' Puede moverla o quitarla según sea necesario.
            this.sp_inventario_generalTableAdapter.Fill(this.bdReportes.sp_inventario_general);
            this.reportViewer1.RefreshReport();

            this.reportViewer1.LocalReport.DataSources.Clear();
            string relativpath = "../../Reports/mensualDeInventario.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSetInventario", bindingSourceInv);
            this.sp_inventario_generalTableAdapter.Fill(this.bdReportes.sp_inventario_general);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.ReportPath = this.reportViewer1.LocalReport.ReportPath = Path.GetFullPath(relativpath);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();

        }
    }
}

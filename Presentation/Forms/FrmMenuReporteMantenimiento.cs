using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class FrmMenuReporteMantenimiento : Form
    {
        public FrmMenuReporteMantenimiento()
        {
            InitializeComponent();
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Buscar Reporte en Mantenimiento...")
            {
                textBoxSearch.Text = "";
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Trim() == "")
            {
                textBoxSearch.Text = "Buscar Reporte en Mantenimiento...";
            }
        }
        private void FrmMenuReporteMantenimiento_Load(object sender, EventArgs e)
        {
            textBoxSearch.Text = "Buscar Reporte en Mantenimiento...";
            comboBoxFilters.Text = "Seleccione un filtro...";

        }

        private void comboBoxFiltros_Enter(object sender, EventArgs e)
        {
            if (comboBoxFilters.Text == "Seleccione un filtro")
            {
                comboBoxFilters.Text = "";
                comboBoxFilters.ForeColor = Color.Black;
            }
        }

        private void comboBoxFiltros_Leave(object sender, EventArgs e)
        {
            if (comboBoxFilters.Text == "")
            {
                comboBoxFilters.Text = "Seleccione un filtro";
                comboBoxFilters.ForeColor = Color.DimGray;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

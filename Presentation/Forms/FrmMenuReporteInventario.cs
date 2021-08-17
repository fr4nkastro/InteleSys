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
    public partial class FrmMenuReporteInventario : Form
    {
        public FrmMenuReporteInventario()
        {
            InitializeComponent();
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Buscar Reporte...")
            {
                textBoxSearch.Text = "";
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Trim() == "")
            {
                textBoxSearch.Text = "Buscar Reporte...";
            }
        }
        private void FrmMenuReporteInventario_Load(object sender, EventArgs e)
        {
            textBoxSearch.Text = "Buscar Reporte...";
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
    }
}

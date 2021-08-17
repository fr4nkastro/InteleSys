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
    public partial class FrmMenuReportes : Form
    {
        public FrmMenuReportes()
        {
            InitializeComponent();
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Busqueda de reportes...")
            {
                textBoxSearch.Text = "";
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Trim() == "")
            {
                textBoxSearch.Text = "Busqueda de reportes...";
            }
        }
        private void FrmMenuReporteMantenimiento_Load(object sender, EventArgs e)
        {
            textBoxSearch.Text = "Busqueda de reportes...";
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

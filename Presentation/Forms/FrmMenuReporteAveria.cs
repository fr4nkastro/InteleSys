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
    public partial class FrmMenuReporteAveria : Form
    {
        public FrmMenuReporteAveria()
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
        private void FrmMenuReporteAveria_Load(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

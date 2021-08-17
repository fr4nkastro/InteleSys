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
    public partial class FrmMenuMantenimiento : Form
    {
        public FrmMantenimientoDetallado formParent { get; set; }

        public FrmMenuMantenimiento(FrmMantenimientoDetallado formParent)
        {
            InitializeComponent();
            this.formParent = formParent;
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Buscar Registro...")
            {
                textBoxSearch.Text = "";
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Trim() == "")
            {
                textBoxSearch.Text = "Buscar Registro...";
            }
        }
        private void FrmMenuMantenimiento_Load(object sender, EventArgs e)
        {
            textBoxSearch.Text = "Buscar Registro...";
            comboBoxFilters.Text = "Seleccione un filtro...";
            //comboBoxFilters.DataSource = formParent.MantenimientoFecha.GetMaquina();


        }

        private void panel1_Enter(object sender, EventArgs e)
        {
            
        }

        private void comboBoxFilters_Enter(object sender, EventArgs e)
        {
           if(comboBoxFilters.Text=="Seleccione un filtro...")
            {
                comboBoxFilters.Text= "";
            }
        }

        private void comboBoxFilters_Leave(object sender, EventArgs e)
        {
            if (comboBoxFilters.Text.Trim() == "")
                comboBoxFilters.Text = "Seleccione un filtro...";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            //formParent.dataGridView1.DataSource = formParent.Averias.repository.Search2((comboBoxFilters.SelectedIndex+1).ToString());
        }
    }
}

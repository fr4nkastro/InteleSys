using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation.Forms;

namespace Presentation.Forms
{
    
    public partial class FrmMenuConfiguracionUsuarios : Form
    {
        private Form FormActual;
        
        public FrmMenuConfiguracionUsuarios(Form formParent)
        {
            InitializeComponent();
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Buscar Usuario...")
            {
                textBoxSearch.Text = "";
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Trim() == "")
            {
                textBoxSearch.Text = "Buscar Usuario...";
            }
        }
        private void FrmMenuConfiguracionUsuarios_Load(object sender, EventArgs e)
        {
            textBoxSearch.Text = "Buscar Usuario...";
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

        private void button2_Click(object sender, EventArgs e)
        {
            FrmIngresoUsuario fiu = new FrmIngresoUsuario();
            fiu.Show();
            //OpenForm(new FrmIngresoUsuario());
            

        }
        private void OpenForm(Form FormHijo)
        {
            if (FormActual != null)
            {
                //Mantener un solo form
                FormActual.Close();
            }
            FrmIngresoUsuario f = new FrmIngresoUsuario();
            FormHome fh = new FormHome();
            FormActual = FormHijo;
            FormHijo.TopLevel = false; 
            FormHijo.FormBorderStyle = FormBorderStyle.None;
            FormHijo.Dock = DockStyle.Fill;
            fh.panelMainFrm.Controls.Add(FormHijo);
            fh.panelMainFrm.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();
            fh.Refresh();
            fh.Show();
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmIngresoUsuario fiu = new FrmIngresoUsuario();
            fiu.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Models;
namespace Presentation.Forms
{
    public partial class FrmMenuMantenimiento : Form
    {
        public DateTime selectDate;
        public DateTime startDate;
        public DateTime endDate;
        public FrmMantenimientoDetallado frmParent;
        private ModelDTOMantenimiento objDTOMantenimiento;
        public FrmMenuMantenimiento()
        {
            InitializeComponent();
            //selectDate= Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());
            selectDate = DateTime.Now;
            startDate= selectDate.AddDays(-3);
            endDate= selectDate.AddDays(3);
            objDTOMantenimiento = new ModelDTOMantenimiento();
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
            comboBoxFechas.DataSource = objDTOMantenimiento.GetMantenimientoFechas(startDate.ToShortDateString(), endDate.ToShortDateString());
            
            textBoxSearch.Text = "Buscar Registro...";
            comboBoxFechas.Text = "Seleccione un filtro...";
            
        }

        private void panel1_Enter(object sender, EventArgs e)
        {
            
        }

        private void comboBoxFilters_Enter(object sender, EventArgs e)
        {
           if(comboBoxFechas.Text=="Seleccione un filtro...")
            {
                comboBoxFechas.Text= "";
            }
        }

        private void comboBoxFilters_Leave(object sender, EventArgs e)
        {
            if (comboBoxFechas.Text.Trim() == "")
                comboBoxFechas.Text = "Seleccione un filtro...";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            selectDate = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());
            comboBoxFechas.DataSource = objDTOMantenimiento.GetMantenimientoFechas(startDate.ToShortDateString(), endDate.ToShortDateString());
        }
    }
}

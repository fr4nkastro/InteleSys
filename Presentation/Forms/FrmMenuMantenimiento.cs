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
        
        public FrmMantenimientoDetallado frmParent;
        public ModelMantenimiento objModelMantenimiento;
        public ModelRegMantenimientoMqns objModelRegMantenimientoMqns;
        DateTime startDate;
        DateTime endDate;
        int Validacion;
        //private ModelDTOMantenimiento objDTOMantenimiento;
        public FrmMenuMantenimiento()
        {
            InitializeComponent();
            objModelMantenimiento = new ModelMantenimiento();
            objModelRegMantenimientoMqns = new ModelRegMantenimientoMqns();
            //selectDate= Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());

            //objDTOMantenimiento = new ModelDTOMantenimiento();
        }



        private void FrmMenuMantenimiento_Load(object sender, EventArgs e)
        {
            
            
           
            
            
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startDate = dateTimePickerStart.Value;
            endDate = dateTimePickerEnd.Value;
            comboBoxFechas.DataSource = objModelMantenimiento.listFechasMantenimiento(startDate, endDate);
            Validacion = 1;

        }

        private void comboBoxFechas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            decimal mantenimientoId= objModelMantenimiento.lstMantenimiento[comboBoxFechas.SelectedIndex].id;
            frmParent.ID = mantenimientoId;
            frmParent.dataGridViewMaquina.DataSource= objModelRegMantenimientoMqns.GetMaquinaByMantenimiento(mantenimientoId);
           frmParent.dataGridViewMaquina.Columns[0].Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Validacion == 1)
            {
                frmParent.dataGridView2.Visible = false;
                frmParent.PanelADD.Visible = true;
                frmParent.dataGridView3.Visible = false;
                frmParent.PanelADDActividades.Visible = true;
            }
            else
            {
                MessageBox.Show("Debe Buscar un rango de fechas(Usando El boton de la Lupa)");    
            }

        }
    }
}

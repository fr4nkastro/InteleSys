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
using DataAccess.Entities;

namespace Presentation.Forms
{
    public partial class FrmMantenimientoDetallado : Form
    {
        public ModelMantenimiento objModelMantenimiento;
        public ModelRegMantenimientoMqns objModelRegMantenimientoMqns;
        public ModeloAverias Averias;

        public FrmMenuMantenimiento frmMenu { get; set; }
        public FrmMantenimientoDetallado()
        {
            InitializeComponent();
            objModelMantenimiento= new ModelMantenimiento();
            objModelRegMantenimientoMqns = new ModelRegMantenimientoMqns() ;
            Averias = new ModeloAverias();
        }

        private void FrmMantenimientoDetallado_Load(object sender, EventArgs e)
        {
            //dataGridViewAverias.DataSource = objDTOMantenimiento.GetAverias(frmMenu.startDate.ToShortDateString(), frmMenu.endDate.ToShortDateString());
            dataGridView2.Visible = true;
            PanelADD.Visible = false;
            TxtMaquinaID.Enabled = false;
            dataGridView3.Visible = true;
            PanelADDActividades.Visible = false;

        }
        public decimal ID=0;
        string MaquinaID;
        private void dataGridViewMaquina_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridViewMaquina.SelectedRows != null)
            {
                MaquinaID = (dataGridViewMaquina.CurrentRow.Cells[0].Value).ToString();
         
                dataGridView2.DataSource = objModelRegMantenimientoMqns.GetObservacion(ID, Convert.ToDecimal(MaquinaID));
                dataGridView1.DataSource = objModelRegMantenimientoMqns.GetRegAveriasJoined(ID, Convert.ToDecimal(MaquinaID));
                dataGridView3.DataSource = objModelRegMantenimientoMqns.SearchTareas(Convert.ToDecimal(MaquinaID));
                TxtMaquinaID.Text = MaquinaID;
                dataGridView3.Columns[4].Visible = false;
                dataGridView3.Columns[5].Visible = false;

            }

        }

        private void BtnADDObs_Click(object sender, EventArgs e)
        {
            OBSERVACIONES obs = new OBSERVACIONES();
            List<OBSERVACIONES> tableObs = objModelRegMantenimientoMqns.GetAllOBSERVACION();
            decimal newId = tableObs[tableObs.Count - 1].id + 1;
            obs.id =newId;
            obs.descripcion = TxtDescripcionAddObs.Text;
            obs.maquina_id = Convert.ToDecimal(MaquinaID);
            obs.tecnico_id = 307;
            obs.mantenimiento_id = ID;
            objModelRegMantenimientoMqns.AddObservacion(obs);
            dataGridView2.DataSource = objModelRegMantenimientoMqns.GetObservacion(ID, Convert.ToDecimal(MaquinaID));
            dataGridView2.Visible = true;
            PanelADD.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TAREAS tarea = new TAREAS();
            List<TAREAS> tableTarea = objModelRegMantenimientoMqns.GetAllTareas();
            decimal newID = tableTarea[tableTarea.Count - 1].id + 1;
            tarea.id = newID;
            tarea.descripcion = TxtDescripcionAct.Text;
            tarea.fecha_final = DatePickerFechaFinalActividades.Value;
            tarea.maquina_id = Convert.ToDecimal(MaquinaID);

            objModelRegMantenimientoMqns.AddTareas(tarea);
            dataGridView3.DataSource = objModelRegMantenimientoMqns.SearchTareas(Convert.ToDecimal(MaquinaID));
            dataGridView3.Visible = true;
            PanelADDActividades.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView3.Visible = true;
            PanelADDActividades.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            PanelADD.Visible = false;
        }
    }
}

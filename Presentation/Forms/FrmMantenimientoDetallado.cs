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
using DataAccess.DTO;

namespace Presentation.Forms
{
    public partial class FrmMantenimientoDetallado : Form
    {
        public ModeloMantenimientoFecha MantenimientoFecha;
        MAQUINA Maquina;
        public ModeloAverias Averias;
        public FrmMenuMantenimiento frmMenu { get; set; }


        //Funciones
        public void ListMaquina()
        {
            dataGridViewMaquina.DataSource = MantenimientoFecha.GetAllMaquina();

        }
        //FIn Funciones

        public FrmMantenimientoDetallado(FormHome frmHome)
        {
            InitializeComponent();
            MantenimientoFecha = new ModeloMantenimientoFecha();
            Maquina = new MAQUINA();
            Averias = new ModeloAverias();
        }

        private void FrmMantenimientoDetallado_Load(object sender, EventArgs e)
        {
            ListMaquina();
        }

        private void dataGridViewMaquina_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DataSource = Averias.repository.Search2((dataGridViewMaquina.CurrentCell.RowIndex + 1).ToString());
        }
    }
}

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
    public partial class FrmMantenimientoDetallado : Form
    {
        public ModelDTOMantenimiento objDTOMantenimiento;
        public FrmMenuMantenimiento frmMenu { get; set; }
        public FrmMantenimientoDetallado()
        {
            InitializeComponent();
            objDTOMantenimiento = new ModelDTOMantenimiento();
        }

        private void FrmMantenimientoDetallado_Load(object sender, EventArgs e)
        {
            //dataGridViewAverias.DataSource = objDTOMantenimiento.GetAverias(frmMenu.startDate.ToShortDateString(), frmMenu.endDate.ToShortDateString());
        }
    }
}

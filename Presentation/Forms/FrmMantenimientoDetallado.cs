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
        
        public FrmMenuMantenimiento frmMenu { get; set; }
        public FrmMantenimientoDetallado()
        {
            InitializeComponent();
            
        }

        private void FrmMantenimientoDetallado_Load(object sender, EventArgs e)
        {
            //dataGridViewAverias.DataSource = objDTOMantenimiento.GetAverias(frmMenu.startDate.ToShortDateString(), frmMenu.endDate.ToShortDateString());
        }
    }
}

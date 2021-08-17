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

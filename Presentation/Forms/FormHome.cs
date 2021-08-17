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
    public partial class FormHome : Form
    {
        //Objeto menu y formulario padre
        
        private bool clickMemReport;

        public Form FormActual { get; set; }
        public Form FormActualMenu { get; set; }

        public FormHome()
        {
            InitializeComponent();
            clickMemReport = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show();
        }


        private void buttonReportes_Click(object sender, EventArgs e)
        {
            
            if (clickMemReport)
            {
                panelCategoriaReportes.Enabled = false;
                panelCategoriaReportes.Visible = false;
                clickMemReport = false;
            }
            else
            {
                panelCategoriaReportes.Enabled = true;
                panelCategoriaReportes.Visible = true;
                clickMemReport = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmConfiguracionUsuarios(FormActualMenu));
            OpenFormMenu(new FrmMenuConfiguracionUsuarios(FormActual));

        }

        private void FormHome_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }

        private void panelMainFrm_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void buttonConfiguracion_Click(object sender, EventArgs e)
        {
            if (clickMemReport)
            {
                panel1.Enabled = false;
                panel1.Visible = false;
                clickMemReport = false;
            }
            else
            {
                panel1.Enabled = true;
                panel1.Visible = true;
                clickMemReport = true;
            }
        }

        private void OpenForm(Form formParent)
        {
            if (FormActual != null)
            {
                //Mantener un solo form
                FormActual.Close();
            }
            FormActual = formParent;
            formParent.TopLevel = false;
            formParent.FormBorderStyle = FormBorderStyle.None;
            formParent.Dock = DockStyle.Fill;
            panelMainFrm.Controls.Add(formParent);
            panelMainFrm.Tag = formParent;
            formParent.BringToFront();
            formParent.Show();
            
        }

            private void OpenFormMenu(Form FormHijo1)
        {
            if (FormActualMenu != null)
            {
                //Mantener un solo form
                FormActualMenu.Close();
            }
            FormActualMenu = FormHijo1;
            FormHijo1.TopLevel = false;
            FormHijo1.FormBorderStyle = FormBorderStyle.None;
            FormHijo1.Dock = DockStyle.Fill;
            panelToolBar.Controls.Add(FormHijo1);
            panelToolBar.Tag = FormHijo1;
            FormHijo1.BringToFront();
            FormHijo1.Show();
          

        }
        private void buttonInventario_Click(object sender, EventArgs e)
        {
            FrmInventario formInventario = new FrmInventario(this);
            FrmMenuInventario formMenuInventario = new FrmMenuInventario(formInventario);
            formInventario.frmMenu = formMenuInventario;

            OpenForm(formInventario);
            OpenFormMenu(formMenuInventario);

        }

        private void buttonReportesInventario_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmReportes());
            OpenFormMenu(new FrmMenuReporteAveria());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAverias_Click(object sender, EventArgs e)
        {
            FrmAverias formAverias = new FrmAverias(this);
            FrmMenuAveria formMenuAveria = new FrmMenuAveria(formAverias);
            formAverias.frmMenu = formMenuAveria;

            OpenForm(formAverias);
            OpenFormMenu(formMenuAveria);
        }

        private void buttonMantenimiento_Click(object sender, EventArgs e)
        {

            FrmMantenimientoDetallado formMantenimiento = new FrmMantenimientoDetallado();
            FrmMenuMantenimiento formMenuMante = new FrmMenuMantenimiento();
            formMantenimiento.frmMenu = formMenuMante;
            formMenuMante.frmParent=formMantenimiento;


            OpenForm(formMantenimiento);
            OpenFormMenu(formMenuMante);
        }

        private void buttonReportesAverias_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmReportes());
            OpenFormMenu(new FrmMenuReporteAveria());
        }

        private void buttonReportesMantenimiento_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmReportes());
            OpenFormMenu(new FrmMenuReporteMantenimiento());
        }

        private void buttonLogo_Click(object sender, EventArgs e)
        {
            //Agregamos funcion volve a home directamente con clic al logo

        }

        private void pictureBoxProfile_Click(object sender, EventArgs e)
        {
            if (clickMemReport)
            {
                cs.Enabled = false;
                cs.Visible = false;
                clickMemReport = false;
            }
            else
            {
                cs.Enabled = true;
                cs.Visible = true;
                clickMemReport = true;
            }
            //Agregamos funcion mostrar informacion de usuario y cerrar sesion con menu desplegable donde da info
            //confi de usuario y salir sesion
        }

        private void panelMainFrm_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLogin v1 = new FormLogin();
            v1.Show();
            this.Close();
        }

        private void panelCategoriaReportes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            new FormLogin().Show();
            this.Dispose();
        }
    }
}

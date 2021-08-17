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
    public partial class FrmMenuAveria : Form
    {
        public FrmAverias formParent { get; set; }
        
        //Variables Normales o de contadoras

        //Funciones


        //Fin de Funciones


        public FrmMenuAveria(FrmAverias formParent)
        {
            InitializeComponent();
            this.formParent = formParent;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (formParent.dataGridView1.SelectedRows.Count > 0)
                {
                    formParent.Estado = "EDITED";
                //Aqui el datagrid view empieza en 0, pero la 0 es la IP
                    formParent.PCRUD.Visible = true;
                    formParent.IDEditar = Convert.ToInt32(formParent.dataGridView1.CurrentRow.Cells[0].Value);
                    formParent.TxtDescripcionAverias.Text = formParent.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    formParent.TxtSolucion.Text = formParent.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    formParent.CBModelo.Text = formParent.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    formParent.TxtDescripcionModelo.Text = formParent.dataGridView1.CurrentRow.Cells[4].Value.ToString();

                }
                else
                {
                    MessageBox.Show("Seleccione una Fila");
                }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (formParent.dataGridView1.SelectedRows.Count > 0)
            {
                formParent.Averias.Remove(Convert.ToInt32(formParent.dataGridView1.CurrentRow.Cells[0].Value));
                formParent.ListAverias();
            }
            else
            {
                MessageBox.Show("Seleccione una Fila");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (formParent.PCRUD.Visible == false) {
                formParent.Estado = "ADDED";
                formParent.PCRUD.Visible = true;
            }
            else
            {
                formParent.PCRUD.Visible = false;
                formParent.Estado = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            formParent.dataGridView1.DataSource = formParent.Averias.repository.Search(textBox1.Text.ToUpper());
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

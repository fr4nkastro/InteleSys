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
using Domain.Models;
using DataAccess.DTO;

namespace Presentation.Forms
{

    public partial class FrmMenuInventario : Form
    {

        public FrmInventario formParent { get; set; }
        public ModelTableInventarioGeneral modelInventarioGeneral { get; set; }
        public TableInventarioGeneral objtableInventarioGeneral { get; set; }
 
        public FrmMenuInventario(FrmInventario formParent)
        {
            InitializeComponent();
            this.formParent = formParent;
            modelInventarioGeneral = new ModelTableInventarioGeneral();
            this.formParent.dataGridView1.DataSource = this.formParent.bindingSource1;
            objtableInventarioGeneral = new TableInventarioGeneral();
            updateData();
            dataGridViewStyle();
           
        }

        private void updateData()
        {
            formParent.bindingSource1.DataSource = modelInventarioGeneral.GetAll();
            
        }

        private void dataGridViewStyle()
        {
            formParent.dataGridView1.Columns[6].DefaultCellStyle.Format = "c";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmCarrito Fc = new FrmCarrito();
            Fc.Show();
        }
        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Buscar registro")
            {
                textBoxSearch.Text = "";
                textBoxSearch.ForeColor = Color.Black;
                
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
            {
                textBoxSearch.Text = "Buscar registro";
                textBoxSearch.ForeColor = Color.DimGray;
                
            }
        }

        private void FrmMenuInventario_Load(object sender, EventArgs e)
        {

            textBoxSearch.Text = "Buscar registro";
            textBoxSearch.ForeColor = Color.DimGray;
            comboBoxFiltros.Text = "Seleccione un filtro";
            comboBoxFiltros.ForeColor = Color.DimGray;
           
            
            
        }

        private void comboBoxFiltros_Enter(object sender, EventArgs e)
        {
            if (comboBoxFiltros.Text=="Seleccione un filtro")
            {
                comboBoxFiltros.Text = "";
                comboBoxFiltros.ForeColor = Color.Black;
            }
        }

        private void comboBoxFiltros_Leave(object sender, EventArgs e)
        {
            if (comboBoxFiltros.Text =="")
            {
                comboBoxFiltros.Text = "Seleccione un filtro";
                comboBoxFiltros.ForeColor = Color.DimGray;
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            
            if (textBoxSearch.Text!="Buscar registro")
            {
                //foreach (var item in modelInventarioGeneral.Search(textBoxSearch.Text))
                //{
                //    Console.WriteLine(item.Descripción);
                //}
                //Console.WriteLine("-----------------------------------------------------------------");
                //Console.WriteLine("filter= {0}",textBoxSearch.Text);

                formParent.bindingSource1.DataSource = modelInventarioGeneral.Search(textBoxSearch.Text.ToUpper()) ;
                
            }
            

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            
            formParent.clearComponents();
            if (formParent.dataGridView1.SelectedRows.Count>0)
            {
                formParent.status = 1;
                objtableInventarioGeneral.Cantidad= int.Parse(formParent.dataGridView1.CurrentRow.Cells[4].Value.ToString());
                objtableInventarioGeneral.Descripción = formParent.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                objtableInventarioGeneral.No_Serie= formParent.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                objtableInventarioGeneral.Precio= decimal.Parse(formParent.dataGridView1.CurrentRow.Cells[6].Value.ToString());
                objtableInventarioGeneral.Modelo= formParent.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                objtableInventarioGeneral.Tipo_Articulo= formParent.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                objtableInventarioGeneral.ID = decimal.Parse(formParent.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                
                formParent.textBoxDescripcion.Text = objtableInventarioGeneral.Descripción;
                formParent.textBoxSerialNo.Text = objtableInventarioGeneral.No_Serie;
                formParent.comboBoxModeloMaquina.Text = objtableInventarioGeneral.Modelo.ToString();
                formParent.textBoxPrecioCosto.Text = objtableInventarioGeneral.Precio.ToString();
                formParent.textBoxCantidad.Text = objtableInventarioGeneral.Cantidad.ToString();
                formParent.comboBoxTipoArticulo.Text = objtableInventarioGeneral.Tipo_Articulo.ToString();

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            formParent.status = 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {

        }
    }
}


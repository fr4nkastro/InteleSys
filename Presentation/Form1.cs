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

namespace Presentation
{
    public partial class Form1 : Form
    {
        //ModelCustomTable model;
        ModelTableInventarioPiezas model;
        ModelPiezas modelPiezas;
        ModelArticulos modelArticulos;
        List<PIEZAS> table;
        List<ARTICULO> tableArticulos;
        

        
        public Form1()
        {
            InitializeComponent();
            //model = new ModelCustomTable();
            model = new ModelTableInventarioPiezas();
            modelPiezas = new ModelPiezas();
            modelArticulos = new ModelArticulos();
            table = modelPiezas.GetAll();
            tableArticulos = modelArticulos.GetAll();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = model.GetModels();
            loadDataGridView();
            textBoxDescripcion.Text = "Descripción";
            textBoxPrecioCosto.Text = "Precio Costo";
            textBoxSerialNo.Text = "No.Serie";

        }
        private void updateData()
        {
            tableArticulos = modelArticulos.GetAll();
            table = modelPiezas.GetAll();
            dataGridView1.DataSource = table;
        }

        private void loadDataGridView()
        {
            updateData();
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource=model.Search(textBox1.Text);
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            //Modelo ID
            //comboBox1.SelectedIndex.
            string modeloIdSelected = comboBox1.GetItemText(comboBox1.SelectedItem);
            
            //Console.WriteLine(modeloID);
            PIEZAS objPieza = new PIEZAS();
            updateData();
            ARTICULO lastArticulo = tableArticulos[tableArticulos.Count -1];
            //Articulo ID
            decimal lastId = lastArticulo.articulo_id;
            decimal newId = lastId++;

            ARTICULO objArticulo = new ARTICULO();
            objArticulo.articulo_id = newId;
            objArticulo.tipo_articulo_id = 2002;

            //modelArticulos.Add(objArticulo);

            objPieza.articulo_id = newId;
            objPieza.descripcion = textBoxDescripcion.Text;
            objPieza.precio_costo = decimal.Parse(textBoxPrecioCosto.Text);
            objPieza.modelo_id = model.modeloMaquinas[comboBox1.SelectedIndex].id; 
            objPieza.isv = objPieza.precio_costo * (decimal)0.15;
            objPieza.iva = objPieza.precio_costo * (decimal)0.25;
            objPieza.serialno = textBoxSerialNo.Text;

            //modelPiezas.Add(objPieza);

            updateData();


        }

        private void textBoxSerialNo_Enter(object sender, EventArgs e)
        {
            if (textBoxSerialNo.Text== "No.Serie")
            {
                textBoxSerialNo.Text = "";
            }
        }

        private void textBoxSerialNo_Leave(object sender, EventArgs e)
        {
            if (textBoxSerialNo.Text == "")
            {
                textBoxSerialNo.Text = "No.Serie";
            }
        }

        private void textBoxDescripcion_Leave(object sender, EventArgs e)
        {
            if (textBoxDescripcion.Text == "")
            {
                textBoxDescripcion.Text = "Descripción";
            }
        }

        private void textBoxDescripcion_Enter(object sender, EventArgs e)
        {
            if (textBoxDescripcion.Text == "Descripción")
            {
                textBoxDescripcion.Text = "";
            }
        }

        private void textBoxPrecioCosto_Leave(object sender, EventArgs e)
        {
            if (textBoxPrecioCosto.Text == "")
            {
                textBoxPrecioCosto.Text = "Precio Costo";
            }
        }

        private void textBoxPrecioCosto_Enter(object sender, EventArgs e)
        {
            if(textBoxPrecioCosto.Text=="Precio Costo")
            {
                textBoxPrecioCosto.Text = "";
            }
        }
    }
}

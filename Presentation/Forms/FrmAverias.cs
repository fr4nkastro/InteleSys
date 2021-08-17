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
    public partial class FrmAverias : Form
    {
        public ModeloAverias Averias;
        MODELO MODELO;
        public FrmMenuAveria frmMenu { get; set; }
        public string Estado;
        public int IDEditar;

        //Funciones
        public void ListAverias()
        {
            dataGridView1.DataSource = Averias.GetAllAverias();

        }
        private void limpiar()
        {
            TxtDescripcionAverias.Clear();
            TxtDescripcionModelo.Clear();
            TxtSolucion.Clear();
            Estado = "";
        }

        private void Agregar()
        {
            ModeloAverias modeloAverias = new ModeloAverias();
            List<AVERIAS> tableAverias = modeloAverias.GetAll();
            AVERIAS objAverias = new AVERIAS();
            decimal newId = tableAverias[tableAverias.Count - 1].id + 1;
            objAverias.id = newId;
            objAverias.descripcion = TxtDescripcionAverias.Text;
            objAverias.solucion = TxtSolucion.Text;
            objAverias.modelo_id = Averias.modelo[CBModelo.SelectedIndex].id;
            modeloAverias.Add(objAverias);


        }
        private void Editar()
        {
            ModeloAverias modeloAverias = new ModeloAverias();
            //List<AVERIAS> tableAverias = modeloAverias.GetAll();
            AVERIAS objAverias = new AVERIAS();
            //decimal newId = tableAverias[tableAverias.Count - 1].id + 1;
            //MessageBox.Show(IDEditar.ToString());
            objAverias.id = IDEditar;
            objAverias.descripcion = TxtDescripcionAverias.Text;
            objAverias.solucion = TxtSolucion.Text;
            objAverias.modelo_id = Averias.modelo[CBModelo.SelectedIndex].id;
            modeloAverias.Edit(objAverias);


        }


        // Fin de Funciones

        public FrmAverias(FormHome frmHome)
        {
            InitializeComponent();
            Averias = new ModeloAverias();
            MODELO = new MODELO();
            PCRUD.Visible = false;
            CBModelo.DataSource = Averias.GetModelo();
            CBModelo.SelectedIndex = 0;
            TxtDescripcionModelo.Enabled = false;

        }

        private void FrmAverias_Load(object sender, EventArgs e)
        {
            ListAverias();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Estado == "ADDED")
            {
                if (TxtDescripcionAverias.TextLength>0)
                {
                    if (TxtSolucion.TextLength>0)
                    { 
                        Agregar();
                        limpiar();
                    }
                    else
                    {

                        MessageBox.Show("Requerimos Una Solucion");
                    }
                }
                else
                {
                    MessageBox.Show("Requerimos Una Descripcion");
                }
            }
            else if (Estado == "EDITED")
            {
                if (TxtDescripcionAverias.TextLength > 0)
                {
                    if (TxtSolucion.TextLength > 0)
                    {
                       Editar();
                        limpiar();
                    }
                    else
                    {

                        MessageBox.Show("Requerimos Una Solucion");
                    }
                }
                else
                {
                    MessageBox.Show("Requerimos Una Descripcion");
                }
            }
            ListAverias();
        }

        private void CBModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtDescripcionModelo.Text = Averias.modelo[CBModelo.SelectedIndex].Descripcion.ToString();
        }
    }   
}

using System;
using System.Collections;
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
    public partial class FrmInventario : Form
    {
        public enum Status
        {
            Add,
            Edit
        }
        public int status { get; set; }
        ModelTableInventarioGeneral modelInventarioGeneral;
        ModelArticulos modelArticulos;
        ModelArticuloInventario modelArticuloInventario;
        public FrmMenuInventario frmMenu { get; set; }
        ArrayList models;
        decimal modeloID;
        public FrmInventario(FormHome frmHome)
        {
            InitializeComponent();
            modelArticulos = new ModelArticulos();
            models = new ArrayList();
            modelArticuloInventario = new ModelArticuloInventario();
        }
        public bool isCaracterValido(Char c)
        {
            if ((c >= '0' && c <= '9'))
            {
                return true;
            }
            return false;
        }
    
        private decimal validateInventario()
        {
            switch (comboBoxInventario.Text)
            {
                case "San Pedro Sula":
                    return 201;
                    break;
                case "Tegucigalpa":
                    return 202;
                    break;
                default:
                    return 1;
            }
        }

        private bool Validacion()
        {
            if (textBoxSerialNo.TextLength>3 && textBoxSerialNo.Text!= "No.Serie")
            {
                if (textBoxDescripcion.TextLength > 0 && textBoxDescripcion.Text != "Descripción")
                {
                    if (textBoxPrecioCosto.TextLength > 0 && textBoxPrecioCosto.Text != "Precio Costo")
                    {
                        if (textBoxCantidad.TextLength > 0 && textBoxCantidad.Text != "Cantidad")
                        {
                            if ( comboBoxModeloMaquina.Text != "Seleccione un modelo")
                            {
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Selecione Un Modelo");
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Es Necesario La Cantidad");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Es Necesario El Precio");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Es Necesario La Descripcion");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Es Necesario El Numero de Serie");
                return false;
            }

        }



        private void FrmInventario_Load(object sender, EventArgs e)
        {
            panelCrud.Visible = false;
            comboBoxInventario.SelectedIndex = 0;
            modelInventarioGeneral = frmMenu.modelInventarioGeneral;
            models = modelInventarioGeneral.GetModeloMaquina();
            models.Insert(0, "Seleccione un modelo");
            comboBoxModeloMaquina.ForeColor = Color.DimGray;
            comboBoxModeloMaquina.DataSource = models;
            comboBoxModeloMaquina.SelectedIndex = 0;
            comboBoxTipoArticulo.DataSource = modelInventarioGeneral.GetTipoArticulo();
            
            textBoxDescripcion.Text = "Descripción";
            textBoxPrecioCosto.Text = "Precio Costo";
            textBoxSerialNo.Text = "No.Serie";
            textBoxCantidad.Text = "Cantidad";

            //comboBoxModeloId.Text = "Seleccione modelo maquina...";



        }

        private void textBoxSerialNo_Enter(object sender, EventArgs e)
        {
            if (textBoxSerialNo.Text == "No.Serie")
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
            if (textBoxPrecioCosto.Text == "Precio Costo")
            {
                textBoxPrecioCosto.Text = "";
            }
        }
        private void textBoxCantidad_Enter(object sender, EventArgs e)
        {
            if (textBoxCantidad.Text == "Cantidad")
            {
                textBoxCantidad.Text = "";
            }
        }
        private void textBoxCantidad_Leave(object sender, EventArgs e)
        {
            if (textBoxCantidad.Text == "")
            {
                textBoxCantidad.Text = "Cantidad";
            }
        }

        private void comboBoxModeloId_Enter(object sender, EventArgs e)
        {
            
            if (comboBoxModeloMaquina.Text == "Seleccione un modelo")
            {
                Console.WriteLine("EnterCombobox");
                models.RemoveAt(0);
                comboBoxModeloMaquina.DataSource = models;
                comboBoxModeloMaquina.Text = "";
                comboBoxModeloMaquina.ForeColor = Color.Black;
            }
        }

        private void comboBoxModeloId_Leave(object sender, EventArgs e)
        {
            if (comboBoxModeloMaquina.Text == "")
            {
                models.Insert(0, "Seleccione un modelo");
                comboBoxModeloMaquina.DataSource = models;
                comboBoxModeloMaquina.SelectedIndex = 0;
                comboBoxModeloMaquina.ForeColor = Color.DimGray;
            }

        }

        private void comboBoxModeloId_TextChanged(object sender, EventArgs e)
        {
            
                if (comboBoxModeloMaquina.SelectedIndex < 0)
                {
                    //comboBoxModeloId.Text = "Seleccione modelo maquina";
                }
                else
                {
                    //comboBoxModeloId.Text = comboBoxModeloId.SelectedText;
                }
            
        }

        private void comboBoxModeloId_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }


        private void Add()
        {
            
            ModelArticulos modelArticulos = new ModelArticulos();
            List<ARTICULO> tableArticulos = modelArticulos.GetAll();
            ModelPiezas modelPiezas = new ModelPiezas();
            ARTICULO_INVENTARIO objArticuloInventario = new ARTICULO_INVENTARIO();
            PIEZAS objPieza = new PIEZAS();


            //Articulo ID

            decimal newId = tableArticulos[tableArticulos.Count - 1].articulo_id + 1;

            ARTICULO objArticulo = new ARTICULO();
            objArticulo.articulo_id = newId;
            objArticulo.tipo_articulo_id = tableArticulos[this.comboBoxTipoArticulo.SelectedIndex].tipo_articulo_id;
            //Console.WriteLine("articulo_id={0}\n tipo_articulo_id:{1}", objArticulo.articulo_id, objArticulo.tipo_articulo_id);


            //decimal.Parse(comboBoxTipoArticulo.GetItemText(this.comboBoxTipoArticulo.SelectedItem));

            modelArticulos.Add(objArticulo);

            objPieza.articulo_id = newId;
            objPieza.descripcion = textBoxDescripcion.Text;
            objPieza.precio_costo = decimal.Parse(textBoxPrecioCosto.Text);
            objPieza.modelo_id = modelInventarioGeneral.modeloMaquinas[comboBoxModeloMaquina.SelectedIndex -1 ].id;
            objPieza.isv = objPieza.precio_costo * (decimal)0.15;
            objPieza.iva = objPieza.precio_costo * (decimal)0.25;
            objPieza.serialno = textBoxSerialNo.Text;

            modelPiezas.Add(objPieza);

            //ARTICULO_INVENTARIO
            objArticuloInventario.articulo_id = newId;
            objArticuloInventario.cantidad = decimal.Parse(textBoxCantidad.Text);
            objArticuloInventario.inventario_id = validateInventario();

            modelArticuloInventario.Add(objArticuloInventario);
        }

        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            if (status==(int)Status.Add)
            {
                if (Validacion())
                {
                    Add();
                    MessageBox.Show("Añadido Exitosamente");
                }
              
            }
            else if (status==(int)Status.Edit)
            {
                if (Validacion())
                {
                    Edit();
                    MessageBox.Show("Editado Exitosamente");
                }
            }

            panelCrud.Visible = false;
            bindingSource1.DataSource = modelInventarioGeneral.GetAll();
            
        }
        
        private void Edit()
        {
            ModelArticulos modelArticulos = new ModelArticulos();
            ModelPiezas modelPiezas = new ModelPiezas();
            ARTICULO_INVENTARIO objArticuloInventario = new ARTICULO_INVENTARIO();
            PIEZAS objPieza = new PIEZAS();

            objArticuloInventario.articulo_id = frmMenu.objtableInventarioGeneral.ID;
            objArticuloInventario.inventario_id = validateInventario();
            objArticuloInventario.cantidad = decimal.Parse(textBoxCantidad.Text);
            modelArticuloInventario.Edit(objArticuloInventario);

            objPieza.articulo_id = frmMenu.objtableInventarioGeneral.ID;
            objPieza.descripcion = textBoxDescripcion.Text;
            objPieza.precio_costo = decimal.Parse(textBoxPrecioCosto.Text);
            objPieza.serialno = textBoxSerialNo.Text;
            objPieza.isv = (objPieza.precio_costo * (decimal)0.15);
            objPieza.iva = (objPieza.precio_costo * (decimal)0.2);
            objPieza.modelo_id= modelInventarioGeneral.modeloMaquinas[comboBoxModeloMaquina.SelectedIndex - 1].id;

            modelPiezas.Edit(objPieza);


        }

        public void clearComponents()
        {
            textBoxCantidad.Clear();
            textBoxDescripcion.Clear();
            textBoxCantidad.Clear();
            textBoxPrecioCosto.Clear();
            textBoxSerialNo.Clear();
            
            


        }

        private void textBoxPrecioCosto_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            
            // solo 1 punto decimal
            else if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}


namespace Presentation.Forms
{
    partial class FrmInventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventario));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelCrud = new System.Windows.Forms.Panel();
            this.buttonAñadir = new System.Windows.Forms.Button();
            this.textBoxPrecioCosto = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxSerialNo = new System.Windows.Forms.TextBox();
            this.comboBoxModeloMaquina = new System.Windows.Forms.ComboBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.comboBoxTipoArticulo = new System.Windows.Forms.ComboBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.comboBoxInventario = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelCrud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(828, 613);
            this.dataGridView1.TabIndex = 2;
            // 
            // panelCrud
            // 
            this.panelCrud.Controls.Add(this.comboBoxInventario);
            this.panelCrud.Controls.Add(this.textBoxCantidad);
            this.panelCrud.Controls.Add(this.comboBoxTipoArticulo);
            this.panelCrud.Controls.Add(this.buttonAñadir);
            this.panelCrud.Controls.Add(this.textBoxPrecioCosto);
            this.panelCrud.Controls.Add(this.textBoxDescripcion);
            this.panelCrud.Controls.Add(this.textBoxSerialNo);
            this.panelCrud.Controls.Add(this.comboBoxModeloMaquina);
            this.panelCrud.Controls.Add(this.bindingNavigator1);
            this.panelCrud.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCrud.Location = new System.Drawing.Point(828, 0);
            this.panelCrud.Name = "panelCrud";
            this.panelCrud.Size = new System.Drawing.Size(283, 613);
            this.panelCrud.TabIndex = 3;
            // 
            // buttonAñadir
            // 
            this.buttonAñadir.Location = new System.Drawing.Point(46, 296);
            this.buttonAñadir.Name = "buttonAñadir";
            this.buttonAñadir.Size = new System.Drawing.Size(75, 23);
            this.buttonAñadir.TabIndex = 8;
            this.buttonAñadir.Text = "Añadir";
            this.buttonAñadir.UseVisualStyleBackColor = true;
            this.buttonAñadir.Click += new System.EventHandler(this.buttonAñadir_Click);
            // 
            // textBoxPrecioCosto
            // 
            this.textBoxPrecioCosto.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrecioCosto.Location = new System.Drawing.Point(21, 208);
            this.textBoxPrecioCosto.Name = "textBoxPrecioCosto";
            this.textBoxPrecioCosto.Size = new System.Drawing.Size(250, 28);
            this.textBoxPrecioCosto.TabIndex = 7;
            this.textBoxPrecioCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPrecioCosto.Enter += new System.EventHandler(this.textBoxPrecioCosto_Enter);
            this.textBoxPrecioCosto.Leave += new System.EventHandler(this.textBoxPrecioCosto_Leave);
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescripcion.Location = new System.Drawing.Point(21, 174);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(250, 28);
            this.textBoxDescripcion.TabIndex = 6;
            this.textBoxDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDescripcion.Enter += new System.EventHandler(this.textBoxDescripcion_Enter);
            this.textBoxDescripcion.Leave += new System.EventHandler(this.textBoxDescripcion_Leave);
            // 
            // textBoxSerialNo
            // 
            this.textBoxSerialNo.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSerialNo.Location = new System.Drawing.Point(21, 140);
            this.textBoxSerialNo.Name = "textBoxSerialNo";
            this.textBoxSerialNo.Size = new System.Drawing.Size(250, 28);
            this.textBoxSerialNo.TabIndex = 5;
            this.textBoxSerialNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSerialNo.Enter += new System.EventHandler(this.textBoxSerialNo_Enter);
            this.textBoxSerialNo.Leave += new System.EventHandler(this.textBoxSerialNo_Leave);
            // 
            // comboBoxModeloMaquina
            // 
            this.comboBoxModeloMaquina.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxModeloMaquina.FormattingEnabled = true;
            this.comboBoxModeloMaquina.Location = new System.Drawing.Point(21, 70);
            this.comboBoxModeloMaquina.Name = "comboBoxModeloMaquina";
            this.comboBoxModeloMaquina.Size = new System.Drawing.Size(250, 29);
            this.comboBoxModeloMaquina.TabIndex = 4;
            this.comboBoxModeloMaquina.TextChanged += new System.EventHandler(this.comboBoxModeloId_TextChanged);
            this.comboBoxModeloMaquina.Enter += new System.EventHandler(this.comboBoxModeloId_Enter);
            this.comboBoxModeloMaquina.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxModeloId_KeyDown);
            this.comboBoxModeloMaquina.Leave += new System.EventHandler(this.comboBoxModeloId_Leave);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(283, 31);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // comboBoxTipoArticulo
            // 
            this.comboBoxTipoArticulo.FormattingEnabled = true;
            this.comboBoxTipoArticulo.Location = new System.Drawing.Point(21, 105);
            this.comboBoxTipoArticulo.Name = "comboBoxTipoArticulo";
            this.comboBoxTipoArticulo.Size = new System.Drawing.Size(250, 24);
            this.comboBoxTipoArticulo.TabIndex = 10;
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCantidad.Location = new System.Drawing.Point(21, 242);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(250, 28);
            this.textBoxCantidad.TabIndex = 11;
            this.textBoxCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxInventario
            // 
            this.comboBoxInventario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInventario.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxInventario.FormattingEnabled = true;
            this.comboBoxInventario.Items.AddRange(new object[] {
            "San Pedro Sula",
            "Tegucigalpa"});
            this.comboBoxInventario.Location = new System.Drawing.Point(21, 35);
            this.comboBoxInventario.Name = "comboBoxInventario";
            this.comboBoxInventario.Size = new System.Drawing.Size(250, 29);
            this.comboBoxInventario.TabIndex = 12;
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1111, 613);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelCrud);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmInventario";
            this.Text = "frmInventario";
            this.Load += new System.EventHandler(this.FrmInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelCrud.ResumeLayout(false);
            this.panelCrud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Panel panelCrud;
        public System.Windows.Forms.BindingSource bindingSource1;
        public System.Windows.Forms.BindingNavigator bindingNavigator1;
        public System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        public System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        public System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        public System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        public System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        public System.Windows.Forms.TextBox textBoxPrecioCosto;
        public System.Windows.Forms.TextBox textBoxDescripcion;
        public System.Windows.Forms.TextBox textBoxSerialNo;
        public System.Windows.Forms.ComboBox comboBoxModeloMaquina;
        public System.Windows.Forms.Button buttonAñadir;
        public System.Windows.Forms.ComboBox comboBoxTipoArticulo;
        public System.Windows.Forms.ComboBox comboBoxInventario;
        public System.Windows.Forms.TextBox textBoxCantidad;
    }
}
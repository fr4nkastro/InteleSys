
namespace Presentation.Forms
{
    partial class FrmAverias
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PCRUD = new System.Windows.Forms.Panel();
            this.TxtSolucion = new System.Windows.Forms.RichTextBox();
            this.TxtDescripcionAverias = new System.Windows.Forms.RichTextBox();
            this.lbDescripcionAveria = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBModelo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDescripcionModelo = new System.Windows.Forms.RichTextBox();
            this.lbDescripcionModelo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(903, 670);
            this.dataGridView1.TabIndex = 0;
            // 
            // PCRUD
            // 
            this.PCRUD.Controls.Add(this.button1);
            this.PCRUD.Controls.Add(this.lbDescripcionModelo);
            this.PCRUD.Controls.Add(this.TxtDescripcionModelo);
            this.PCRUD.Controls.Add(this.label2);
            this.PCRUD.Controls.Add(this.CBModelo);
            this.PCRUD.Controls.Add(this.label1);
            this.PCRUD.Controls.Add(this.lbDescripcionAveria);
            this.PCRUD.Controls.Add(this.TxtDescripcionAverias);
            this.PCRUD.Controls.Add(this.TxtSolucion);
            this.PCRUD.Dock = System.Windows.Forms.DockStyle.Right;
            this.PCRUD.Location = new System.Drawing.Point(903, 0);
            this.PCRUD.Name = "PCRUD";
            this.PCRUD.Size = new System.Drawing.Size(282, 670);
            this.PCRUD.TabIndex = 1;
            // 
            // TxtSolucion
            // 
            this.TxtSolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSolucion.Location = new System.Drawing.Point(10, 212);
            this.TxtSolucion.Name = "TxtSolucion";
            this.TxtSolucion.Size = new System.Drawing.Size(260, 106);
            this.TxtSolucion.TabIndex = 1;
            this.TxtSolucion.Text = "";
            // 
            // TxtDescripcionAverias
            // 
            this.TxtDescripcionAverias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcionAverias.Location = new System.Drawing.Point(10, 66);
            this.TxtDescripcionAverias.Name = "TxtDescripcionAverias";
            this.TxtDescripcionAverias.Size = new System.Drawing.Size(260, 106);
            this.TxtDescripcionAverias.TabIndex = 2;
            this.TxtDescripcionAverias.Text = "";
            // 
            // lbDescripcionAveria
            // 
            this.lbDescripcionAveria.AutoSize = true;
            this.lbDescripcionAveria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcionAveria.Location = new System.Drawing.Point(6, 28);
            this.lbDescripcionAveria.Name = "lbDescripcionAveria";
            this.lbDescripcionAveria.Size = new System.Drawing.Size(174, 20);
            this.lbDescripcionAveria.TabIndex = 3;
            this.lbDescripcionAveria.Text = "Descripcion de Averia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Solucion";
            // 
            // CBModelo
            // 
            this.CBModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBModelo.FormattingEnabled = true;
            this.CBModelo.Location = new System.Drawing.Point(10, 349);
            this.CBModelo.Name = "CBModelo";
            this.CBModelo.Size = new System.Drawing.Size(260, 26);
            this.CBModelo.TabIndex = 5;
            this.CBModelo.SelectedIndexChanged += new System.EventHandler(this.CBModelo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Modelo";
            // 
            // TxtDescripcionModelo
            // 
            this.TxtDescripcionModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcionModelo.Location = new System.Drawing.Point(10, 420);
            this.TxtDescripcionModelo.Name = "TxtDescripcionModelo";
            this.TxtDescripcionModelo.Size = new System.Drawing.Size(260, 106);
            this.TxtDescripcionModelo.TabIndex = 7;
            this.TxtDescripcionModelo.Text = "";
            // 
            // lbDescripcionModelo
            // 
            this.lbDescripcionModelo.AutoSize = true;
            this.lbDescripcionModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcionModelo.Location = new System.Drawing.Point(6, 388);
            this.lbDescripcionModelo.Name = "lbDescripcionModelo";
            this.lbDescripcionModelo.Size = new System.Drawing.Size(185, 20);
            this.lbDescripcionModelo.TabIndex = 8;
            this.lbDescripcionModelo.Text = "Descripcion del Modelo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAverias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 670);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PCRUD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAverias";
            this.Text = "frmAverias";
            this.Load += new System.EventHandler(this.FrmAverias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PCRUD.ResumeLayout(false);
            this.PCRUD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel PCRUD;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.RichTextBox TxtSolucion;
        public System.Windows.Forms.RichTextBox TxtDescripcionAverias;
        private System.Windows.Forms.Label lbDescripcionAveria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.RichTextBox TxtDescripcionModelo;
        private System.Windows.Forms.Label lbDescripcionModelo;
        public System.Windows.Forms.ComboBox CBModelo;
        private System.Windows.Forms.Button button1;
    }
}
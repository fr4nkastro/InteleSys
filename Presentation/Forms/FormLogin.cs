using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class FormLogin : Form
    {
        internal object panel3;

        public FormLogin()
        {
            InitializeComponent();
        }


        private void buttonShowPass_Click(object sender, EventArgs e)
        {
            if(textBoxPassword.UseSystemPasswordChar==true)
                textBoxPassword.UseSystemPasswordChar = false;
            else
                textBoxPassword.UseSystemPasswordChar = true;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            FormHome v1 = new FormHome();
            v1.Show();
            this.Hide();

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //FrmConfiguracionUsuarios v1 = new FrmConfiguracionUsuarios();
            //v1.Show();

        }
    }
}

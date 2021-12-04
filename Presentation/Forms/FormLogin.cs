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
        //string LoginName;
        string Nombre;
        //string Apellido;
        //public static SqlConnection Conectar()
        //{
        //    //SqlConnection cn = new SqlConnection("Server= localhost; Database= employeedetails; Integrated Security=True;");

        //    //cn.Open();
        //    return 0;

        //}
        //public static SqlConnection Cerrrar()
        //{
        //    //    SqlConnection cn = new SqlConnection("Server= localhost; Database= employeedetails; Integrated Security=True;");
        //    //    cn.Close();
        //    //    return cn;
        //}


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

        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBoxUser.Text = "JosueReyes";
            textBoxPassword.Text = "josuereyes";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //FrmConfiguracionUsuarios v1 = new FrmConfiguracionUsuarios();
            //v1.Show();

        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Los Campos no deben Estar Vacios");
            }
            else
            {
                //    Conectar();

                //    SqlDataAdapter da = new SqlDataAdapter("select count(*) from USUARIO WHERE nombre='" + textBoxUser.Text + "'AND PWDCOMPARE('" + textBoxPassword.Text + "',password)=1", Conectar());
                //    DataTable dt = new DataTable();
                //    da.Fill(dt);

                //    if (dt.Rows[0][0].ToString() == "1")
                //    {
                //        SqlCommand Comando = new SqlCommand("SELECT * FROM Usuario where nombre=@LoginName", Conectar());
                //        Comando.Parameters.AddWithValue("@LoginName", textBoxUser.Text);
                //        SqlDataReader registro = Comando.ExecuteReader();

                //        if (registro.Read())
                //        {
                //            LoginName = registro["nombre"].ToString();
                //            Nombre = registro["Nombre"].ToString();
                //        }
                MessageBox.Show("Bienvenid@ " + Nombre);

                    FormHome v1 = new FormHome();
                    v1.Show();
                    this.Hide();
                
                

            }
        }
    }
}

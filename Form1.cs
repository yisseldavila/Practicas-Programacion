using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Practica_4
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
        }


        private void lblpw_Click(object sender, EventArgs e)
        {

        }
        public void Login()
        {
            SqlConnection conexion = new SqlConnection(@"server=LAPTOP-K25PIARL\SQLEXPRESS; database=miLogin; INTEGRATED SECURITY=true"
);
            conexion.Open();
            SqlCommand cmd = new SqlCommand(" SELECT Usuario, Password FROM miRegistro WHERE Usuario=@Usuario AND Password=@Password",
                conexion);
            cmd.Parameters.AddWithValue("@Usuario", textBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@Password", txtp.Text.Trim());
                
            SqlDataReader Lector = cmd.ExecuteReader();

            if (Lector.Read())
            {
                conexion.Close();
                MessageBox.Show("Login Exitoso");
                Form1 Index = new Form1();
                Index.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error", "ERROR",
                MessageBoxButtons.OK);
            }

        }
        private void btnl_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtp_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

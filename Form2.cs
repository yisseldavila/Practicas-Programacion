using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Practica_4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void funRegistro()
        {
            SqlConnection conexion = new SqlConnection(@"server=LAPTOP-K25PIARL\SQLEXPRESS; database=miLogin; INTEGRATED SECURITY=true"
);
            conexion.Open();

            string vConsultaSQL = "INSERT INTO miRegistro (Usuario, Password) VALUES ('" +
                                  txtu.Text.Trim() + "', '" + txtp.Text.Trim() + "')";

            SqlCommand cmdmiRegistro = new SqlCommand(vConsultaSQL, conexion);
            cmdmiRegistro.ExecuteNonQuery();

            conexion.Close();
        }
       

        private void lblerror_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txtc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnc_Click(object sender, EventArgs e)
        {
            funRegistro();
            funRegistro();

            if (txtc.Text == txtp.Text)
            {
                MessageBox.Show("You've signed a new user", "NEW REGISTER", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("You've entered incorrect login details", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void btnr_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}

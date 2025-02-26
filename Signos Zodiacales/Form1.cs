using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Signos_Zodiacales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //ESTA PARTE DEL CODIGO SE AGREGARAN LOS NUMERO 01 AL 30 PARA QUE EL USUARIO ELIGA EL DIA DE NACIMIENTO 
            //UTILIZANDO COMBOBOX
            cmbDia.Items.Add(01);
            cmbDia.Items.Add(02);
            cmbDia.Items.Add(03);
            cmbDia.Items.Add(04);
            cmbDia.Items.Add(05);
            cmbDia.Items.Add(06);
            cmbDia.Items.Add(07);
            cmbDia.Items.Add(08);
            cmbDia.Items.Add(09);
            cmbDia.Items.Add(10);
            cmbDia.Items.Add(11);
            cmbDia.Items.Add(12);
            cmbDia.Items.Add(13);
            cmbDia.Items.Add(14);
            cmbDia.Items.Add(15);
            cmbDia.Items.Add(16);
            cmbDia.Items.Add(17);
            cmbDia.Items.Add(18);
            cmbDia.Items.Add(19);
            cmbDia.Items.Add(20);
            cmbDia.Items.Add(21);
            cmbDia.Items.Add(22);
            cmbDia.Items.Add(23);
            cmbDia.Items.Add(24);
            cmbDia.Items.Add(25);
            cmbDia.Items.Add(26);
            cmbDia.Items.Add(27);
            cmbDia.Items.Add(28);
            cmbDia.Items.Add(29);
            cmbDia.Items.Add(30);
            cmbDia.Items.Add(31);
              


        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cmbDia.SelectedItem == null)//Lo utilizamos para saber si el usuario no selecciono el dia.
            {
                MessageBox.Show("Por favor, selecciona un día.");//muestra un mensaje de error
                return;//Termina la ejecucion.
            }

            int dia = Convert.ToInt32(cmbDia.SelectedItem);
            string mes = ObtenerMesSeleccionado();

            if (mes == "")//En caso del que el usuario no seleccionara un mensaje de error y termina la ejecucion de este.
            {
                MessageBox.Show("Por favor, selecciona un mes.");
                return;
            }

            string signo = ObtenerSignoZodiacal(dia, mes);//con esta funcion hacemos un llamado para que nos muestre el signo correspondiente

            MessageBox.Show($"Tu signo zodiacal es: {signo}", "Signo Zodiacal");//Muestra al usuario cual es su signo
        }

        private string ObtenerMesSeleccionado()
        {
            //Esta funcion revisara cual RaddioButton esta seleccionando el usuario
            //si el usuario elige "agosto" devuelve "agosto" y asi sucesivamente cin todos los RadioButton
            if (radioButton1.Checked) return "Enero";
            if (radioButton2.Checked) return "Febrero";
            if (radioButton3.Checked) return "Marzo";
            if (radioButton4.Checked) return "Abril";
            if (radioButton5.Checked) return "Mayo";
            if (radioButton6.Checked) return "Junio";
            if (radioButton7.Checked) return "Julio";
            if (radioButton8.Checked) return "Agosto";
            if (radioButton9.Checked) return "Septiembre";
            if (radioButton10.Checked) return "Octubre";
            if (radioButton11.Checked) return "Noviembre";
            if (radioButton12.Checked) return "Diciembre";
            return "";
        }

        private string ObtenerSignoZodiacal(int dia, string mes)
        {
            switch (mes)//Utilice la estructura Switch para poder determinar el signo del ususario dependiendo el dia y mes que este eligiera.
                //Si es menor o igual le dara el signo correspondiente al usuario de no cumplirse esta condicion buscara el signo que lo cumpla asi sucesivamente en cada caso.
            {
                case "Enero": return (dia <= 19) ? "Capricornio" : "Acuario";
                case "Febrero": return (dia <= 18) ? "Acuario" : "Piscis";
                case "Marzo": return (dia <= 20) ? "Piscis" : "Aries";
                case "Abril": return (dia <= 19) ? "Aries" : "Tauro";
                case "Mayo": return (dia <= 20) ? "Tauro" : "Géminis";
                case "Junio": return (dia <= 20) ? "Géminis" : "Cáncer";
                case "Julio": return (dia <= 22) ? "Cáncer" : "Leo";
                case "Agosto": return (dia <= 22) ? "Leo" : "Virgo";
                case "Septiembre": return (dia <= 22) ? "Virgo" : "Libra";
                case "Octubre": return (dia <= 22) ? "Libra" : "Escorpio";
                case "Noviembre": return (dia <= 21) ? "Escorpio" : "Sagitario";
                case "Diciembre": return (dia <= 21) ? "Sagitario" : "Capricornio";
                default: return "Desconocido";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
  

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {


        }
    }
}

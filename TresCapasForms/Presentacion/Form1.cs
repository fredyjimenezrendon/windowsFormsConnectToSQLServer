using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            AccesoLogica capaLogica = new AccesoLogica();
            string nombreString = nombreCompleto.Text;
            string generoString = (genero1.Checked ? "Masculino" : "Femenino");
            int estratoInt = Int32.Parse(estrato.Text);
            string desempleadoString = (desempleado.Checked ? "si" : "no");
            DateTime dateTime = Convert.ToDateTime(fechaNacimiento.Text);

            capaLogica.Insert(nombreString, generoString, estratoInt, dateTime, desempleadoString);

            Application.Exit();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nombreCompleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void genero2_CheckedChanged(object sender, EventArgs e)
        {

        }
		
		
		
    }
}

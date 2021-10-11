using Laboratorio2.Data;
using Laboratorio2.Negocio;
using Laboratorio2.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            persona per = new persona();
            per.nombrePersona = textBox1.Text;
            per.edadPersona = Convert.ToInt32(textBox2.Text);
            per.descripcionPersona = textBox3.Text;
            ClsNPersona persona = new ClsNPersona();
            

            int val1 = persona.Acceso(per);
            if (val1 == 0)
            {
                persona.Guardar(per);

            }
            else
                MessageBox.Show("No ha podido ingresar porque la persona no es mayor de edad");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmVista formulario = new FrmVista();
            formulario.Show();
        }

    }
}

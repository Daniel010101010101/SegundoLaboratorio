using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laboratorio2.Negocio;

namespace Laboratorio2.Vista
{
    public partial class FrmVista : Form
    {
        public FrmVista()
        {
            InitializeComponent();
        }

        private void FrmVista_Load(object sender, EventArgs e)
        {
            ClsNPersona clsNPersona = new ClsNPersona();
            var ok = clsNPersona.ListFinal();

            foreach (var iterar in ok)
            {
               dataGridView1.Rows.Add(iterar.nombrePersona, iterar.edadPersona, iterar.descripcionPersona);
            }
        }
    }
}

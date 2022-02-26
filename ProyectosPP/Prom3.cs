using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectosPP.Proyectos
{
    public partial class Prom3 : Form
    {
        public Prom3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             txtprom.Text = ((double.Parse(txtcal1.Text) + double.Parse(txtcal2.Text) + double.Parse(txtcal3.Text)) / 3).ToString();
            Clases.Promedio opromedio = new Clases.Promedio();
           
            opromedio.Calificacion1 = double.Parse(txtcal1.Text);
            opromedio.Calificacion2 = double.Parse(txtcal2.Text);

            opromedio.Calificacion3 = double.Parse(txtcal3.Text);


            txtprom.Text = opromedio.calcularpromedio().ToString();
        }

        private void txtcal1_TextChanged(object sender, EventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }

            
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtprom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

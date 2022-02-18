using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectosPP
{
    public partial class Form1 : Form
    {
        operacionesnew operacionesnew = new operacionesnew();
        double valor1 , valor2;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            if (txtvalor1.Text != string.Empty)
                valor1 = Convert.ToDouble(txtvalor1.Text);
            if (txtvalor2.Text != string.Empty)
                valor2 = Convert.ToDouble(txtvalor2.Text);
            txtresultado.Text = operacionesnew.suma(valor1, valor2).ToString();
            

        }

        private void btnrestar_Click(object sender, EventArgs e)
        {
            
                if (txtvalor1.Text != string.Empty)
                    valor1 = Convert.ToDouble(txtvalor1.Text);
                if (txtvalor2.Text != string.Empty)
                    valor2 = Convert.ToDouble(txtvalor2.Text);
                txtresultado.Text = operacionesnew.resta(valor1, valor2).ToString();


            
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {

            if (txtvalor1.Text != string.Empty)
                valor1 = Convert.ToDouble(txtvalor1.Text);
            if (txtvalor2.Text != string.Empty)
                valor2 = Convert.ToDouble(txtvalor2.Text);
            txtresultado.Text = operacionesnew.multiplicar(valor1, valor2).ToString();
        }

        private void btndividir_Click(object sender, EventArgs e)
        {

            if (txtvalor1.Text != string.Empty)
                valor1 = Convert.ToDouble(txtvalor1.Text);
            if (txtvalor2.Text != string.Empty)
                valor2 = Convert.ToDouble(txtvalor2.Text);
            txtresultado.Text = operacionesnew.dividir(valor1, valor2).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

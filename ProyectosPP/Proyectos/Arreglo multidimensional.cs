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
    public partial class Arreglo_multidimensional : Form
    {
        public Arreglo_multidimensional()
        {
            InitializeComponent();
        }
       //rivate static object pila;
        Stack <string> pila = new Stack <string>();
        int c = 0;

        private void Arreglo_multidimensional_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pila.Push(txtbox1.Text);
            c++;
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            DataGridViewRow row; 
            for (int p = 0; p < c; p++)
            {
                row = new DataGridViewRow();
                row.CreateCells(this.dataGridView1);
                row.Cells[0].Value = pila.Pop();
                this.dataGridView1.Rows.Add(row);
                
               
            }
            else
                MessageBox.Show)("Pila vacia");
        }
        
    }
}

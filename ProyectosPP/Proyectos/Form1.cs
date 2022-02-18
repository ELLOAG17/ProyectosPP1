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
    public partial class formcalificacion : Form
    {
        public formcalificacion()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void btnpromedio_Click(object sender, EventArgs e)
        {
            txtpromedio.Text = ((double.Parse(txtvalor1.Text) + double.Parse(txtvalor2.Text) + double.Parse(txtvalor3.Text) + double.Parse

               (txtvalor4.Text) + double.Parse(txtvalor5.Text)) / 5).ToString();
        }
    }
}

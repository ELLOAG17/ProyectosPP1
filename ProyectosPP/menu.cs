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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 ca = new Form1();
            ca.Show();
        }

        private void salidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void promedioDe5CalificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formcalificacion ca = new formcalificacion();
            ca.Show();
        }

        private void programasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calculadoraSencillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proyectos.calculadoraSC x = new Proyectos.calculadoraSC();
            x.Show();
        }

        private void arregloBidimensionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proyectos.arreglobidimensionales l = new Proyectos.arreglobidimensionales();
            l.Show();
        }

        private void arregloMultidimensopnalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proyectos.Arreglo_multidimensional m = new Proyectos.Arreglo_multidimensional();
            m.Show();

        }

        private void promedioDeTresCalificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ProyectosPP.Proyectos.Prom3 d = new ProyectosPP.Proyectos.Prom3();
            d.Show();

        }
    } 
}



    


    
    


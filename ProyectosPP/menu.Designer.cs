namespace ProyectosPP
{
    partial class menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promedioDe5CalificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraSencillaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arregloBidimensionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programasToolStripMenuItem,
            this.salidaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programasToolStripMenuItem
            // 
            this.programasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem,
            this.promedioDe5CalificacionesToolStripMenuItem,
            this.calculadoraSencillaToolStripMenuItem,
            this.arregloBidimensionalToolStripMenuItem});
            this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            this.programasToolStripMenuItem.Size = new System.Drawing.Size(146, 38);
            this.programasToolStripMenuItem.Text = "Programas";
            this.programasToolStripMenuItem.Click += new System.EventHandler(this.programasToolStripMenuItem_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(458, 44);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // promedioDe5CalificacionesToolStripMenuItem
            // 
            this.promedioDe5CalificacionesToolStripMenuItem.Name = "promedioDe5CalificacionesToolStripMenuItem";
            this.promedioDe5CalificacionesToolStripMenuItem.Size = new System.Drawing.Size(458, 44);
            this.promedioDe5CalificacionesToolStripMenuItem.Text = "Promedio de 5 calificaciones ";
            this.promedioDe5CalificacionesToolStripMenuItem.Click += new System.EventHandler(this.promedioDe5CalificacionesToolStripMenuItem_Click);
            // 
            // calculadoraSencillaToolStripMenuItem
            // 
            this.calculadoraSencillaToolStripMenuItem.Name = "calculadoraSencillaToolStripMenuItem";
            this.calculadoraSencillaToolStripMenuItem.Size = new System.Drawing.Size(458, 44);
            this.calculadoraSencillaToolStripMenuItem.Text = "Calculadora sencilla";
            this.calculadoraSencillaToolStripMenuItem.Click += new System.EventHandler(this.calculadoraSencillaToolStripMenuItem_Click);
            // 
            // salidaToolStripMenuItem
            // 
            this.salidaToolStripMenuItem.Name = "salidaToolStripMenuItem";
            this.salidaToolStripMenuItem.Size = new System.Drawing.Size(97, 38);
            this.salidaToolStripMenuItem.Text = "Salida";
            this.salidaToolStripMenuItem.Click += new System.EventHandler(this.salidaToolStripMenuItem_Click);
            // 
            // arregloBidimensionalToolStripMenuItem
            // 
            this.arregloBidimensionalToolStripMenuItem.Name = "arregloBidimensionalToolStripMenuItem";
            this.arregloBidimensionalToolStripMenuItem.Size = new System.Drawing.Size(458, 44);
            this.arregloBidimensionalToolStripMenuItem.Text = "Arreglo bidimensional";
            this.arregloBidimensionalToolStripMenuItem.Click += new System.EventHandler(this.arregloBidimensionalToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promedioDe5CalificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraSencillaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arregloBidimensionalToolStripMenuItem;
    }
}


namespace ProyectosPP

{
    partial class formcalificacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtvalor1 = new System.Windows.Forms.TextBox();
            this.txtvalor2 = new System.Windows.Forms.TextBox();
            this.txtvalor3 = new System.Windows.Forms.TextBox();
            this.txtvalor4 = new System.Windows.Forms.TextBox();
            this.txtvalor5 = new System.Windows.Forms.TextBox();
            this.btnpromedio = new System.Windows.Forms.Button();
            this.txtpromedio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(250, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calificacion 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(250, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Califiacion 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Location = new System.Drawing.Point(250, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Calificacion 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label4.Location = new System.Drawing.Point(250, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Calificacion 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label5.Location = new System.Drawing.Point(250, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Calificacion 5";
            // 
            // txtvalor1
            // 
            this.txtvalor1.Location = new System.Drawing.Point(486, 128);
            this.txtvalor1.Name = "txtvalor1";
            this.txtvalor1.Size = new System.Drawing.Size(100, 31);
            this.txtvalor1.TabIndex = 6;
            // 
            // txtvalor2
            // 
            this.txtvalor2.Location = new System.Drawing.Point(486, 175);
            this.txtvalor2.Name = "txtvalor2";
            this.txtvalor2.Size = new System.Drawing.Size(100, 31);
            this.txtvalor2.TabIndex = 7;
            // 
            // txtvalor3
            // 
            this.txtvalor3.Location = new System.Drawing.Point(486, 219);
            this.txtvalor3.Name = "txtvalor3";
            this.txtvalor3.Size = new System.Drawing.Size(100, 31);
            this.txtvalor3.TabIndex = 8;
            // 
            // txtvalor4
            // 
            this.txtvalor4.Location = new System.Drawing.Point(486, 264);
            this.txtvalor4.Name = "txtvalor4";
            this.txtvalor4.Size = new System.Drawing.Size(100, 31);
            this.txtvalor4.TabIndex = 9;
            // 
            // txtvalor5
            // 
            this.txtvalor5.Location = new System.Drawing.Point(486, 312);
            this.txtvalor5.Name = "txtvalor5";
            this.txtvalor5.Size = new System.Drawing.Size(100, 31);
            this.txtvalor5.TabIndex = 10;
            // 
            // btnpromedio
            // 
            this.btnpromedio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnpromedio.Location = new System.Drawing.Point(645, 128);
            this.btnpromedio.Name = "btnpromedio";
            this.btnpromedio.Size = new System.Drawing.Size(125, 39);
            this.btnpromedio.TabIndex = 11;
            this.btnpromedio.Text = "Promedio";
            this.btnpromedio.UseVisualStyleBackColor = false;
            this.btnpromedio.Click += new System.EventHandler(this.btnpromedio_Click);
            // 
            // txtpromedio
            // 
            this.txtpromedio.Location = new System.Drawing.Point(780, 132);
            this.txtpromedio.Name = "txtpromedio";
            this.txtpromedio.Size = new System.Drawing.Size(100, 31);
            this.txtpromedio.TabIndex = 12;
            // 
            // formcalificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(892, 539);
            this.Controls.Add(this.txtpromedio);
            this.Controls.Add(this.btnpromedio);
            this.Controls.Add(this.txtvalor5);
            this.Controls.Add(this.txtvalor4);
            this.Controls.Add(this.txtvalor3);
            this.Controls.Add(this.txtvalor2);
            this.Controls.Add(this.txtvalor1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formcalificacion";
            this.Text = "Promedio de  califiaciones ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtvalor1;
        private System.Windows.Forms.TextBox txtvalor2;
        private System.Windows.Forms.TextBox txtvalor3;
        private System.Windows.Forms.TextBox txtvalor4;
        private System.Windows.Forms.TextBox txtvalor5;
        private System.Windows.Forms.Button btnpromedio;
        private System.Windows.Forms.TextBox txtpromedio;
    }
}


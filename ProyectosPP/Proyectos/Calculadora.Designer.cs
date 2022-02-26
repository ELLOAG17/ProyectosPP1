namespace ProyectosPP
{
    partial class Form1
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
            this.txtvalor1 = new System.Windows.Forms.TextBox();
            this.txtvalor2 = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btnsumar = new System.Windows.Forms.Button();
            this.btnmultiplicar = new System.Windows.Forms.Button();
            this.btnrestar = new System.Windows.Forms.Button();
            this.btndividir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // txtvalor1
            // 
            this.txtvalor1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtvalor1.Location = new System.Drawing.Point(159, 47);
            this.txtvalor1.Name = "txtvalor1";
            this.txtvalor1.Size = new System.Drawing.Size(127, 31);
            this.txtvalor1.TabIndex = 3;
            // 
            // txtvalor2
            // 
            this.txtvalor2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtvalor2.Location = new System.Drawing.Point(159, 114);
            this.txtvalor2.Name = "txtvalor2";
            this.txtvalor2.Size = new System.Drawing.Size(127, 31);
            this.txtvalor2.TabIndex = 4;
            // 
            // txtresultado
            // 
            this.txtresultado.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtresultado.Location = new System.Drawing.Point(159, 189);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(127, 31);
            this.txtresultado.TabIndex = 5;
            // 
            // btnsumar
            // 
            this.btnsumar.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnsumar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsumar.Location = new System.Drawing.Point(110, 402);
            this.btnsumar.Name = "btnsumar";
            this.btnsumar.Size = new System.Drawing.Size(112, 42);
            this.btnsumar.TabIndex = 6;
            this.btnsumar.Text = "sumar";
            this.btnsumar.UseVisualStyleBackColor = false;
            this.btnsumar.Click += new System.EventHandler(this.btnsumar_Click);
            // 
            // btnmultiplicar
            // 
            this.btnmultiplicar.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnmultiplicar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnmultiplicar.Location = new System.Drawing.Point(265, 402);
            this.btnmultiplicar.Name = "btnmultiplicar";
            this.btnmultiplicar.Size = new System.Drawing.Size(140, 42);
            this.btnmultiplicar.TabIndex = 7;
            this.btnmultiplicar.Text = "multiplicar";
            this.btnmultiplicar.UseVisualStyleBackColor = false;
            this.btnmultiplicar.Click += new System.EventHandler(this.btnmultiplicar_Click);
            // 
            // btnrestar
            // 
            this.btnrestar.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnrestar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnrestar.Location = new System.Drawing.Point(423, 402);
            this.btnrestar.Name = "btnrestar";
            this.btnrestar.Size = new System.Drawing.Size(115, 42);
            this.btnrestar.TabIndex = 8;
            this.btnrestar.Text = "restar ";
            this.btnrestar.UseVisualStyleBackColor = false;
            this.btnrestar.Click += new System.EventHandler(this.btnrestar_Click);
            // 
            // btndividir
            // 
            this.btndividir.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btndividir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btndividir.Location = new System.Drawing.Point(578, 402);
            this.btndividir.Name = "btndividir";
            this.btndividir.Size = new System.Drawing.Size(132, 42);
            this.btndividir.TabIndex = 9;
            this.btndividir.Text = "dividir";
            this.btndividir.UseVisualStyleBackColor = false;
            this.btndividir.Click += new System.EventHandler(this.btndividir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(928, 558);
            this.Controls.Add(this.btndividir);
            this.Controls.Add(this.btnrestar);
            this.Controls.Add(this.btnmultiplicar);
            this.Controls.Add(this.btnsumar);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtvalor2);
            this.Controls.Add(this.txtvalor1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora simple";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtvalor1;
        private System.Windows.Forms.TextBox txtvalor2;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btnsumar;
        private System.Windows.Forms.Button btnmultiplicar;
        private System.Windows.Forms.Button btnrestar;
        private System.Windows.Forms.Button btndividir;
    }
}


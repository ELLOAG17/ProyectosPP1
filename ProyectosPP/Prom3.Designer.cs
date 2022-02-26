namespace ProyectosPP.Proyectos
{
    partial class Prom3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcal1 = new System.Windows.Forms.TextBox();
            this.txtcal2 = new System.Windows.Forms.TextBox();
            this.txtcal3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtprom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calificacion 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Calificacion 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Calificacion 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Promedio ";
            // 
            // txtcal1
            // 
            this.txtcal1.Location = new System.Drawing.Point(447, 80);
            this.txtcal1.Name = "txtcal1";
            this.txtcal1.Size = new System.Drawing.Size(130, 31);
            this.txtcal1.TabIndex = 4;
            this.txtcal1.TextChanged += new System.EventHandler(this.txtcal1_TextChanged);
            // 
            // txtcal2
            // 
            this.txtcal2.Location = new System.Drawing.Point(447, 145);
            this.txtcal2.Name = "txtcal2";
            this.txtcal2.Size = new System.Drawing.Size(130, 31);
            this.txtcal2.TabIndex = 5;
            // 
            // txtcal3
            // 
            this.txtcal3.Location = new System.Drawing.Point(447, 207);
            this.txtcal3.Name = "txtcal3";
            this.txtcal3.Size = new System.Drawing.Size(130, 31);
            this.txtcal3.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtprom
            // 
            this.txtprom.Location = new System.Drawing.Point(447, 269);
            this.txtprom.Name = "txtprom";
            this.txtprom.ReadOnly = true;
            this.txtprom.Size = new System.Drawing.Size(130, 31);
            this.txtprom.TabIndex = 8;
            this.txtprom.TextChanged += new System.EventHandler(this.txtprom_TextChanged);
            // 
            // Prom3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtcal3);
            this.Controls.Add(this.txtcal2);
            this.Controls.Add(this.txtcal1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtprom);
            this.Name = "Prom3";
            this.Text = "Prom3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcal1;
        private System.Windows.Forms.TextBox txtcal2;
        private System.Windows.Forms.TextBox txtcal3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtprom;
    }
}
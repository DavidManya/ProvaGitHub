namespace prOperadores
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumero1 = new System.Windows.Forms.TextBox();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsuma = new System.Windows.Forms.TextBox();
            this.txtresta = new System.Windows.Forms.TextBox();
            this.txtmultiplicacion = new System.Windows.Forms.TextBox();
            this.txtdivision = new System.Windows.Forms.TextBox();
            this.txtpotencia = new System.Windows.Forms.TextBox();
            this.txtraiz = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnlimpiar);
            this.groupBox1.Controls.Add(this.btncalcular);
            this.groupBox1.Controls.Add(this.txtnumero2);
            this.groupBox1.Controls.Add(this.txtnumero1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operadores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número 2:";
            // 
            // txtnumero1
            // 
            this.txtnumero1.Location = new System.Drawing.Point(103, 29);
            this.txtnumero1.Name = "txtnumero1";
            this.txtnumero1.Size = new System.Drawing.Size(105, 20);
            this.txtnumero1.TabIndex = 2;
            // 
            // txtnumero2
            // 
            this.txtnumero2.Location = new System.Drawing.Point(103, 73);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(105, 20);
            this.txtnumero2.TabIndex = 3;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(233, 29);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(77, 20);
            this.btncalcular.TabIndex = 4;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(233, 73);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(77, 20);
            this.btnlimpiar.TabIndex = 5;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtraiz);
            this.groupBox2.Controls.Add(this.txtpotencia);
            this.groupBox2.Controls.Add(this.txtdivision);
            this.groupBox2.Controls.Add(this.txtmultiplicacion);
            this.groupBox2.Controls.Add(this.txtresta);
            this.groupBox2.Controls.Add(this.txtsuma);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(28, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 162);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Suma:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Resta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Multiplicación:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "División:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Potencia:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Raíz:";
            // 
            // txtsuma
            // 
            this.txtsuma.Location = new System.Drawing.Point(89, 19);
            this.txtsuma.Name = "txtsuma";
            this.txtsuma.Size = new System.Drawing.Size(68, 20);
            this.txtsuma.TabIndex = 6;
            // 
            // txtresta
            // 
            this.txtresta.Location = new System.Drawing.Point(89, 50);
            this.txtresta.Name = "txtresta";
            this.txtresta.Size = new System.Drawing.Size(68, 20);
            this.txtresta.TabIndex = 7;
            // 
            // txtmultiplicacion
            // 
            this.txtmultiplicacion.Location = new System.Drawing.Point(89, 81);
            this.txtmultiplicacion.Name = "txtmultiplicacion";
            this.txtmultiplicacion.Size = new System.Drawing.Size(68, 20);
            this.txtmultiplicacion.TabIndex = 8;
            // 
            // txtdivision
            // 
            this.txtdivision.Location = new System.Drawing.Point(242, 19);
            this.txtdivision.Name = "txtdivision";
            this.txtdivision.Size = new System.Drawing.Size(68, 20);
            this.txtdivision.TabIndex = 9;
            // 
            // txtpotencia
            // 
            this.txtpotencia.Location = new System.Drawing.Point(242, 50);
            this.txtpotencia.Name = "txtpotencia";
            this.txtpotencia.Size = new System.Drawing.Size(68, 20);
            this.txtpotencia.TabIndex = 10;
            // 
            // txtraiz
            // 
            this.txtraiz.Location = new System.Drawing.Point(242, 85);
            this.txtraiz.Name = "txtraiz";
            this.txtraiz.Size = new System.Drawing.Size(68, 20);
            this.txtraiz.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = ".:. Estrcturas Secuenciales .:.";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtnumero2;
        private System.Windows.Forms.TextBox txtnumero1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtraiz;
        private System.Windows.Forms.TextBox txtpotencia;
        private System.Windows.Forms.TextBox txtdivision;
        private System.Windows.Forms.TextBox txtmultiplicacion;
        private System.Windows.Forms.TextBox txtresta;
        private System.Windows.Forms.TextBox txtsuma;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}


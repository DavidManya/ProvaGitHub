namespace prBonificacion
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txthorasnormales = new System.Windows.Forms.TextBox();
            this.txthorasextras = new System.Windows.Forms.TextBox();
            this.txtpagohnormal = new System.Windows.Forms.TextBox();
            this.txtpagohextra = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nphijos = new System.Windows.Forms.NumericUpDown();
            this.chkbonificacion = new System.Windows.Forms.CheckBox();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsueldobruto = new System.Windows.Forms.TextBox();
            this.txtbonificacion = new System.Windows.Forms.TextBox();
            this.txtsueldoneto = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nphijos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsalir);
            this.groupBox1.Controls.Add(this.btncalcular);
            this.groupBox1.Controls.Add(this.btnnuevo);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtpagohextra);
            this.groupBox1.Controls.Add(this.txtpagohnormal);
            this.groupBox1.Controls.Add(this.txthorasextras);
            this.groupBox1.Controls.Add(this.txthorasnormales);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jornada Laboral";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtsueldoneto);
            this.groupBox2.Controls.Add(this.txtbonificacion);
            this.groupBox2.Controls.Add(this.txtsueldobruto);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(28, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 122);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sueldo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Horas Normales Trabajadas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horas Extras Trabajadas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pago por hora normal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pago por hora extra:";
            // 
            // txthorasnormales
            // 
            this.txthorasnormales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txthorasnormales.Location = new System.Drawing.Point(23, 51);
            this.txthorasnormales.Name = "txthorasnormales";
            this.txthorasnormales.Size = new System.Drawing.Size(124, 20);
            this.txthorasnormales.TabIndex = 4;
            // 
            // txthorasextras
            // 
            this.txthorasextras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txthorasextras.Location = new System.Drawing.Point(23, 113);
            this.txthorasextras.Name = "txthorasextras";
            this.txthorasextras.Size = new System.Drawing.Size(124, 20);
            this.txthorasextras.TabIndex = 5;
            // 
            // txtpagohnormal
            // 
            this.txtpagohnormal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpagohnormal.Location = new System.Drawing.Point(251, 51);
            this.txtpagohnormal.Name = "txtpagohnormal";
            this.txtpagohnormal.Size = new System.Drawing.Size(124, 20);
            this.txtpagohnormal.TabIndex = 6;
            // 
            // txtpagohextra
            // 
            this.txtpagohextra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpagohextra.Location = new System.Drawing.Point(251, 113);
            this.txtpagohextra.Name = "txtpagohextra";
            this.txtpagohextra.Size = new System.Drawing.Size(124, 20);
            this.txtpagohextra.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkbonificacion);
            this.groupBox3.Controls.Add(this.nphijos);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(24, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(351, 70);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bonificación:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Número de hijos:";
            // 
            // nphijos
            // 
            this.nphijos.Location = new System.Drawing.Point(120, 26);
            this.nphijos.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nphijos.Name = "nphijos";
            this.nphijos.Size = new System.Drawing.Size(51, 20);
            this.nphijos.TabIndex = 1;
            // 
            // chkbonificacion
            // 
            this.chkbonificacion.AutoSize = true;
            this.chkbonificacion.Location = new System.Drawing.Point(227, 29);
            this.chkbonificacion.Name = "chkbonificacion";
            this.chkbonificacion.Size = new System.Drawing.Size(120, 17);
            this.chkbonificacion.TabIndex = 2;
            this.chkbonificacion.Text = "Recibir Bonificación";
            this.chkbonificacion.UseVisualStyleBackColor = true;
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnnuevo.ForeColor = System.Drawing.Color.White;
            this.btnnuevo.Location = new System.Drawing.Point(24, 233);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(62, 21);
            this.btnnuevo.TabIndex = 9;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btncalcular.ForeColor = System.Drawing.Color.White;
            this.btncalcular.Location = new System.Drawing.Point(133, 233);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(62, 21);
            this.btncalcular.TabIndex = 10;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.Location = new System.Drawing.Point(251, 233);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(62, 21);
            this.btnsalir.TabIndex = 11;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sueldo Bruto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Bonificación:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Sueldo Neto:";
            // 
            // txtsueldobruto
            // 
            this.txtsueldobruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsueldobruto.Location = new System.Drawing.Point(131, 17);
            this.txtsueldobruto.Name = "txtsueldobruto";
            this.txtsueldobruto.Size = new System.Drawing.Size(98, 20);
            this.txtsueldobruto.TabIndex = 3;
            // 
            // txtbonificacion
            // 
            this.txtbonificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbonificacion.Location = new System.Drawing.Point(131, 48);
            this.txtbonificacion.Name = "txtbonificacion";
            this.txtbonificacion.Size = new System.Drawing.Size(98, 20);
            this.txtbonificacion.TabIndex = 4;
            // 
            // txtsueldoneto
            // 
            this.txtsueldoneto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsueldoneto.Location = new System.Drawing.Point(131, 78);
            this.txtsueldoneto.Name = "txtsueldoneto";
            this.txtsueldoneto.Size = new System.Drawing.Size(98, 20);
            this.txtsueldoneto.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = ".:. Bonificacion .:.";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nphijos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtpagohextra;
        private System.Windows.Forms.TextBox txtpagohnormal;
        private System.Windows.Forms.TextBox txthorasextras;
        private System.Windows.Forms.TextBox txthorasnormales;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkbonificacion;
        private System.Windows.Forms.NumericUpDown nphijos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.TextBox txtsueldoneto;
        private System.Windows.Forms.TextBox txtbonificacion;
        private System.Windows.Forms.TextBox txtsueldobruto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

